using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercis01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            Exercise1_1(numbers);
            Console.WriteLine("-----");

            Exercise1_2(numbers);
            Console.WriteLine("-----");

            Exercise1_3(numbers);
            Console.WriteLine("-----");

            Exercise1_4(numbers);
            Console.WriteLine("-----");

            Exercise1_5(numbers);
        }

        private static void Exercise1_1(int[] numbers) {
            var MaxNum = numbers.Max();
            Console.WriteLine("最大値：" + MaxNum);

        }

        private static void Exercise1_2(int[] numbers) {
            var El = numbers.Skip(numbers.Length - 2);
            foreach (var item in El) {
                Console.WriteLine("最後から二番目の要素：" + item);
            }

        }

        private static void Exercise1_3(int[] numbers) {




        }

        private static void Exercise1_4(int[] numbers) {

        }

        private static void Exercise1_5(int[] numbers) {

        }
    }
}
