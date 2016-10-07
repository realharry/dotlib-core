using System;
using System.Collections.Generic;
using System.Linq;

namespace DotCore.Common
{
    public static class DateTimeExtension
    {
        // Note: All DateTime args are based on local time.

        // "Epoch".
        private static readonly DateTime EPOCH = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

        public static DateTime ToLocalDateTime(this long epochMillis)
        {
            // return epochMillis.ToLocalDateTime(0L);
            return EPOCH.AddMilliseconds(epochMillis).ToLocalTime();
        }
        public static DateTime ToLocalDateTime(this long epochMillis, long delta)
        {
            return EPOCH.AddMilliseconds(epochMillis + delta).ToLocalTime();
        }

        public static DateTime ToLocalDateTime(this ulong epochMillis)
        {
            // return epochMillis.ToLocalDateTime(0UL);
            return EPOCH.AddMilliseconds(epochMillis).ToLocalTime();
        }
        public static DateTime ToLocalDateTime(this ulong epochMillis, ulong delta)
        {
            return EPOCH.AddMilliseconds(epochMillis + delta).ToLocalTime();
        }

        //public static DateTime? ToLocalDateTime(this long epochMillis)
        //{
        //    // return EPOCH.AddMilliseconds(epochMillis).ToLocalTime();
        //    return epochMillis.ToLocalDateTime(0L);
        //}
        //public static DateTime? ToLocalDateTime(this long epochMillis, long delta)
        //{
        //    DateTime? dateTime = null;
        //    try {
        //        dateTime = EPOCH.AddMilliseconds(epochMillis + delta).ToLocalTime();
        //    } catch (Exception) {
        //        // Ignore...
        //    }
        //    return dateTime;
        //}


        public static TimeSpan ToTimeSpan(this ulong millis)
        {
            int seconds = (int)(millis / 1000UL);
            int milliseconds = (int)(millis % 1000UL);
            return new TimeSpan(0, 0, 0, seconds, milliseconds);
        }


        public static long ToUnixEpochMillis(this DateTime dateTime)
        {
            return Convert.ToInt64((dateTime.ToUniversalTime() - EPOCH).TotalMilliseconds);
        }

        public static long ToTotalMilliseconds(this TimeSpan timeSpan)
        {
            // return timeSpan.TotalMilliseconds;
            return (timeSpan.Ticks / TimeSpan.TicksPerMillisecond);
        }
        public static int ToTotalSeconds(this TimeSpan timeSpan)
        {
            // return timeSpan.TotalSeconds;
            return (int)(timeSpan.Ticks / TimeSpan.TicksPerSecond);
        }

    }
}
