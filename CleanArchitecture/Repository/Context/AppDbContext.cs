using Data.Entity;
using Data.Map;
using Microsoft.EntityFrameworkCore;

namespace Repository.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new ProductMap(modelBuilder.Entity<Product>());
            new CategoryMap(modelBuilder.Entity<Category>());

            base.OnModelCreating(modelBuilder);
        }
    }
}
