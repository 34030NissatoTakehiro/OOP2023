using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {

            var numbers = new List<int> { 9,7,5,4,2,5,4,0,4,1,0,4,};
            var books =Books. GetBooks();

            Console.WriteLine(numbers.Average());
            var mmm = books.Where(x => x.Title.Contains("物語")).Average(x => x.Pages);
            var title = books.OrderByDescending(X => X.Title.Length);
            Console.WriteLine("物語が入っている書籍の平均ページ数：" + mmm + "ページ");
            foreach (var item in title) {
                Console.WriteLine(item.Title);
            }
        }


    }
}
