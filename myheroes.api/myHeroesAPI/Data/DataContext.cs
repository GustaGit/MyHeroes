using Microsoft.EntityFrameworkCore;
using myHeroesAPI.Models;

namespace myHeroesAPI.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) { }

        public DbSet<Hero> Hero => Set<Hero>();
        public DbSet<Superpower> Superpoderes => Set<Superpower>();
        public DbSet<HeroSuperpower> HeroisSuperpoderes => Set<HeroSuperpower>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HeroSuperpower>().HasKey(t => new { t.HeroId, t.SuperpowerId });

            base.OnModelCreating(modelBuilder);
        }
    }
}
