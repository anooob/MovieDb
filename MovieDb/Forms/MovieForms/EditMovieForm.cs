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

namespace MovieDb.Forms
{
    /// <summary>
    /// Form for editing movie entries of the database
    /// </summary>
    public partial class EditMovieForm : AddMovieForm
    {
        #region Construction and Initialization

        public EditMovieForm(MovieDbContext context, EntryBase entry)
            : base(context)
        {
            m_entry = entry as MovieEntry;

            InitializeComponent();

            InitControls();

            m_context.Entry(m_entry).Collection(e => e.Directors).Load();
            m_context.Entry(m_entry).Collection(e => e.Actors).Load();

            InitAuthorList(m_selectedDirectors, m_entry.Directors);
            InitAuthorList(m_selectedActors, m_entry.Actors);

            RefreshAuthorList(actorsListbox, m_selectedActors);
            RefreshAuthorList(directorsListbox, m_selectedDirectors);
        }

        [Obsolete("This exists only for designer purposes")]
        public EditMovieForm() : this(null, null)
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
            SaveAuthorEntry(m_entry.Directors, m_selectedDirectors);
            SaveAuthorEntry(m_entry.Actors, m_selectedActors);
            m_context.SaveChanges();
            AddFormManager.CloseForm();
        }
    }
}
