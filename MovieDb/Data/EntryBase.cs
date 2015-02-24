using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using EntryType = MovieDb.Constants.EntryType;

namespace MovieDb.Data
{
    [Table("Entries")]
    public class EntryBase
    {
        [Key]
        public int EntryId { get; set; }
        [Required]
        public string Name { get; set; }
        public string PublicationYear { get; set; }
        [Required]
        public EntryType Type { get; set; }
    }
}
