using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyLibrary.Models
{
    public class MyLibraryContext : DbContext
    {
        public MyLibraryContext() : base()
        {
            this.Database.CommandTimeout = 180;
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}