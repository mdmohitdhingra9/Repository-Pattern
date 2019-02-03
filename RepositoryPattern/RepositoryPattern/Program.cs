using RepositoryPattern.BAL.Business.Processors;
using RepositoryPattern.BAL.Business.Processors.Interface;
using RepositoryPattern.DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.GetBooks();
        }

        private void GetBooks()
        {
            BooksContext booksContext = new BooksContext();
            var processor = new BookProcessor(booksContext);
            var books= processor.GetAll();
        }
    }


}
