using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using VendingMachine.Entities;
using VendingMachine.Hubs;
using VendingMachine.Models;
using VendingMachine.Repositories.Interfaces;

namespace VendingMachine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MachineInventoryController : ControllerBase
    {
        private readonly IMachineInventoryRepository _machineRepository;
        private readonly IHubContext<AdminNotificationHub> _adminHub;
        private readonly IUserRepository _userRepository;

        public MachineInventoryController(IMachineInventoryRepository machineRepository, IHubContext<AdminNotificationHub> adminHub, IUserRepository userRepository)
        {
            _machineRepository = machineRepository;
            _adminHub = adminHub;
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetInvertories()
        {
            var result = await _machineRepository.GetMachineInventoriesAsync();
            var response = result.Select(r => new MachineInventoryResponse()
            {
                InventoryId = r.Id,
                ProductId = r.ProductId,
                MachineId = r.MachineId,
                MachineName = r.Machine.Name,
                Price = r.Product.Price,
                ProductName = r.Product.Name,
                Quatity = r.Quality
            });

            return Ok(response);
        }

        [HttpGet("{machineId}")]
        public async Task<IActionResult> GetInvertoryByMachineId([Required]string machineId)
        {
            var result = await _machineRepository.GetMachineInventoriesByMachineIdAsync(machineId);

            if(!result.Any()) return NotFound();

            var response = result.Select(r => new MachineInventoryResponse()
            {
                InventoryId = r.Id,
                ProductId = r.ProductId,
                MachineId = r.MachineId,
                MachineName = r.Machine.Name,
                Price = r.Product.Price,
                ProductName = r.Product.Name,
                Quatity = r.Quality
            });

            return Ok(response);
        }

        [Authorize(Roles = "User")]
        [HttpPost("Buy")]
        public async Task<IActionResult> BuyProduct([Required]CartItem cartItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var isExist = await _machineRepository.GetProductByMachineInventoryIdAndProductId(cartItem.Id, cartItem.ProductId);

            if (isExist == null)
            {
                return NotFound();
            }

            if(cartItem.Quality > isExist.Quality || cartItem.Quality < 0)
            {
                return BadRequest("Quilty invalid");
            }

            isExist.Quality -= cartItem.Quality;

            await _machineRepository.Update(isExist);
            await sendNotifindToAdmin(isExist.Quality, isExist);

            return StatusCode(201);
        }

        private async Task sendNotifindToAdmin(int qty, MachineInventory machineInventory)
        {
            if(qty < 10)
            {
                var result = new MachineInventoryResponse()
                {
                    InventoryId = machineInventory.Id,
                    ProductId = machineInventory.ProductId,
                    MachineId = machineInventory.MachineId,
                    MachineName = machineInventory.Machine.Name,
                    Price = machineInventory.Product.Price,
                    ProductName = machineInventory.Product.Name,
                    Quatity = machineInventory.Quality
                };

                var userAdmins = await _userRepository.GetAllAdmins();
                var userNames = userAdmins.Select(r => r.UserName);
                string content = JsonConvert.SerializeObject(result);
                await _adminHub.Clients.All.SendAsync("notificationAdmin", content);
            }
        }
    }
}
