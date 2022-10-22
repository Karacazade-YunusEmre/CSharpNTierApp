using Microsoft.EntityFrameworkCore;
using NTierApp.Entities.Concrete;

namespace NTierApp.DataAccess.Concrete.EntityFramework
{
    public class NorthWindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<Product>? Products { get; set; }
        public DbSet<Category>? Categories { get; set; }
    }
}
