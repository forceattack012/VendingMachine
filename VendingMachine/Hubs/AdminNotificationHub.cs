using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using VendingMachine.Repositories.Interfaces;

namespace VendingMachine.Hubs
{
    public class AdminNotificationHub : Hub
    {
        private readonly IUserRepository _userRepository;
        private IDictionary<string, string> userGroups = new Dictionary<string, string>();
        public AdminNotificationHub(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public override Task OnConnectedAsync()
        {
            var userAdmins = _userRepository.GetAllAdmins().Result;
            var userNames = userAdmins.Select(r => r.UserName).ToArray();

            
            foreach (var userName in userNames)
            {
                if (!userGroups.ContainsKey(userName))
                {
                    _ = Groups.AddToGroupAsync(Context.ConnectionId, userName);
                    userGroups.Add(userName, Context.ConnectionId);
                }
            }

            return base.OnConnectedAsync();
        }
    }
}
