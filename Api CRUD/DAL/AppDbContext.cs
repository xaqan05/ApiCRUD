using Api_CRUD.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api_CRUD.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions opt) : base(opt) { }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>(b =>
            {
                b.HasKey(x => x.Id);
                b.Property(x => x.Name).IsRequired().HasMaxLength(16);
                b.HasData(new Category
                {
                    Name = "Metbex esyalari"
                });
            });
            base.OnModelCreating(modelBuilder);
        }


    }
}
