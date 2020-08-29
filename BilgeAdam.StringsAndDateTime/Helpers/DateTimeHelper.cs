using System;

namespace BilgeAdam.StringsAndDateTime.Helpers
{
    class DateTimeHelper
    {
        public string GetNow()
        {
            return DateTime.Now.ToString();
        }

        public string GetOneMonthBefore()
        {
            return DateTime.Now.AddMonths(-1).ToString();
        }

        public string GetThreeMonthsLater()
        {
            return DateTime.Now.AddMonths(3).ToString();
        }

        public string GetYesterday()
        {
            return DateTime.Now.AddDays(-1).ToString();
        }

        public string GetTomorrow()
        {
            return DateTime.Now.AddDays(1).ToString();
        }

        public string GetLastYear()
        {
            return DateTime.Now.AddYears(-1).ToString();
        }

        public string GetTwoYearsLater()
        {
            return DateTime.Now.AddYears(2).ToString();
        }

        public double GetDaysDifference(DateTime date)
        {
            return (DateTime.Now - date).TotalDays;
        }

        public string GetUtc()
        {
            return DateTime.UtcNow.ToString();
        }

        public string GetDayOfWeek()
        {
            return DateTime.Now.DayOfWeek.ToString();
        }
    }
}
