using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntryType = MovieDb.Constants.EntryType;

namespace MovieDb.Data
{
    public class BookEntry : EntryBase
    {
        public BookEntry()
            : base()
        {
            Type = EntryType.Book;
            Authors = new List<Author>();
        }

        public ICollection<Author> Authors { get; set; }
    }
}
