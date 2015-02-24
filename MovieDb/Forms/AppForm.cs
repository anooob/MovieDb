using MovieDb.Extenstions;
using MovieDb.Forms;
using MovieDb.Forms.BookForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EntryType = MovieDb.Constants.EntryType;

namespace MovieDb
{
    public partial class AppForm : Form
    {
        #region Fields

        private MovieDbContext m_context;
        private List<EntryListViewItem> m_listItems = new List<EntryListViewItem>();
        private StringBuilder m_searchString = new StringBuilder();
        private StringBuilder m_minYear = new StringBuilder();
        private StringBuilder m_maxYear = new StringBuilder();
        private List<EntryType> m_selectedCategories = new List<EntryType>();

        #endregion

        #region Construction and Initialization

        public AppForm(MovieDbContext context)
        {
            InitializeComponent();
            m_context = context;
            RefreshListItems();
            InitControls();
            CenterToScreen();
        }

        private void InitControls()
        {
            yearMaxTextbox.MaxLength = 4;
            yearMinTextbox.MaxLength = 4;

            moviesCheckBox.Checked = true;
            booksCheckBox.Checked = true;
        }

        #endregion

        #region Search Conditions

        private bool CheckSearchCondition(string text, EntryListViewItem item)
        {
            if (text != "")
            {
                string[] tmpSearch = text.Split(' ');
                string tmpName = item.Text.ToLower();
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

        private bool CheckYearCondition(EntryListViewItem item)
        {
            int year;
            var s1 = int.TryParse(item.Entry.PublicationYear, out year);
            
            int minYear;
            var s2 = int.TryParse(m_minYear.ToString(), out minYear);
            
            int maxYear;
            var s3 = int.TryParse(m_maxYear.ToString(), out maxYear);

            bool ret = true;
            if (s1)
            {
                if (s2)
                    ret = ret && year >= minYear;
                if (s3)
                    ret = ret && year <= maxYear;
                return ret;
            }
            else
            {
                if (s2 || s3)
                    return false;
                else 
                    return true;
            }
        }

        private bool CheckCategoryCondition(EntryListViewItem item)
        {
            foreach (var selectedCategory in m_selectedCategories)
            {
                if (item.Entry.Type == selectedCategory)
                    return true;
            }
            return false;
        }

        #endregion

        public void RefreshListbox()
        {
            entryList.MultiSelect = false;
            entryList.Items.Clear();

            foreach (var item in m_listItems)
            {
                if (CheckSearchCondition(m_searchString.ToString(), item) && CheckYearCondition(item) && CheckCategoryCondition(item))
                    entryList.Items.Add(item);
            }
        }

        public void RefreshListItems()
        {
            if (m_context == null)
                return;

            m_listItems.Clear();
            
            foreach (var entry in m_context.Entries)
            {
                var item = new EntryListViewItem(entry);
                m_listItems.Add(item);
            }
            RefreshListbox();
        }

        private void SelectCategory(EntryType type)
        {
            if (m_selectedCategories.Contains(type))
            {
                m_selectedCategories.Remove(type);
            }
            else
            {
                m_selectedCategories.Add(type);
            }
        }

        #region Event handling

        private void removeButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to remove this item?", "Remove", MessageBoxButtons.YesNo);
            if (result != System.Windows.Forms.DialogResult.Yes)
                return;

            if (entryList.SelectedItems.Count > 0)
            { 
                foreach(var item in entryList.SelectedItems)
                { 
                    if((item as EntryListViewItem) != null)
                    {
                        int id = (item as EntryListViewItem).Entry.EntryId;
                        m_context.RemoveEntry(id);
                    }
                }
                RefreshListItems();
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var form = new AddMovieForm(m_context);
            form.Location = Location;
            form.StartPosition = FormStartPosition.Manual;
            form.Show();
            AddFormManager.AddForm(form,
                delegate
                {
                    RefreshListItems();
                    Show();
                }
            );
            Hide();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (entryList.SelectedItems.Count == 0)
                return;

            var entity = (entryList.SelectedItems[0] as EntryListViewItem).Entry;
            if (entity != null)
            {
                Form form = null;
                if(entity.Type == EntryType.Movie)
                {
                    form = new EditMovieForm(m_context, entity);
                }
                else if (entity.Type == EntryType.Book)
                {
                    form = new EditBookForm(m_context, entity);
                }
                if (form != null)
                {
                    form.Location = Location;
                    form.StartPosition = FormStartPosition.Manual;
                    form.Show();
                    AddFormManager.AddForm(form,
                        delegate
                        {
                            RefreshListItems();
                            Show();
                        }
                    );
                    Hide();
                }
            }
        }

        private void yearMinTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var box = sender as TextBox;
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void yearMaxTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var box = sender as TextBox;
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            var box = sender as TextBox;
            if (box == null)
                return;
            m_searchString.Clear();
            m_searchString.Append(box.Text);
            RefreshListbox();
        }

        private void yearMinTextbox_TextChanged(object sender, EventArgs e)
        {
            var box = sender as TextBox;
            if (box == null)
                return;
            m_minYear.Clear();
            m_minYear.Append(box.Text);
            RefreshListbox();
        }

        private void yearMaxTextbox_TextChanged(object sender, EventArgs e)
        {
            var box = sender as TextBox;
            if (box == null)
                return;
            m_maxYear.Clear();
            m_maxYear.Append(box.Text);
            RefreshListbox();
        }

        private void moviesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SelectCategory(EntryType.Movie);
            RefreshListbox();
        }

        private void booksCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SelectCategory(EntryType.Book);
            RefreshListbox();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit", "Exit", MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }

        #endregion
    }
}
