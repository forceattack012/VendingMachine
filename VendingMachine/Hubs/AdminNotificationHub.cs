using Microsoft.AspNetCore.SignalR;
using VendingMachine.Entities;
using VendingMachine.Repositories.Interfaces;

namespace VendingMachine.Hubs
{
    public class AdminNotificationHub : Hub
    {
        private readonly IUserRepository _userRepository;

        public AdminNotificationHub(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void SendToAdmins(string message)
        {
            Clients.Groups(Context.ConnectionId).SendAsync(message);
        }

        public override Task OnConnectedAsync()
        {
            var userAdmins = _userRepository.GetAllAdmins().Result;
            var userNames = userAdmins.Select(r => r.UserName).ToArray();

            foreach (var userName in userNames)
            {
                _ = Groups.AddToGroupAsync(Context.ConnectionId, userName);
            }

            return base.OnConnectedAsync();
        }
    }
}
