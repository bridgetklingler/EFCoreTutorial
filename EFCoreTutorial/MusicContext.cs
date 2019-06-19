using System;
using System.Collections.Generic;
using System.Text;
using EFCoreTutorial.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreTutorial
{
    public class MusicContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=MusicTesting;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

    }
}
