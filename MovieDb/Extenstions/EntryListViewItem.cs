using MovieDb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EntryType = MovieDb.Constants.EntryType;

namespace MovieDb.Extenstions
{
    /// <summary>
    /// Class used for storing database entries in a listbox
    /// </summary>
    class EntryListViewItem : ListViewItem
    {
        private EntryBase m_entry;
        public EntryBase Entry
        {
            get { return m_entry; }
        }

        public EntryListViewItem()
            : base()
        { }

        public EntryListViewItem(EntryBase entry)
            : base(entry.Name)
        {
            m_entry = entry;
            SubItems.Add(Constants.GetEntryTypeString(entry.Type));
            if (entry.PublicationYear == null)
            {
                SubItems.Add("");
            }
            else
            {
                SubItems.Add(entry.PublicationYear);
            }
        }
    }
}
