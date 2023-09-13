﻿using SampleEntityFrameWork.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFrameWork {
    class Program {
        static void Main(string[] args) {
            //InsertBooks();
            Console.WriteLine("データ挿入しますた。続けるにはEnter!!!!!!!!!");
            // DisplayAllBooks();
            //AddAuthors();
            //Addbooks();
            foreach (var book in GetBooks()) {
                Console.WriteLine($"{ book.Title}{ book.Author.Name}");
            }

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
                db.SaveChanges();//DB更新

                Console.WriteLine($"{ book1.Id}{ book2.Id}");
            }
        }
        //List 13-7
        static IEnumerable<Book> GetBooks() {
            using (var db = new BooksDbContext()) {
                return db.books.Where(book => book.PublishedYear > 1900).Include(nameof(Auther)).ToList();
            }
        }
        //List 13-8
        static void DisplayAllBooks() {
            var books = GetBooks();
            foreach (var book in books) {
                Console.WriteLine($"{ book.Title}{ book.PublishedYear}");
            }
            Console.ReadLine();
        }
        //List 13-9
        private static void AddAuthors() {
            using (var db = new BooksDbContext()) {
                var autors1 = new Auther {
                    birthday = new DateTime(1986, 12, 7),
                    Gender = "F",
                    Name = "与謝野晶子",
                };
                var autors2 = new Auther {
                    birthday = new DateTime(1986, 8, 27),
                    Gender = "M",
                    Name = "宮沢賢治"

                };
                db.Authers.Add(autors1);
                db.Authers.Add(autors2);
                db.SaveChanges();

            }
            
        }
        //List 13-10
        private static void Addbooks() {
            using (var db = new BooksDbContext()) {
                var auther1 = db.Authers.Single(a => a.Name == "与謝野晶子");

                var book1   = new Book {
                    Title = "みだれ髪",
                    PublishedYear = 2000,
                    Author = auther1,
                };
                var auther2 = db.Authers.Single(a => a.Name == "宮沢賢治");
                var book2 = new Book {
                    Title = "銀河鉄道の夜",
                    PublishedYear = 1989,
                    Author = auther2,

                };
                db.books.Add(book1);
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