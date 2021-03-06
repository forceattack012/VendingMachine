namespace VendingMachine.Entities
{
    public class MachineInventory
    {
        public string Id { get; set; }
        public string MachineId { get; set; }
        public Machine Machine { get; set; }
        public string ProductId { get; set; }
        public Product Product { get; set; }
        public int Quality { get; set; }

        public MachineInventory() { }

        public MachineInventory(string id, string machineId, string productId,int quality)
        {
            Id = id;
            MachineId = machineId;
            ProductId = productId;
            Quality = quality;
        }

    }
}
