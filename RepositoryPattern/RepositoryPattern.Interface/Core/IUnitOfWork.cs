using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Interface.Core
{
    public interface IUnitOfWork : IDisposable
    {
        int Save();
    }
}
