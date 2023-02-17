namespace DemoAPI.Models
{
    public class DbInitializer
    {
        public static void Initialize(DemoAngu_DBContext DBcontext)
        {
            DBcontext.Database.EnsureCreated();
            if (DBcontext.Products.Any())
            {
                return;   // DB has been seeded
            }
            var listProduct = new Product[] {
                new Product {id = 1,name="Business & Economics",description="All kinds of books related to business and investing: management, finance, entrepreneurs, startup, skills, sales, etc", price = 23000, quantity = 300 },
                new Product {id = 2,name="Children's Books", description="All kinds of books for children to learn, entertain and have fun such as graphic books, children stories, fairy tales, comics, etc.", price = 240000, quantity = 20},
                new Product {id = 3,name="Fiction - Literature", description = "Fictions, novels, chicklit, poem and more", price = 20000, quantity = 2}
            };
            foreach (var item in listProduct)
            {
                DBcontext.Products.Add(item);
            }
            DBcontext.SaveChanges();
        }
    }
}
