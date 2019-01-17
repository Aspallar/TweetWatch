using System;

namespace TweetWatch
{
    internal static class UnixTime
    {
        private static readonly DateTime unixEpoch =
            new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static DateTime FromMilliseconds(long ms)
        {
            return unixEpoch.AddMilliseconds(ms);
        }
    }
}
