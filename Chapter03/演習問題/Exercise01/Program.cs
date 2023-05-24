using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            // 3.1.1
            Exercise1_1(numbers);
           

            // 3.1.2
            Exercise1_2(numbers);
         
            // 3.1.3
            Exercise1_3(numbers);
          
            // 3.1.4
            Exercise1_4(numbers);
        }

        private static void Exercise1_1(List<int> numbers) {
            var extists = numbers.Exists(n => n % 8 == 0 || n % 9 == 0);
            if (extists == true) {
                Console.WriteLine("存在します");
            }else if(extists == false) {
                Console.WriteLine("存在しません");
            }
            Console.WriteLine("-------");

        }

        private static void Exercise1_2(List<int> numbers) {


            var num = numbers.ConvertAll(s => s / 2.0);
            num.ForEach(s => Console.WriteLine(s));
            Console.WriteLine("-------");


        }

        private static void Exercise1_3(List<int> numbers) {

           var query = numbers.Where(s => s >= 50);
            foreach (var num in query) {
                Console.WriteLine(num);
            }

            Console.WriteLine("-------");

        }

        private static void Exercise1_4(List<int> numbers) {

           var multiple =numbers.Select(n => n * 2).ToList();

           

            foreach (var n in multiple) {
              
                Console.WriteLine(n);
            }
        }
    }
}
