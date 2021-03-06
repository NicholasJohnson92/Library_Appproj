﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Library_App.Models
{
    public class Books
    {[Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        [Required]
        public long IBSN { get; set; }
        public string Genre { get; set; }
        public bool Lendable { get; set; }
        public bool OnLease{ get; set; }
        public int BorrowerID{ get; set; }
        public bool Completed { get; set; }
        public double Rating { get; set; }
        [ForeignKey("Shelf")]
        public int Shelf_ID { get; set; }
        public Library Library { get; set; }
        [ForeignKey("Author")]
        public int AuthorID { get; set; }
        public Author Author { get; set; }
        [ForeignKey("Reader")]
        public int ReaderId { get; set; }
        public Reader Reader { get; set; }
    }
}
