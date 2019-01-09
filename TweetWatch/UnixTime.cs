using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetWatch
{
    internal static class UnixTime
    {
        private static readonly DateTime UnixEpoch =
            new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static DateTime FromMilliseconds(long ms)
        {
            return UnixEpoch.AddMilliseconds(ms);
        }
    }
}
