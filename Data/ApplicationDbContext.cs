using System;
using System.Collections.Generic;
using System.Text;
using Library_App.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Library_App.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder) 
        { base.OnModelCreating(builder);
            builder.Entity<IdentityRole>()
                .HasData(new IdentityRole{ Name = "Reader",NormalizedName = "READER"}); }
        public  DbSet<Reader> Readers { get; set; }
        public DbSet<Shelf> Shelves { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Books> Books { get; set; }
        



    }
}
