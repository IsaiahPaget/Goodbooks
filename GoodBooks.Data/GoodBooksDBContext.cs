using GoodBooks.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodBooks.Data
{
    // think about this class like the C# DB
    public class GoodBooksDBContext : DbContext
    {
        // call the constructor with no params
        public GoodBooksDBContext() { }

        // call the constructor and pass options into the base class
        public GoodBooksDBContext(DbContextOptions options) : base(options) { }

        // and think of these attributes as the tables in the DB
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookReview> BookReviews { get; set; }
    }
}
