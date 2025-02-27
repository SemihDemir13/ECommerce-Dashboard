using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SignalR.EntityLayer.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }

        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool ProductStatus { get; set; }

        [ForeignKey("Category")] // Foreign Key olarak belirtiyoruz
        public int CategoryId { get; set; }

        public Category Category { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }




    }
}
