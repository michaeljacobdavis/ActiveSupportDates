using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActiveSupportDates
{
    public static class TimeSpans
    {
        private static long _oneSecond = new TimeSpan(0, 0, 1).Ticks;

        public static TimeSpan Second(this int val)
        {
            return new TimeSpan(_oneSecond * val);
        }

        public static TimeSpan Seconds(this int val)
        {
            return new TimeSpan(0, 0, val);
        }

        public static TimeSpan Minute(this int val)
        {
            return Minutes(val);
        }

        public static TimeSpan Minutes(this int val)
        {
            return new TimeSpan(60.Seconds().Ticks * val);
        }

        public static TimeSpan Hour(this int val)
        {
            return Hours(val);
        }

        public static TimeSpan Hours(this int val)
        {
            return new TimeSpan(60.Minutes().Ticks * val);
        }

        public static TimeSpan Day(this int val)
        {
            return Days(val);
        }

        public static TimeSpan Days(this int val)
        {
            return new TimeSpan(24.Hours().Ticks * val);
        }

        public static TimeSpan Week(this int val)
        {
            return Weeks(val);
        }

        public static TimeSpan Weeks(this int val)
        {
            return new TimeSpan(7.Days().Ticks * val);
        }

        public static TimeSpan Month(this int val)
        {
            return Months(val);
        }

        public static TimeSpan Months(this int val)
        {
            return new TimeSpan(30.Days().Ticks * val);
        }

        public static TimeSpan Year(this int val)
        {
            return Years(val);
        }

        public static TimeSpan Years(this int val)
        {
            return new TimeSpan(365.Days().Ticks * val);
        }
    }
}
