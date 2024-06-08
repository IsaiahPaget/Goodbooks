using GoodBooks.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodBooks.Services
{
    public interface IBookService
    {
        public List<Book> GetAllBooks();
        public Book GetBook(int id);
        public void DeleteBook(int id);
        public void SaveBook(Book book);
        public void UpdateBook(Book book);
    }
}
