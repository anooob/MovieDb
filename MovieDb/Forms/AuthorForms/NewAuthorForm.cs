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
    /// Form for adding new authors into the database
    /// </summary>
    public partial class NewAuthorForm : Form
    {
        MovieDbContext m_context;

        public NewAuthorForm(MovieDbContext context)
        {
            m_context = context;
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (nameTextbox.Text.Length == 0)
            {
                MessageBox.Show("Enter a Name");
                return;
            }
            var author = new Author();
            author.Name = nameTextbox.Text;
            author.YearOfBirth = birthTextbox.Text;
            m_context.Authors.Add(author);
            m_context.SaveChanges();
            Close();
        }

        private void birthTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var box = sender as TextBox;
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }
    }
}
