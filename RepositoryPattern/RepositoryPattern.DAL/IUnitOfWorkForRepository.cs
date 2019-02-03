using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryPattern.DAL.Repositories.Interface;

namespace RepositoryPattern.DAL
{
    public interface IUnitOfWorkForRepository
    {
        IBookRepository bookRepository { get; }

        IAuthorRepository authorRepository { get; }
    }
}
