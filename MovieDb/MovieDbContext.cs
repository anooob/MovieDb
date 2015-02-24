using MovieDb.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace MovieDb
{
    public class MovieDbContext : DbContext
    {
        public DbSet<EntryBase> Entries { get; set; }
        public DbSet<Author> Authors { get; set; }

        public MovieDbContext(string name)
            : base(name)
        { }

        public void RemoveEntry(int id)
        {
            var entity = Entries.Find(id);
            if (entity != null)
            {
                Entries.Remove(entity);
                SaveChanges();
            }
        }

        public void RemoveAuthor(int id)
        {
            var entity = Authors.Find(id);
            if (entity != null)
            {
                Authors.Remove(entity);
                SaveChanges();
            }
        }

        public Author GetAuthor(int id)
        {
            var entity = Authors.Find(id);
            return entity;
        }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            CreateModel(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        private void CreateModel(DbModelBuilder modelBuilder)
        {
            //Actors mapping
            modelBuilder.Entity<Author>().HasMany<MovieEntry>(a => a.ActedIn).WithMany(m => m.Actors)
                .Map(am =>
                {
                    am.MapLeftKey("ActorKey");
                    am.MapRightKey("MovieKey");
                    am.ToTable("MovieActors");
                }
                );
            //Directors mapping
            modelBuilder.Entity<Author>().HasMany<MovieEntry>(a => a.Directed).WithMany(m => m.Directors)
                .Map(am =>
                {
                    am.MapLeftKey("DirectorKey");
                    am.MapRightKey("MovieKey");
                    am.ToTable("MovieDirectors");
                }
                );
            //Authors mapping
            modelBuilder.Entity<Author>().HasMany<BookEntry>(a => a.Writen).WithMany(b => b.Authors)
                .Map(ab =>
                {
                    ab.MapLeftKey("AuthorKey");
                    ab.MapRightKey("BookKey");
                    ab.ToTable("BookAuthors");
                }
                );
        }
    }
}
