using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseLayer.Models
{
    [Table("products")]
    public class Product
    {
        [Key]
        public int id { get; set; }
        public string Style { get; set; }
        public string Color { get; set; }
        public string Sku { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string Stock { get; set; }
    }
}