﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section04 {
    class Program {
        static void Main(string[] args) {
            var names = new List<string> {
               "Tokyo", "New Delhi", "Bangkok", "London",
                "Paris", "Berlin", "Canberra", "Hong Kong",
            };

            //IEnumerable<string> query = names.Where(s => s.Length <= 5)
            // .Select(S => S.ToLower());

            var query = names.Where(s => s.Length <= 5).ToList();


            foreach (var item in query) {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------");

            names[0] = "osak";

            foreach (var item in query) {
                Console.WriteLine(item);
            }
        }
    }
}
