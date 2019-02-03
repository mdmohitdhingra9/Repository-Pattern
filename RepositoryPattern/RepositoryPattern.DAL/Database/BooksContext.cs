using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryPattern.Models.Common.Models;
using System.Data.Entity;

namespace RepositoryPattern.DAL.Database
{
    public class BooksContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        ////public BooksContext(DbContextOptions<BooksContext> options) : base(options)
        ////{
        ////}

        public BooksContext() : base("BooksContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            ////this.AddAuthorandBooksData(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        private void AddAuthorandBooksData(DbModelBuilder modelBuilder)
        {
            var authorId1 = Guid.NewGuid();
            var authorId2 = Guid.NewGuid();
            //// seed the database with dummy data
            ////modelBuilder.Entity<Author>(). HasEntitySetName(
            ////    new Author()
            ////    {
            ////        Id = authorId1,
            ////        FirstName = "Mohit",
            ////        LastName = "Dhingra"
            ////    },
            ////    new Author()
            ////    {
            ////        Id = authorId2,
            ////        FirstName = "Moni",
            ////        LastName = "Kumar"
            ////    }
            ////    );

            ////modelBuilder.Entity<Book>().HasData(
            ////    new Book()
            ////    {
            ////        Id= Guid.NewGuid(),
            ////        Title="Machine Learning",
            ////        Description="ML",
            ////        AuthorId=authorId1
            ////    },
            ////    new Book()
            ////    {
            ////        Id = Guid.NewGuid(),
            ////        Title = ".Net ML",
            ////        Description = "ML.Net",
            ////        AuthorId = authorId2
            ////    }
            ////    );
        }
    }
}
