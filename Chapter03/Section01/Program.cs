using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {


        static void Main(string[] args) {
            var numbers = new[] { 5, 3, 9, 6,};

            //int count = numbers.Count(n =>n % 2 ==0);

            //合計
            int sum = numbers.Where(n => n % 2 == 0).Sum();
            Console.WriteLine(sum);


        }

      
    }
}
