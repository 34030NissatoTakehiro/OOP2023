﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var names = new List<string> {
                 "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };
            Exercise2_1(names);
           

            Exercise2_2(names);
            Console.WriteLine();

            Exercise2_3(names);
            Console.WriteLine(); 

            Console.WriteLine();
            Exercise2_4(names);
        }

        private static void Exercise2_1(List<string> names) {


            do {
                Console.WriteLine("都市名を入力");
                string city = Console.ReadLine();
                if (string.IsNullOrEmpty(city)) {
                    break;
                }
                var cities = names.FindIndex(n => n == city);
                Console.WriteLine(cities);
                
            } while (true);

          



        }

        private static void Exercise2_2(List<string> names) {
            var conut = names.Count(s => s.Contains('o'));
            Console.WriteLine(conut);
        }

        private static void Exercise2_3(List<string> names) {
            var counts = names.Where(s => s.Contains('o')).ToArray();
            foreach (var item in counts) {
                Console.WriteLine(item);
            }

        }

        private static void Exercise2_4(List<string> names) {
            var counts = names.Where(s => s[0] == 'B').Select(s =>s.Length);
             foreach (var item in counts) {
                Console.WriteLine(item);
            }
        }
    }
}
