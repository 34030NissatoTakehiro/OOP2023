using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var sales = new SalesCounter(@"data\sales.csv");
            Console.WriteLine("1.店舗別売上");
            Console.WriteLine("２.商品カテゴリー別売上");
            Console.Write(">");
            int select = int.Parse(Console.ReadLine());
            Console.WriteLine("*****売上集計結果*****");
            if (select == 1) {
                var amountPerStore = sales.GetPerStoreSales();
                foreach (var obj in amountPerStore) {
                    Console.WriteLine("{0}{1:C}", obj.Key, obj.Value);
                }
            } else if (select == 2) {
                var categoryPerCategory = sales.GetPerProductCategory();
                foreach (var obj in categoryPerCategory) {
                    Console.WriteLine("{0}{1:C}", obj.Key, obj.Value);
                }
            }




        }
    }
}
