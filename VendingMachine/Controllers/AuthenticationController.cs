using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VendingMachine.Models;
using VendingMachine.Repositories.Interfaces;
using VendingMachine.Services.Interfaces;

namespace VendingMachine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IUserRepository userRepository, IAuthenticationService authenticationService)
        {
            _userRepository = userRepository;
            _authenticationService = authenticationService;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginUser userLogin)
        {
            var user = await _userRepository.GetUserByUserNameAndPassword(userLogin.UserName, userLogin.Password);

            if(user == null)
            {
                return Unauthorized();
            }

            var token = _authenticationService.GenerateToken(user);

            return Ok(token);

        }
    }
}
