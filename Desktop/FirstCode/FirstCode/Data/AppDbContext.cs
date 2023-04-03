using System;
using System.Collections.Generic;
using DataBaseFirst.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataBaseFirst.Data
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }
        #region Tables
        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book_Author> Books_Authors { get; set; }
        #endregion


        //internal way 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=127.0.0.1;Database=BooksDb;User ID=SA;Password=MyPass@word;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region composite key for table PhoneNumber
            modelBuilder.Entity<PhoneNumber>().HasKey(x => new { x.AuthorId, x.MobileNumber });
            #endregion
            modelBuilder.Entity<Book_Author>().HasKey(x => new { x.BookId, x.AuthorId });
        }


    }
}
