using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var greeeings = new List<IGreeting>() {
                 new GreetingMorning(),
                 new GreetingAfternoon(),
                 new GreetingEvening(),
            };
            foreach (var obj in greeeings) {
                string msg = obj.GetMessage();
                Console.WriteLine(msg);
            }
        }
    }
}
