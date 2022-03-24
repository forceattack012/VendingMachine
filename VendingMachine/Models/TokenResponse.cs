namespace VendingMachine.Models
{
    public class TokenResponse
    {
        public string Token { get; set; }
        public DateTime Expire { get; set; }
    }
}
