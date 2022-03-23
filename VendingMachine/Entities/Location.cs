namespace VendingMachine.Entities
{
    public class Location
    {
        public string Id { get; set; }
        public string Address { get; set; }
        public List<Machine> Machines { get; set; } = new List<Machine>();
    }
}
