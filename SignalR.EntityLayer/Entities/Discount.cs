using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SignalR.EntityLayer.Entities
{
    public class Discount
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Otomatik artan ID

        public int DiscountId {  get; set; }    
        public string Title { get; set; }   
        public string Amount {  get; set; }  
        public string Description { get; set; }
        public string ImageUrl { get; set; }


    }
}
