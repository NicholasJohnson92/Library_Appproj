using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Library_App.Models
{
    public class Author
    {
        [Key]
        public int AuthorID { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public double Rating { get; set; }
       

    }
}
