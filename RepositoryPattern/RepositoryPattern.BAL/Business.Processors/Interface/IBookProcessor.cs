using RepositoryPattern.Interface.Business;
using RepositoryPattern.Models.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.BAL.Business.Processors.Interface
{
    public interface IBookProcessor : IProcessor<Book>
    {
    }
}
