using Microsoft.EntityFrameworkCore;

namespace myHeroesAPI.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) { }

        public DbSet<HeroModel> Hero => Set<HeroModel>();
    }
}
