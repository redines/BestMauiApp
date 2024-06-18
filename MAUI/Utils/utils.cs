using System.Globalization;

namespace BestMauiApp.Utils
{
    public static class Utils
    {
        public static string GetCurrentWeek()
        {
            //for now, take the the current executing thread's Culture
            var cultureInfo = Thread.CurrentThread.CurrentCulture;

            var year = DateTime.Now.Year;
            var month = DateTime.Now.Month;
            var day = DateTime.Now.Day;

            DateTime dd = new(year, month, day);

            DayOfWeek firstDay = cultureInfo.DateTimeFormat.FirstDayOfWeek;
            CalendarWeekRule weekRule = cultureInfo.DateTimeFormat.CalendarWeekRule;
            Calendar cal = cultureInfo.Calendar;
            var week = cal.GetWeekOfYear(dd, weekRule, firstDay);

            return week.ToString();
        }
    }
}
