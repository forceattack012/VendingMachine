using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using VendingMachine.Entities;
using VendingMachine.Models;
using VendingMachine.Repositories.Interfaces;

namespace VendingMachine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MachineInventoryController : ControllerBase
    {
        private readonly IMachineInventoryRepository _machineRepository;

        public MachineInventoryController(IMachineInventoryRepository machineRepository)
        {
            _machineRepository = machineRepository;
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


            sendNotifindToAdmin(isExist.Quality);

            return Created("localhost:4200/", "Buy successful");
        }

        private void sendNotifindToAdmin(int qty)
        {
            if(qty < 10)
            {
                // websocket to client for admin user
            }
        }
    }
}
