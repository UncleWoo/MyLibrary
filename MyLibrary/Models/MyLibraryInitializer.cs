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
                    Title = "Czysty kod. Podręcznik dobrego programisty",
                    Description = "Poznaj najlepsze metody tworzenia doskonałego kodu",
                    Pages = 424,
                    Price = 69.00,
                },

                new Book
                {
                    Title = "Algorytmy. Ilustrowany przewodnik",
                    Description = "Poznaj algorytmy i przekonaj się, jak bardzo są przydatne!",
                    Pages = 256,
                    Price = 54.90
                }
            };

            books.ForEach(s => context.Books.Add(s));
            context.SaveChanges();

            var authors = new List<Author>
            {
                new Author
                {
                    FirstName = "Robert",
                    LastName = "C.Martin"
                },

                new Author
                {
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
                    CategoryName = "Techniki programowania"
                },

                new Category
                {
                    CategoryName = "Algorytmy"
                }
            };

            categories.ForEach(s => context.Categories.Add(s));
            context.SaveChanges();
        }
    }
}