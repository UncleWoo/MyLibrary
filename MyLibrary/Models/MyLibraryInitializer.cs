using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.IO;

namespace MyLibrary.Models
{
    public class MyLibraryInitializer : DropCreateDatabaseAlways<MyLibraryContext>
    {
        protected override void Seed(MyLibraryContext context)
        {
            base.Seed(context);

            var books = new List<Book>
            {
                new Book
                {
                    BookID = 1,
                    Title = "Czysty kod. Podręcznik dobrego programisty",
                    Description = "Poznaj najlepsze metody tworzenia doskonałego kodu",
                    Pages = 424,
                    Price = 69.00,
                },

                new Book
                {
                    BookID = 2,
                    Title = "Algorytmy. Ilustrowany przewodnik",
                    Description = "Poznaj algorytmy i przekonaj się, jak bardzo są przydatne!",
                    Pages = 256,
                    Price = 54.90,
                }
            };

            books.ForEach(s => context.Books.Add(s));
            context.SaveChanges();

            var authors = new List<Author>
            {
                new Author
                {
                    AuthorID = 1,
                    FirstName = "Robert",
                    LastName = "C.Martin"
                },

                new Author
                {
                    AuthorID = 2,
                    FirstName = "Aditya",
                    LastName = "Bhargava"
                }
            };

            authors.ForEach(s => context.Authors.Add(s));
            context.SaveChanges();

            var categories = new List<Category>
            {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Techniki programowania"
                },

                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Algorytmy"
                }
            };

            categories.ForEach(s => context.Categories.Add(s));
            context.SaveChanges();
        }
    }
}