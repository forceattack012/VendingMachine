namespace VendingMachine.Entities
{
    public class Machine
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<MachineInventory> MachineInventories { get; set;} = new List<MachineInventory>();
        public string LocationId { get; set; } 
        public Location Location { get; set; }
    }
}
