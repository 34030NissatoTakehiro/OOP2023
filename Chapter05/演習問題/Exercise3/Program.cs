﻿using System;
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
            var count = text.Count(s => s ==' ');
            Console.WriteLine(count);
        }

        private static void Exercise3_2(string text) {
     
        }

        private static void Exercise3_3(string text) {
        
        }

        private static void Exercise3_4(string text) {
         
        }

        private static void Exercise3_5(string text) {
         
        }
    }
}
