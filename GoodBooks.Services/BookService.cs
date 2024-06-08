using GoodBooks.Data;
using GoodBooks.Data.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace GoodBooks.Services
{
    public class BookService : IBookService
    {
        private readonly GoodBooksDBContext _db;
        public BookService(GoodBooksDBContext db) 
        {
            _db = db;
        }
        public void DeleteBook(int id)
        {
            var bookToDelete = _db.Books.Find(id); 
            // don't process a delete if no book matches that id
            if (bookToDelete == null)
            {
                throw new InvalidOperationException("Cannot delete book that does not exist");
            }
            _db.Remove(bookToDelete);
        }

        public List<Book> GetAllBooks()
        {
            // remember the Entity Framework Core we installed before well here is the ORM working
            // this is not scalable and in a situation where there are many books you would implement pagination
            // TODO: implement pagination
            return _db.Books.ToList();
        }

        public Book GetBook(int id)
        {
            // again with the ORM this makes it too easy
            Book book = _db.Books.Find(id);

            // check for book not found
            if (book == null) {
                book = new Book();
            }
            return book;
        }

        public void SaveBook(Book book)
        {
            // TODO: return id after creating
            // in this case the ORM is smart enough to know what table to put the book into by its type
            _db.Add(book);
            // you have to save changes because otherwise the transaction will not be run
            _db.SaveChanges();
        }

        public void UpdateBook(Book book)
        {
            // TODO: update a book
            throw new NotImplementedException();
        }
    }
}
