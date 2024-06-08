using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodBooks.Data.Models
{
    public class BookReview
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public int Comment { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdateOn { get; set; }

        public virtual Book Book { get; set; }
    }
}
