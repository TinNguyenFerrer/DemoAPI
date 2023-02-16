namespace DemoAPI.Controllers
{
    public class Product
    {
        public int id {get; set;}
        public string name { get; set; }
        public string? description { get; set; }
        public int parent_id { get; set; }

        public Product(int id, string name, string? description, int parent_id)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.parent_id = parent_id;
        }


    }
}
