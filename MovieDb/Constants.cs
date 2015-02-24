using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieDb
{
    /// <summary>
    /// Constants used in th application
    /// </summary>
    public static class Constants
    {
        public enum EntryType
        {
            Movie,
            Book,
        }

        public static List<string> Types = new List<string>() { "Movie", "Book" };
        
        public static string GetEntryTypeString(EntryType type)
        {
            return Types[(int)type];
        }
    }
}
