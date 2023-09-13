using SampleEntityFrameWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFrameWork {
    class Program {
        static void Main(string[] args) {
            InsertBooks();
            Console.WriteLine("データ挿入しますた。続けるにはエンターーーーーーー");
            Console.ReadLine();
            Console.WriteLine();
        }
        // List 13-5
        static void InsertBooks() {
            using (var db = new BooksDbContext()) {
                var book1 = new Book {
                    Title = "坊ちゃん",
                    PublishedYear = 2003,
                    Author = new Auther {
                        birthday = new DateTime(1867, 2, 9),
                        Gender = "M",
                        Name = "夏目漱石",
                    }
                };
                db.books.Add(book1);
                var book2 = new Book {
                    Title = "人間失格",
                    PublishedYear = 1990,
                    Author = new Auther {
                        birthday = new DateTime(1909, 6, 19),
                        Gender = "M",
                        Name = "太宰治",
                    }
                };
                db.books.Add(book2);
                db.SaveChanges();
            }
        }
    }
}
