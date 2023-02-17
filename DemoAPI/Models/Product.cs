using System.ComponentModel.DataAnnotations;

namespace DemoAPI.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }
        [MaxLength(500)]
        public string name { get; set; }
        public int price { get; set; }
        [MaxLength(800)]
        public string description { get; set; }
        public int quantity { get; set; }
    }
}
