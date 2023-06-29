using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var text = "Cozy lummox gives smart squid who asks for job pen";
            Exercise1_1(text);
            Console.WriteLine();
            Exercise1_2(text);
        }

        private static void Exercise1_1(string text) {
            var dict = new Dictionary<Char, int>();
            foreach (var item in text.ToUpper()) {
                if ('A' <= item && item <= 'Z') {
                    if (dict.ContainsKey(item)) {
                        dict[item]++;
                    } else {
                        dict.Add(item, 1);
                    }
                    
                    
                }

            }
            var wow = dict.OrderBy(s => s.Key);
            foreach (var r in wow) {
                Console.WriteLine("{0}:{1}", r.Key, r.Value);

            }


        }

        private static void Exercise1_2(string text) {
            var dict = new SortedDictionary<Char, int>();
            foreach (var item in text.ToUpper()) {
                if ('A' <= item && item <= 'Z') {
                    if (dict.ContainsKey(item)) {
                        dict[item]++;
                    } else {
                        dict.Add(item, 1);
                    }


                }

            }
           
            foreach (var r in dict) {
                Console.WriteLine("{0}:{1}", r.Key, r.Value);

            }

        }
    }
}
