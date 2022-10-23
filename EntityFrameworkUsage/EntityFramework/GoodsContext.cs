using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkUsage.EntityFramework
{
    public class GoodsContext : DbContext
    {
        public DbSet<Goods>? Goodses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EntityFrameworkUsage");
        }
    }
}
