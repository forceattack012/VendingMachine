using Microsoft.EntityFrameworkCore;
using VendingMachine.Data;
using VendingMachine.Entities;
using VendingMachine.Repositories.Interfaces;

namespace VendingMachine.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly VendingMachineContext _userRepository;

        public UserRepository(VendingMachineContext userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> GetUserByUserNameAndPassword(string userName, string password)
        {
            return await _userRepository.User.Where(r => r.UserName.Equals(userName) && r.Password.Equals(password))
                        .Include(r => r.Role)
                        .FirstOrDefaultAsync();
        }
    }
}
