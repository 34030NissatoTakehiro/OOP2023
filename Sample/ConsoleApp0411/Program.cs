using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0411 {
    class Program {
        static void Main(string[] args) {

            string[] moneyString = { "一万円", "五千", "二千円", "千円", "五百", "百","五十", "十円","五円", "１円" };
            int[] moneyIntenger = { 10000, 5000, 2000, 1000, 500,100, 50, 10,5, 1 };


            Console.Write("金額；");
            int money = int.Parse(Console.ReadLine());

            Console.Write("支払い；");
            int payment = int.Parse(Console.ReadLine());

            int change = payment - money;
            Console.WriteLine("お釣り"+ change );


            for (int i = 0; i < moneyString.Length; i++)
            {
                // Console.WriteLine(moneyString[i] + "{0}枚", change / moneyIntenger[i] );
                Console.WriteLine(moneyString[i] + "{0}枚", change / moneyIntenger[i]);
                int num = change % moneyIntenger[i];
                astOut(change / moneyIntenger[i]);
                change %= moneyIntenger[i];
                
            }
            
            

           

        }
        private static void astOut(int count) {
            for (int i = 0; i < count; i++)
            {
                Console.Write("*");

            }
            Console.WriteLine("");
        }

    }
}
