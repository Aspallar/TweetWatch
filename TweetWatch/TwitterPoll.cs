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
        private Uri _uri;
        private HashSet<string> _currentTweets;
        private IProgress<Tweet> _tweetProgress;
        private IProgress<Exception> _statusProgress;
        private int _pollPeriod;

        public TwitterPoll(string url, IProgress<Tweet> tweetProgress, IProgress<Exception> statusProgress, int pollPeriod, string userAgent)
        {
            _parser = new HtmlParser();
            _client = new HttpClient();
            _client.DefaultRequestHeaders.UserAgent.ParseAdd(userAgent);
            _tweetProgress = tweetProgress;
            _statusProgress = statusProgress;
            _uri = new Uri(url);
            _pollPeriod = pollPeriod;
        }

        public void Start()
        {
            Task.Run(async () =>
            {
                try
                {
                    while (true)
                    {
                        if (_currentTweets == null)
                            await InitializeCurrentTweets().ConfigureAwait(false);
                        else
                            await PollForNewTweets().ConfigureAwait(false);
                        await Task.Delay(_pollPeriod).ConfigureAwait(false);
                    }
                }
                catch (Exception ex)
                {
                    _statusProgress.Report(ex);
                }
            });
        }

        private async Task PollForNewTweets()
        {
            System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString() + " Polling thread = " + System.Threading.Thread.CurrentThread.ManagedThreadId.ToString());
            IHtmlDocument doc = await GetTwitter().ConfigureAwait(false);
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
            IHtmlDocument doc = await GetTwitter().ConfigureAwait(false);
            _currentTweets = new HashSet<string>(doc.QuerySelectorAll("div.tweet")
                .Select(x => x.GetAttribute("data-tweet-id")));
        }

        private async Task<IHtmlDocument> GetTwitter()
        {
            var page = await _client.GetStringAsync(_uri).ConfigureAwait(false);
            var doc = _parser.Parse(page);
            UpdateStatus(null);
            return doc;
        }

        private void UpdateStatus(Exception ex)
        {
            _statusProgress.Report(ex);
        }
    }
}
