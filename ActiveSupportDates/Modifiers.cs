﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActiveSupportDates
{

    public static class Modifiers
    {
        public static DateTime Ago(this TimeSpan val)
        {
            return Until(val, DateTime.UtcNow);
        }

        public static DateTime Until(this TimeSpan val, DateTime dateTime)
        {
            return dateTime.Subtract(val);
        }

        public static DateTime FromNow(this TimeSpan val)
        {
            return Since(val, DateTime.UtcNow);
        }

        public static DateTime Since(this TimeSpan val, DateTime dateTime)
        {
            return dateTime.Add(val);
        }
    }
}
