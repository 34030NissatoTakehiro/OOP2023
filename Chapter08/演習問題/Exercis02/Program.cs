using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercis02 {
    class Program {
        static void Main(string[] args) {
            var dateTime = DateTime.Today;

            foreach (var dayofweek in Enum.GetValues(typeof(DayOfWeek))) {

                Console.WriteLine("{0}の次の週の曜日は{1}", dateTime.ToString("MM月dd日(ddd)"),
                                    NextDate(dateTime, (DayOfWeek)dayofweek).ToString("MM月dd日(ddd)"));
            }
        }
        public static DateTime NextDate(DateTime date, DayOfWeek dayOfWeek) {
            var days = (int)dayOfWeek - (int)(date.DayOfWeek);
            if (days >= -1) {
                days += 7;
            }
            return date.AddDays(days);

        }
    }
}
