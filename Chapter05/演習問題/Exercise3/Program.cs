using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3 {
    class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(text);
            Console.WriteLine("-----");

            Exercise3_2(text);
            Console.WriteLine("-----");

            Exercise3_3(text);
            Console.WriteLine("-----");

            Exercise3_4(text);
            Console.WriteLine("-----");

            Exercise3_5(text);

        }

        private static void Exercise3_1(string text) {
            var count = text.Count(c => c == ' ');
            Console.WriteLine(count);
        }

        private static void Exercise3_2(string text) {
            var replaced = text.Replace("big", "small");
            Console.WriteLine(replaced);
        }

        private static void Exercise3_3(string text) {
            var count = text.Split().Count();
            Console.WriteLine(count);
        }

        private static void Exercise3_4(string text) {
            var where = text.Split(' ').Where(s => s.Length <= 4);
            foreach (var s in where) {

                Console.WriteLine(s);

            }
        }

        private static void Exercise3_5(string text) {
            var tex = text.Split(' ').ToArray();
            StringBuilder sb = new StringBuilder(tex[0]);
           
            foreach (var s in tex.Skip(1)) {
                sb.Append(s + ' ');

            }
            var word = sb.ToString();
            Console.WriteLine(word);


        }
    }
}
