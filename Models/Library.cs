using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Library_App.Models
{
    public class Library
    {[Key]
        public int LibraryId { get; set; }
      [ForeignKey("Reader")]
        public int ReaderId { get; set; }
        public Reader Reader { get; set; }
    }
}
