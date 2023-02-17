using Microsoft.EntityFrameworkCore;
namespace DemoAPI.Models
{
    public class DemoAngu_DBContext:DbContext
    {
        public DemoAngu_DBContext(DbContextOptions<DemoAngu_DBContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product() { id = 1, name = "Business & Economics", description = "All kinds of books related to business and investing: management, finance, entrepreneurs, startup, skills, sales, etc", price = 23000, quantity = 300 },
                new Product() { id = 2, name = "Children's Books", description = "All kinds of books for children to learn, entertain and have fun such as graphic books, children stories, fairy tales, comics, etc.", price = 240000, quantity = 20 },
                new Product() { id = 3, name = "Fiction - Literature", description = "Fictions, novels, chicklit, poem and more", price = 20000, quantity = 2 }
                );
        }
    }
}
