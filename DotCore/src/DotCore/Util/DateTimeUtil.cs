using System;
using System.Collections.Generic;
using System.Linq;
using DotCore.Common;

namespace DotCore.Util
{
    public static class DateTimeUtil
    {
        public static long CurrentUnixEpochMillis()
        {
            return DateTime.Now.ToUnixEpochMillis();
        }


        // temporary
        public static long GetMidnight(long now)
        {
            DateTime date = now.ToLocalDateTime();
            long midnight = date.Date.ToUnixEpochMillis();
            return midnight;
        }

        // temporary
        public static long GetSundayMidnight(long now)
        {
            DateTime date = now.ToLocalDateTime();
            int delta = 0 - date.DayOfWeek;
            date.AddDays((double)delta);
            long sundayMidnight = date.Date.ToUnixEpochMillis();
            return sundayMidnight;
        }

        // temporary
        public static long GetFirstDayMidnight(long now)
        {
            DateTime date = now.ToLocalDateTime();
            int delta = 0 - date.Day;
            date.AddDays((double)delta);
            long sundayMidnight = date.Date.ToUnixEpochMillis();
            return sundayMidnight;
        }

        // temporary
        public static uint GetNumberOfDaysForMonth(long now)
        {
            DateTime date = now.ToLocalDateTime();
            var numDays = 0U;
            switch (date.Month) {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    numDays = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                default:   // ???
                    numDays = 30;
                    break;
                case 2:
                    numDays = 28;
                    if ((date.Year % 4) == 0) {
                        numDays = 29;
                    }
                    break;
            }
            return numDays;
        }



    }
}
