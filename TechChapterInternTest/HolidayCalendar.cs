using System;
using System.Collections.Generic;

namespace HolidayCalendar
{
    public class HolidayCalendar : IHolidayCalendar
    {
        public bool IsHoliday(DateTime date)
        {

            if (date.Month == 12 && date.Day == 25)
            {
                return true;
            }

            if (date.Month == 4 && date.Day == 6)
            {
                return true;
            }
            if (date.Month == 4 && date.Day == 7)
            {
                return true;
            }
            if (date.Month == 4 && date.Day == 9)
            {
                return true;
            }
            if (date.Month == 4 && date.Day == 10)
            {
                return true;
            }

            return false;
        }


        public ICollection<DateTime> GetHolidays(DateTime startDate, DateTime endDate)
        {
            var holidays = new List<DateTime>();

            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (IsHoliday(date))
                {
                    holidays.Add(date);
                }
            }

            return holidays;
        }

    }
}
