using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyLibrary.Models
{
    public class Book
    {
        public int BookID { get; set; }

        [Required]
        public string Title { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public int Pages { get; set; }

        public double Price { get; set; }

        [DisplayName("Publication Date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy}", ApplyFormatInEditMode = true)]
        public DateTime PublicationDate { get; set; }

        public virtual Author Author { get; set; }

        public virtual Category Category { get; set; }
    }
}