namespace VendingMachine.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Describetion { get; set; }

        public List<User> Users { get; set; } = new List<User>();
    }
}
