using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var price = Library.Books
                              .Max(b => b.Price)
                              ;
            var book = Library.Books
                            .First(b => b.Price == price);
            Console.WriteLine(book);
        }

        private static void Exercise1_3() {
             var count = Library.Books.OrderBy(b=>b.PublishedYear)
                                      .GroupBy(b => b.PublishedYear);
            foreach (var books in count) {
                Console.WriteLine("{0}年  {1}冊",books.Key,books.Count());
                
            }     
        }

        private static void Exercise1_4() {
            var books = Library.Books
                                    .OrderBy(b => b.CategoryId)
                                    .ThenByDescending(b => b.PublishedYear)
                                    .Join(Library.Categories, book => book.CategoryId,
                                                             category => category.Id,
                                                             (book, category) => new {
                                                                 Title = book.Title,
                                                                 Category = category.Name,
                                                                 Publishedyear = book.PublishedYear
                                                             }
                                                             );
            foreach (var item in books) {
                Console.WriteLine($"{item.Publishedyear}年,{item.Category},{item.Title}");
            }
        }

        private static void Exercise1_5() {
        }

        private static void Exercise1_6() {
        }

        private static void Exercise1_7() {
        }

        private static void Exercise1_8() {
        }
    }
}
