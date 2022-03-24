using VendingMachine.Entities;

namespace VendingMachine.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserByUserNameAndPassword(string userName, string password);
        Task<IEnumerable<User>> GetAllAdmins();
    }
}
