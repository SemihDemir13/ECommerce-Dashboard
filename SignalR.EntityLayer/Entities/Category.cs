using System.ComponentModel.DataAnnotations;

namespace SignalR.EntityLayer.Entities
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public  string CategoryName { get; set; }
        public bool status {  get; set; }   

        public List<Product> Products { get; set; } 
    }
    
}
