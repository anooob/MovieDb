using MovieDb.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MovieDb.Forms
{
    /// <summary>
    /// Form for associating authors with database entries
    /// </summary>
    public partial class AddAuthorForm : Form
    {
        #region AuthorItem
        /// <summary>
        /// class used for storing Author data in a listbox
        /// </summary>
        public class AuthorItem
        {
            public string Name;
            public int Id;

            public AuthorItem(Author author)
            {
                Name = author.Name;
                Id = author.AuthorId;
            }

            public override string ToString()
            {
                return Name;
            }
        }

        #endregion

        #region Fields

        private MovieDbContext m_context;
        private List<AuthorItem> m_listItems = new List<AuthorItem>();
        private StringBuilder m_searchString = new StringBuilder();
        private Action<Author> m_callback;

        #endregion

        #region Construction

        public AddAuthorForm(MovieDbContext context, Action<Author> callback)
        {
            m_callback = callback;
            m_context = context;
            InitializeComponent();
            RefreshAuthorList();
        }

        #endregion

        private void RefreshAuthorList()
        {
            if (m_context == null)
                return;
            m_listItems.Clear();
            foreach (var entry in m_context.Authors)
            {
                var item = new AuthorItem(entry);
                m_listItems.Add(item);
            }
            RefreshListBox();
        }

        private void RefreshListBox()
        {
            authorsListbox.Items.Clear();
            foreach (var item in m_listItems)
            {
                if (CheckSearchCondition(m_searchString.ToString(), item))
                    authorsListbox.Items.Add(item);
            }
        }

        #region Search Condition

        private bool CheckSearchCondition(string text, AuthorItem item)
        {
            if (text != "")
            {
                string[] tmpSearch = text.Split(' ');
                string tmpName = item.Name.ToLower();
                bool add = true;
                foreach (var search in tmpSearch)
                    if (!tmpName.Contains(search.ToLower()))
                    {
                        add = false;
                        break;
                    }
                if (add)
                    return true;
                else
                    return false;
            }
            else
            {
                return true;
            }
        }

        #endregion

        #region Event Handling

        private void removeAuthorButton_Click(object sender, EventArgs e)
        {
            AuthorItem selected = (AuthorItem)authorsListbox.SelectedItem;
            if(selected != null)
            {
                m_context.RemoveAuthor(selected.Id);
                RefreshAuthorList();
            }
        }

        private void newAuthorButton_Click(object sender, EventArgs e)
        {
            var form = new NewAuthorForm(m_context);
            form.Location = Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate
            {
                RefreshAuthorList();
            };
            form.Show();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (authorsListbox.SelectedItem != null)
            {
                var item = authorsListbox.SelectedItem as AuthorItem;
                if (item != null)
                {
                    var author = m_context.GetAuthor(item.Id);
                    if (author != null)
                    {
                        CallResultCallback(author);
                    }
                }
            }
            Close();
        }

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            var box = sender as TextBox;
            if (box == null)
                return;
            m_searchString.Clear();
            m_searchString.Append(box.Text);
            RefreshListBox();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CallResultCallback(Author result)
        {
            if (m_callback != null)
            {
                m_callback(result);
            }
        }

        #endregion
    }
}
