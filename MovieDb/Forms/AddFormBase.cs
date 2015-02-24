using MovieDb.Data;
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
using AuthorItem = MovieDb.Forms.AddAuthorForm.AuthorItem;

namespace MovieDb.Forms
{
    /// <summary>
    /// Base Form for adding and editing forms
    /// </summary>
    public partial class AddFormBase : DetailFormBase
    {
        protected MovieDbContext m_context;
        protected EventHandler m_typeComboSelectedChangedHandler;

        public AddFormBase()
        {
            InitializeComponent();
            InitControls();
        }

        private void InitControls()
        {
            m_typeComboSelectedChangedHandler = new EventHandler(this.typeCombo_SelectedIndexChanged);
            var dict = new Dictionary<int, string>();
            typeCombo.SelectedIndexChanged -= m_typeComboSelectedChangedHandler;
            foreach (EntryType e in Enum.GetValues(typeof(EntryType)))
            {
                dict.Add((int)e, Constants.GetEntryTypeString(e));
            }
            typeCombo.DataSource = new BindingSource(dict, null);
            typeCombo.DisplayMember = "Value";
            typeCombo.ValueMember = "Key";
            typeCombo.SelectedIndexChanged += m_typeComboSelectedChangedHandler;

            yearTextbox.MaxLength = 4;
        }

        protected override void OnCancel()
        {
            AddFormManager.CloseForm();
        }

        protected void OnAddAuthor(Action<Author> callback)
        {
            var form = new AddAuthorForm(m_context, callback);
            form.Location = Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate
            {
                Show();
            };
            form.Show();
            Hide();
        }

        protected void InitAuthorList(List<Author> list, ICollection<Author> source)
        {
            list.Clear();
            foreach (var item in source)
            {
                list.Add(item);
            }
        }

        protected void SaveAuthorEntry(ICollection<Author> dest, List<Author> src)
        {
            dest.Clear();
            foreach (var item in src)
            {
                dest.Add(item);
            }
        }

        protected void RefreshAuthorList(ListBox box, List<Author> source)
        {
            box.Items.Clear();
            foreach (var item in source)
            {
                box.Items.Add(new AuthorItem(item));
            }
        }

        protected void yearTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var box = sender as TextBox;
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void typeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combo = sender as ComboBox;
            if (combo == null)
                return;

            if (combo.SelectedIndex == (int)EntryType.Movie && (this as AddMovieForm) == null)
            {
                var form = new AddMovieForm(m_context);
                form.Location = Location;
                form.StartPosition = FormStartPosition.Manual;
                form.Show();
                AddFormManager.SwitchForm(form);

            }

            if (combo.SelectedIndex == (int)EntryType.Book && (this as AddBookForm) == null)
            {
                var form = new AddBookForm(m_context);
                form.Location = Location;
                form.StartPosition = FormStartPosition.Manual;
                form.Show();
                AddFormManager.SwitchForm(form);
            }
        }
    }
}
