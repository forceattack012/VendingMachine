namespace VendingMachine.Entities
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public List<MachineInventory> MachineInventories { get; set; } = new List<MachineInventory>();
    }
}
