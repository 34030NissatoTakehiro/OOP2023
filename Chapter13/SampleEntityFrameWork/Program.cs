﻿
using SampleEntityFrameWork.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("# 1.1");
            //Exercise1_1();

            Console.WriteLine();
            Console.WriteLine("# 1.2");
            Exercise1_2();

            Console.WriteLine();
            Console.WriteLine("# 1.3");
            Exercise1_3();

            Console.WriteLine();
            Console.WriteLine("# 1.4");
            Exercise1_4();

            Console.WriteLine();
            Console.WriteLine("# 1.5");
            Exercise1_5();

            Console.ReadLine();

            using (var db = new BooksDbContext()) {

                db.Database.Log = sql => { Debug.Write(sql); };

                var count = db.books.Count();
                Console.WriteLine(count);
            }

            Console.ReadLine();
            Console.WriteLine();

        }

        private static void Exercise1_1() {
            using (var db = new BooksDbContext()) {
                var author1 = new Author {
                    birthday = new DateTime(1888, 12, 26),
                    Gender = "M",
                    Name = "菊池寛",
                };
                db.Authers.Add(author1);
                var author2 = new Author {
                    birthday = new DateTime(1899, 6, 14),
                    Gender = "M",
                    Name = "川端康成",
                };
                db.Authers.Add(author2);
                db.SaveChanges();
            }

            using (var db = new BooksDbContext()) {
                var book1 = new Book {
                    Title = "こころ",
                    PublishedYear = 1991,
                    Author = new Author {
                        birthday = new DateTime(1867, 2, 9),
                        Gender = "M",
                        Name = "夏目漱石",
                    }
                };
                db.books.Add(book1);

                var book2 = new Book {
                    Title = "伊豆の踊子",
                    PublishedYear = 2003,
                    Author = new Author {
                        birthday = new DateTime(1899, 6, 14),
                        Gender = "M",
                        Name = "川端康成",
                    }
                };
                db.books.Add(book2);

                var book3 = new Book {
                    Title = "真珠夫人",
                    PublishedYear = 2002,
                    Author = new Author {
                        birthday = new DateTime(1888, 12, 26),
                        Gender = "M",
                        Name = "菊池寛",
                    }
                };
                db.books.Add(book3);

                var book4 = new Book {
                    Title = "注文の多い料理店",
                    PublishedYear = 2000,
                    Author = new Author {
                        birthday = new DateTime(1896, 8, 27),
                        Gender = "M",
                        Name = "宮沢賢治",
                    }
                };
                db.books.Add(book4);

                db.SaveChanges();   //データベースを更新
            }
        }


        private static void Exercise1_2() {
            var books = GetBooks();

            foreach (var book in books) {
                Console.WriteLine($"{book.Title}{book.Author.Name} {book.PublishedYear} " + $"");
            }

        }

        private static void Exercise1_3() {
            using (var db = new BooksDbContext()) {
                var books = db.books.Max(s => s.Title.Length);
                var bookone = db.books.Where(x => x.Title.Length == books);
                foreach (var book in bookone) {
                    Console.WriteLine(book.Title);
                }
            }

        }

        private static void Exercise1_4() {
            using (var db = new BooksDbContext()) {
                var books = db.books.OrderBy(s => s.PublishedYear);
                var bookone = books.Take(3).ToList();
                foreach (var book in bookone) {
                    Console.WriteLine($"{book.Title}{book.Author.Name}  " + $"");

                }
            }
        }
    

        private static void Exercise1_5() {
            using (var db = new BooksDbContext()) {
                var authors = db.Authers.OrderByDescending(s => s.birthday);
               
                foreach (var autor in authors.ToArray()) {
                    Console.WriteLine("{0} {1:yyyy/MMM}",autor.Name,autor.birthday);
                    foreach (var book in autor.Books) {
                        Console.WriteLine("{0} {1}", book.Title, book.PublishedYear, book.Author.birthday, book.Author);
                    }
                }
                }
            }

        // List 13-5
        static void InsertBooks() {
            using (var db = new BooksDbContext()) {
                var book1 = new Book {
                    Title = "坊ちゃん",
                    PublishedYear = 2003,
                    Author = new Author {
                        birthday = new DateTime(1867, 2, 9),
                        Gender = "M",
                        Name = "夏目漱石",
                    }
                };
                db.books.Add(book1);
                var book2 = new Book {
                    Title = "人間失格",
                    PublishedYear = 1990,
                    Author = new Author {
                        birthday = new DateTime(1909, 6, 19),
                        Gender = "M",
                        Name = "太宰治",
                    }
                };
                db.books.Add(book2);
                db.SaveChanges();   //データベースを更新
                Console.WriteLine($"{book1.Id}{book2.Id}");

            }
        }

        //List 13-7
        static IEnumerable<Book> GetBooks() {
            using (var db = new BooksDbContext()) {
                return db.books.Where(book => book.PublishedYear > 1900).Include(nameof(Author)).ToList();
            }
        }

        //List 13-8
        static void DisplayAllBooks() {
            var books = GetBooks();
            foreach (var book in books) {
                Console.WriteLine($"{book.Title}{book.PublishedYear}");
            }
            Console.ReadLine();
        }

        //List 13-9
        private static void AddAuthors() {
            using (var db = new BooksDbContext()) {
                var author1 = new Author {
                    birthday = new DateTime(1878, 12, 9),
                    Gender = "F",
                    Name = "与謝野晶子",
                };
                db.Authers.Add(author1);
                var author2 = new Author {
                    birthday = new DateTime(1896, 8, 27),
                    Gender = "M",
                    Name = "宮沢賢治",
                };
                db.Authers.Add(author2);
                db.SaveChanges();
            }
        }

        //List 13-10
        private static void AddBooks() {
            using (var db = new BooksDbContext()) {
                var author1 = db.Authers.Single(a => a.Name == "与謝野晶子");
                var book1 = new Book {
                    Title = "みだれ髪",
                    PublishedYear = 2000,
                    Author = author1,
                };
                db.books.Add(book1);
                var author2 = db.Authers.Single(a => a.Name == "宮沢賢治");
                var book2 = new Book {
                    Title = "銀河鉄道の夜",
                    PublishedYear = 1989,
                    Author = author2,
                };
                db.books.Add(book2);
                db.SaveChanges();
            }
        }

        // List 13-11
        private static void UpdateBook() {
            using (var db = new BooksDbContext()) {
                var book = db.books.Single(x => x.Title == "銀河鉄道の夜");
                book.PublishedYear = 2016;
                db.SaveChanges();
            }
        }

        // List 13-12
        private static void DeleteBook() {
            using (var db = new BooksDbContext()) {
                var book = db.books.SingleOrDefault(x => x.Id == 10);
                if (book != null) {
                    db.books.Remove(book);
                    db.SaveChanges();
                }
            }
        }
    }
}