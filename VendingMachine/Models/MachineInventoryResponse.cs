

namespace VendingMachine.Models
{
    public class MachineInventoryResponse
    {
        public string InventoryId { get; set; }
        public string ProductId { get; set; }
        public string MachineId { get; set; }
        public string MachineName { get; set; }
        public string ProductName { get; set; }
        public int Quatity { get; set; }
        public double Price { get; set; }
    }


}
