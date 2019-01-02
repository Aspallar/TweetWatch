using AngleSharp.Dom.Html;
using AngleSharp.Parser.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace TweetWatch
{
    internal class TwitterPoll
    {
        private HtmlParser _parser;
        private HttpClient _client;
        private string _url;
        private HashSet<string> _currentTweets;
        private IProgress<Tweet> _tweetProgress;
        private IProgress<TwitStatus> _statusProgress;
        private TwitStatus _currentStatus;
        private int _pollPeriod;

        public TwitterPoll(string url, IProgress<Tweet> tweetProgress, IProgress<TwitStatus> statusProgress, int pollPeriod)
        {
            _parser = new HtmlParser();
            _client = new HttpClient();
            _tweetProgress = tweetProgress;
            _statusProgress = statusProgress;
            _url = url;
            _currentStatus = TwitStatus.Stopped;
            _pollPeriod = pollPeriod;
        }

        public void Start()
        {
            Task.Run(async () =>
            {
                await InitializeCurrentTweets();
                while (true)
                {
                    await Task.Delay(_pollPeriod);
                    await Poll();
                }
            });
        }

        private async Task Poll()
        {
            IHtmlDocument doc = await GetTwitter();
            if (doc != null)
            {
                var tweets = doc.QuerySelectorAll("div.tweet");
                foreach (var tweet in tweets)
                {
                    string id = tweet.GetAttribute("data-tweet-id");
                    if (!_currentTweets.Contains(id))
                    {
                        Tweet newTweet = new Tweet
                        {
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
        }

        private async Task<IHtmlDocument> GetTwitter()
        {
            try
            {
                var page = await _client.GetStringAsync(_url);
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
