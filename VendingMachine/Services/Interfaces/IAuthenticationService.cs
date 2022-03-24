using VendingMachine.Entities;
using VendingMachine.Models;

namespace VendingMachine.Services.Interfaces
{
    public interface IAuthenticationService
    {
        TokenResponse GenerateToken(User user);
    }
}
