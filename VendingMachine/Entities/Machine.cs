namespace VendingMachine.Entities
{
    public class Machine
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set;} = new List<Product>();
        public string LocationId { get; set; } 
        public Location Location { get; set; }
    }
}
