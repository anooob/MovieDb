using MovieDb.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MovieDb.Forms.BookForms
{
    /// <summary>
    /// Form for editing book entries of the database
    /// </summary>
    public partial class EditBookForm : AddBookForm
    {
        #region Construction and Initialization

        public EditBookForm(MovieDbContext context, EntryBase entry)
            :base(context)
        {
            InitializeComponent();
            m_entry = entry as BookEntry;
            InitControls();
            m_context.Entry(m_entry).Collection(e => e.Authors).Load();
            InitAuthorList(m_selectedAuthors, m_entry.Authors);
            RefreshAuthorList(authorsListbox, m_selectedAuthors);
        }

        [Obsolete("This exists only for designer purposes")]
        public EditBookForm() : this(null, null)
        {
            InitializeComponent();
        }

        private void InitControls()
        {
            Debug.Assert(m_entry != null);
            nameTextbox.Text = m_entry.Name;
            yearTextbox.Text = m_entry.PublicationYear;
            typeCombo.SelectedIndexChanged -= m_typeComboSelectedChangedHandler;
            typeCombo.SelectedIndex = (int)m_entry.Type;
            typeCombo.Enabled = false;
        }

        #endregion

        protected override void OnOk()
        {
            m_entry.Name = nameTextbox.Text;
            m_entry.PublicationYear = yearTextbox.Text;
            SaveAuthorEntry(m_entry.Authors, m_selectedAuthors);
            m_context.SaveChanges();
            AddFormManager.CloseForm();
        }
    }
}
