namespace VendingMachine.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quality { get; set; }
        public string MachineId { get;set; }
        public Machine Machine { get; set; }
    }
}
