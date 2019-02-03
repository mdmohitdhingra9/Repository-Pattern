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
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(BooksContext context) : base(context)
        {
        }
    }
}
