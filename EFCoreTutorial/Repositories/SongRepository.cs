using EFCoreTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCoreTutorial.Repositories
{
    public class SongRepository
    {
            private MusicContext db;

            public SongRepository(MusicContext db)
            {
                this.db = db;
            }

            public int Count()
            {
                return db.Songs.Count();
            }

            public void Create(Song song)
            {
                db.Songs.Add(song);
                db.SaveChanges();
            }

            public Song GetById(int id)
            {
                return db.Songs.Single(s => s.Id == id);
            }

            public void Delete(Song song)
            {
                db.Songs.Remove(song);
                db.SaveChanges();
            }

            public void Save()
            {
                db.SaveChanges();
            }

            public IEnumerable<Song> GetAll()
            {
                return db.Songs.ToList();
            }
    }
}
