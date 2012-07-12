using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActiveSupportDates
{
    public static class NumericExtensions
    {
        #region Seconds
        public static TimeSpan Second(this int val)
        {
            return Seconds(val);
        }

        public static TimeSpan Seconds(this int val)
        {
            return Seconds((double)val);
        }

        public static TimeSpan Seconds(this double val)
        {
            return TimeSpan.FromSeconds(val);
        }
        #endregion

        #region Minutes

        public static TimeSpan Minute(this int val)
        {
            return Minutes(val);
        }

        public static TimeSpan Minutes(this int val)
        {
            return Minutes((double)val);
        }

        public static TimeSpan Minutes(this double val)
        {
            return TimeSpan.FromMinutes(val);
        }
        #endregion

        #region Hours

        public static TimeSpan Hour(this int val)
        {
            return Hours(val);
        }

        public static TimeSpan Hours(this int val)
        {
            return Hours((double)val);
        }

        public static TimeSpan Hours(this double val)
        {
            return TimeSpan.FromHours(val);
        }
        #endregion

        #region Days
        public static TimeSpan Day(this int val)
        {
            return Days(val);
        }

        public static TimeSpan Days(this int val)
        {
            return Days((double) val);
        }

        public static TimeSpan Days(this double val)
        {
            return TimeSpan.FromDays(val);
        }
        #endregion

        #region Weeks
        public static TimeSpan Week(this int val)
        {
            return Weeks(val);
        }

        public static TimeSpan Weeks(this int val)
        {
            return Weeks((double)val);
        }

        public static TimeSpan Weeks(this double val)
        {
            return TimeSpan.FromDays(val * 7);
        }
        #endregion

        #region Month
        public static TimeSpan Month(this int val)
        {
            return Months(val);
        }

        public static TimeSpan Months(this int val)
        {
            return Months((double)val);
        }

        public static TimeSpan Months(this double val)
        {
            return TimeSpan.FromDays(val * 30);
        }
        #endregion

        #region Years
        public static TimeSpan Year(this int val)
        {
            return Years(val);
        }

        public static TimeSpan Years(this int val)
        {
            return Years((double)val);
        }

        public static TimeSpan Years(this double val)
        {
            return TimeSpan.FromDays(365.25 * val);
        }
        #endregion
    }
}
