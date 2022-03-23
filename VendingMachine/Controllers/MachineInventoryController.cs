using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
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

        [HttpGet]
        public async Task<IActionResult> GetInvertoryByMachineId([Required]string machineId)
        {
            var result = await _machineRepository.GetMachineInventoriesByMachineIdAsync(machineId);
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
    }
}
