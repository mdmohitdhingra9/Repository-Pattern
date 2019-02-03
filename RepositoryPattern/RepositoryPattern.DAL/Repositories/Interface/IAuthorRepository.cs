using RepositoryPattern.Interface.Core;
using RepositoryPattern.Models.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.DAL.Repositories.Interface
{
    public interface IAuthorRepository : IRepository<Author>
    {
    }
}
