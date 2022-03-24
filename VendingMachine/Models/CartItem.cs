using System.ComponentModel.DataAnnotations;

namespace VendingMachine.Models
{
    public class CartItem
    {
        [Required]
        public string Id { get; set; }

        [Required]
        public string ProductId { get; set; }

        [Required]
        public string MachineInventoryId { get; set; }
        public int Quality { get; set; }
        public int Price { get; set; }
        public double Total { 
            get
            {
                return Price * Quality;
            } 
        }
    }
}
