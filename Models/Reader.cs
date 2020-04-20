using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Library_App.Models
{
    public class Reader
    {
        [Key]
        public int ReaderId { get; set; }
        public  string First_Name { get; set; }
        public string Last_Name { get; set; }
        public int Zipcode { get; set; }
        [ForeignKey("IdentityUser")] 
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser {
            get; set;
        }
    }
   
            
        
}
