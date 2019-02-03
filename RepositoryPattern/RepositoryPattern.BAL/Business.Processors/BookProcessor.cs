using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RepositoryPattern.BAL.Business.Processors.Interface;
using RepositoryPattern.DAL;
using RepositoryPattern.DAL.Database;
using RepositoryPattern.Models.Common.Models;

namespace RepositoryPattern.BAL.Business.Processors
{
    public class BookProcessor : IBookProcessor
    {
        private readonly BooksContext booksContext;
        public BookProcessor(BooksContext booksContext)
        {
            this.booksContext = booksContext;
        }

        public void Add(Book entity)
        {
            try
            {
                using (var uow = new UnitOfWork(booksContext))
                {
                    
                }
            }
            catch(Exception ex)
            {

            }
        }

        public void AddRange(IEnumerable<Book> entities)
        {
            throw new NotImplementedException();
        }

        public Book Get(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> Get(Expression<Func<Book, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAll()
        {
            try
            {
                using (var uow = new UnitOfWork(booksContext))
                {
                    return uow.bookRepository.GetAll();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Remove(Book entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(object id)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Book> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(Book entity)
        {
            throw new NotImplementedException();
        }
    }
}
