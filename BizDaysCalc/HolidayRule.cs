using System;

namespace BizDaysCalc
{
    public class HolidayRule : IRule
    {
        public static readonly int[,] USHolidays = {
            { 1, 1 }, // new years day
            { 7, 4 }, // Independence day
            { 12, 24 }, // Christmas eve
            { 12, 25 } // christmas day
        };

        public bool CheckIsBusinessDay(DateTime date)
        {
            for (int day = 0; day <= USHolidays.GetUpperBound(0); day++)
            {
                if (date.Month == USHolidays[day, 0] && date.Day == USHolidays[day, 1]) return false;
            }
            return true;
        }
    }
}
