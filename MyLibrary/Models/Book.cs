using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyLibrary.Models
{
    public class Book
    {
        public int BookID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int Pages { get; set; }

        public double Price { get; set; }

        public DateTime PublicationDate { get; set; }

        public virtual Author Author { get; set; }

        public virtual Category Category { get; set; }
    }
}