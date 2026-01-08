using Microsoft.EntityFrameworkCore;
using Product.Api.Models;

namespace Product.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opts) : base(opts) { }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .Property(p => p.Preco)
                .HasPrecision(18, 2);
        }

    }
}
