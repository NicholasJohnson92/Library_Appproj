using System;
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
        public string Author_Name { get; set; }
        public string IBSN { get; set; }
        public string Genre { get; set; }
        public bool Lendable { get; set; }
        public bool Completed { get; set; }
        [ForeignKey("Library")]
        public int LibraryId { get; set; }
        public Library Library { get; set; }
        [ForeignKey("Author")]
        public int AuthorID { get; set; }
        public Author Author { get; set; }

    }
}
