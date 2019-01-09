using AngleSharp.Dom.Html;
using AngleSharp.Parser.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;

namespace TweetWatch
{
    internal class TwitterPoll
    {
        private HtmlParser _parser;
        private HttpClient _client;
        private Uri _uri;
        private HashSet<string> _currentTweets;
        private IProgress<Tweet> _tweetProgress;
        private IProgress<TwitStatus> _statusProgress;
        private TwitStatus _currentStatus;
        private int _pollPeriod;

        public TwitterPoll(string url, IProgress<Tweet> tweetProgress, IProgress<TwitStatus> statusProgress, int pollPeriod, string userAgent)
        {
            _parser = new HtmlParser();
            _client = new HttpClient();
            _client.DefaultRequestHeaders.UserAgent.ParseAdd(userAgent);
            _tweetProgress = tweetProgress;
            _statusProgress = statusProgress;
            _uri = new Uri(url);
            _currentStatus = TwitStatus.Stopped;
            _pollPeriod = pollPeriod;
        }

        public void Start()
        {
            Task.Run(async () =>
            {
                while (true)
                {
                    if (_currentTweets == null)
                        await InitializeCurrentTweets();
                    else
                        await PollForNewTweets();
                }
            });
        }

        private async Task PollForNewTweets()
        {
            await Task.Delay(_pollPeriod);
            IHtmlDocument doc = await GetTwitter();
            if (doc != null)
            {
                var tweets = doc.QuerySelectorAll("div.tweet");
                foreach (var tweet in tweets)
                {
                    string id = tweet.GetAttribute("data-tweet-id");
                    if (!_currentTweets.Contains(id))
                    {
                        string time = tweet.QuerySelector("span._timestamp").GetAttribute("data-time-ms");
                        Tweet newTweet = new Tweet
                        {
                            Time = UnixTime.FromMilliseconds(long.Parse(time)),
                            Link = tweet.GetAttribute("data-permalink-path"),
                            Text = tweet.QuerySelector("p.tweet-text")?.TextContent ?? ""
                        };
                        _currentTweets.Add(id);
                        _tweetProgress.Report(newTweet);
                        break; // foreach tweet
                    }
                }
            }
        }

        private async Task InitializeCurrentTweets()
        {
            IHtmlDocument doc = await GetTwitter();
            if (doc != null)
            {
                _currentTweets = new HashSet<string>(doc.QuerySelectorAll("div.tweet")
                    .Select(x => x.GetAttribute("data-tweet-id")));
            }
            else
            {
                await Task.Delay(_pollPeriod);
            }
        }

        private async Task<IHtmlDocument> GetTwitter()
        {
            try
            {
                var page = await _client.GetStringAsync(_uri);
                UpdateStatus(TwitStatus.Working);
                var doc = _parser.Parse(page);
                return doc;
            }
            catch (HttpRequestException)
            {
                UpdateStatus(TwitStatus.Failed);
                return null;
            }
        }

        private void UpdateStatus(TwitStatus newStatus)
        {
            if (_currentStatus != newStatus)
            {
                _currentStatus = newStatus;
                _statusProgress.Report(newStatus);
            }
        }
    }
}
