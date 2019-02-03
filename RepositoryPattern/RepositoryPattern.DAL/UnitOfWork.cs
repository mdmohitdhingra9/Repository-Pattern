using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryPattern.DAL.Database;
using RepositoryPattern.DAL.Repositories;
using RepositoryPattern.DAL.Repositories.Interface;
using RepositoryPattern.Interface.Core;

namespace RepositoryPattern.DAL
{
    public class UnitOfWork : IUnitOfWork, IUnitOfWorkForRepository
    {
        private BooksContext booksContext;

        public IBookRepository bookRepository { get { return bookRepo; } }

        public IAuthorRepository authorRepository { get { return authorRepo; } }

        private IBookRepository bookRepo;
        private IAuthorRepository authorRepo;

        public UnitOfWork(BooksContext booksContext)
        {
            this.booksContext = booksContext;

            bookRepo = new BookRepository(booksContext);
            authorRepo = new AuthorRepository(booksContext);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (booksContext != null)
                {
                    booksContext.Dispose();
                    booksContext = null;
                }
            }
        }
        public int Save()
        {
            return this.booksContext.SaveChanges();
        }
    }
}
