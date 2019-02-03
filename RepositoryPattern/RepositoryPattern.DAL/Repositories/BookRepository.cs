using RepositoryPattern.DAL.Database;
using RepositoryPattern.DAL.Repositories.Interface;
using RepositoryPattern.Models.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.DAL.Repositories
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(BooksContext context) : base(context)
        {
        }
    }
}
