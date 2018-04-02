using System;
using System.Collections.Generic;

namespace DiasUteis.Tests
{
    public static class DiasUteisTestsInitializer
    {
        public static List<DateTime> Feriados => new List<DateTime> { new DateTime(2018, 01, 01), new DateTime(2018, 04, 21) };
        public static DateTime Tiradentes => new DateTime(2018, 04, 21);
        public static DateTime ConfraternizacaoUniversal => new DateTime(2018, 01, 01);

        public static List<DayOfWeek> DiasDescanso = new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Tuesday };
        public static Dictionary<DayOfWeek, DateTime> DiasParaTestes = new Dictionary<DayOfWeek, DateTime>
        {
            { DayOfWeek.Sunday, new DateTime(2018, 03, 25)},
            { DayOfWeek.Monday, new DateTime(2018, 03, 26)},
            { DayOfWeek.Tuesday,  new DateTime(2018, 03, 27)},
            { DayOfWeek.Wednesday, new DateTime(2018, 03, 28)},
            { DayOfWeek.Thursday,  new DateTime(2018, 03, 29)},
            { DayOfWeek.Friday,  new DateTime(2018, 03, 30)},
            { DayOfWeek.Saturday,  new DateTime(2018, 03, 31)}
        };
    }
}
