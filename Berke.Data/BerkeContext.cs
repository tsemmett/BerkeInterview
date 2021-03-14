using System;
using Microsoft.EntityFrameworkCore;
using Berke.Domain;


namespace Berke.Data
{
    public class BerkeContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Using a database on my personal server. The user's access is limited to read/write only to the temporary DB I created for this.
            //I'm not that worried about the password/user name being plain text.
            optionsBuilder
                .UseSqlServer("Data Source=tsemmett.zapto.org,32327; Initial Catalog=Berke; User ID=svc_berke; Password=Svc_berke1");
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Keys for join tables
            modelBuilder.Entity<UserGames>().HasKey(s => new { s.UserId, s.GameId });
            modelBuilder.Entity<GameGenres>().HasKey(s => new { s.GenreId, s.GameId });
            modelBuilder.Entity<PublisherGames>().HasKey(s => new { s.PublisherId, s.GameId });

            ModelBuilderExtensions.AddConstraints(modelBuilder);
            ModelBuilderExtensions.Seed(modelBuilder);
        }
    }
}
