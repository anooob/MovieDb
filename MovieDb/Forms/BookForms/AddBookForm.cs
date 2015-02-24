using MovieDb.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EntryType = MovieDb.Constants.EntryType;
using AuthorItem = MovieDb.Forms.AddAuthorForm.AuthorItem;

namespace MovieDb.Forms.BookForms
{
    /// <summary>
    /// Form for adding book entries into the database
    /// </summary>
    public partial class AddBookForm : AddFormBase
    {
        #region Fields

        protected BookEntry m_entry = new BookEntry();
        protected List<Author> m_selectedAuthors = new List<Author>();

        #endregion

        #region Construction

        public AddBookForm(MovieDbContext context)
        {
            InitializeComponent();
            m_context = context;
            typeCombo.SelectedIndexChanged -= m_typeComboSelectedChangedHandler;
            typeCombo.SelectedIndex = (int)EntryType.Book;
            typeCombo.SelectedIndexChanged += m_typeComboSelectedChangedHandler;
        }

        [Obsolete("This exists only for designer purposes")]
        public AddBookForm() : this(null)
        {
            InitializeComponent();
        }

        #endregion

        protected override void OnOk()
        {
            var text = nameTextbox.Text;
            if (text.Length == 0)
            {
                MessageBox.Show("Please enter a name.");
                return;
            }

            if ((int)typeCombo.SelectedValue == (int)EntryType.Book)
            {
                m_entry.Name = text;
                m_entry.PublicationYear = yearTextbox.Text;
                SaveAuthorEntry(m_entry.Authors, m_selectedAuthors);
                m_context.Entries.Add(m_entry);
                m_context.SaveChanges();
            }
            AddFormManager.CloseForm();
        }

        #region Event Handling

        private void addAuthorButton_Click(object sender, EventArgs e)
        {
            OnAddAuthor(AuthorAddedCallback);
        }

        private void removeAuthorButton_Click(object sender, EventArgs e)
        {
            OnRemoveAuthor();
        }

        private void AuthorAddedCallback(Author newAuthor)
        {
            if (newAuthor == null)
                return;
            if (!m_selectedAuthors.Contains(newAuthor))
                m_selectedAuthors.Add(newAuthor);
            RefreshAuthorList(authorsListbox, m_selectedAuthors);
        }

        protected void OnRemoveAuthor()
        {
            if (authorsListbox.SelectedItem == null)
                return;
            var item = authorsListbox.SelectedItem as AuthorItem;
            if (item != null)
            {
                var actor = m_context.GetAuthor(item.Id);
                if (actor != null)
                {
                    m_selectedAuthors.Remove(actor);
                    RefreshAuthorList(authorsListbox, m_selectedAuthors);
                }
            }
        }

        #endregion
    }
}
