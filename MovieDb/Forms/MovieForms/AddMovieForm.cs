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

namespace MovieDb.Forms
{
    /// <summary>
    /// Form for adding movie entries into the database
    /// </summary>
    public partial class AddMovieForm : AddFormBase
    {
        #region Fields
        
        protected MovieEntry m_entry = new MovieEntry();
        protected List<Author> m_selectedDirectors = new List<Author>();
        protected List<Author> m_selectedActors = new List<Author>();
        
        #endregion

        #region Construction

        public AddMovieForm(MovieDbContext context)
        {
            InitializeComponent();
            m_context = context;
            typeCombo.SelectedIndexChanged -= m_typeComboSelectedChangedHandler;
            typeCombo.SelectedIndex = (int)EntryType.Movie;
            typeCombo.SelectedIndexChanged += m_typeComboSelectedChangedHandler;
        }

        [Obsolete("This exists only for designer purposes")]
        public AddMovieForm()
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

            if ((int)typeCombo.SelectedValue == (int)EntryType.Movie)
            {
                m_entry.Name = text;
                m_entry.PublicationYear = yearTextbox.Text;
                SaveAuthorEntry(m_entry.Directors, m_selectedDirectors);
                SaveAuthorEntry(m_entry.Actors, m_selectedActors);
                m_context.Entries.Add(m_entry);
                m_context.SaveChanges();
            }

            AddFormManager.CloseForm();
        }

        #region Event Handling

        private void addDirectorButton_Click(object sender, EventArgs e)
        {
            OnAddAuthor(DirectorAddedCallback);
        }

        private void removeDirectorButton_Click(object sender, EventArgs e)
        {
            OnRemoveDirector();
        }

        private void addActorButton_Click(object sender, EventArgs e)
        {
            OnAddAuthor(ActorAddedCallback);
        }

        private void removeActorButton_Click(object sender, EventArgs e)
        {
            OnRemoveActor();
        }

        private void DirectorAddedCallback(Author newDirector)
        {
            if (newDirector == null)
                return;
            if (!m_selectedDirectors.Contains(newDirector))
                m_selectedDirectors.Add(newDirector);
            RefreshAuthorList(directorsListbox, m_selectedDirectors);
            
        }

        private void ActorAddedCallback(Author newActor)
        {
            if (newActor == null)
                return;
            if (!m_selectedActors.Contains(newActor))
                m_selectedActors.Add(newActor);
            RefreshAuthorList(actorsListbox, m_selectedActors);
        }

        protected virtual void OnRemoveDirector()
        {
            if (directorsListbox.SelectedItem == null)
                return;
            var item = directorsListbox.SelectedItem as AuthorItem;
            if (item != null)
            {
                var director = m_context.GetAuthor(item.Id);
                if (director != null)
                {
                    m_selectedDirectors.Remove(director);
                    RefreshAuthorList(directorsListbox, m_selectedDirectors);
                }
            }
        }

        protected virtual void OnRemoveActor()
        {
            if (actorsListbox.SelectedItem == null)
                return;
            var item = actorsListbox.SelectedItem as AuthorItem;
            if (item != null)
            {
                var actor = m_context.GetAuthor(item.Id);
                if (actor != null)
                {
                    m_selectedActors.Remove(actor);
                    RefreshAuthorList(actorsListbox, m_selectedActors);
                }
            }
        }

        #endregion
    }
}
