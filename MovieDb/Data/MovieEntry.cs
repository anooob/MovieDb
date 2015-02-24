using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntryType = MovieDb.Constants.EntryType;

namespace MovieDb.Data
{
    public class MovieEntry : EntryBase
    {
        public MovieEntry()
            : base()
        {
            Type = EntryType.Movie;
            Actors = new List<Author>();
            Directors = new List<Author>();
        }
        public ICollection<Author> Directors { get; set; }
        public ICollection<Author> Actors { get; set; }
    }
}
