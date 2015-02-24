using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace MovieDb.Data
{
    public class Author
    {
        public Author()
        {
            Directed = new List<MovieEntry>();
        }

        [Key]
        public int AuthorId{ get; set; }
        [Required]
        public string Name { get; set; }
        public string YearOfBirth { get; set; }
        public ICollection<MovieEntry> ActedIn { get; set; }
        public ICollection<MovieEntry> Directed { get; set; }
        public ICollection<BookEntry> Writen { get; set; }

    }
}
