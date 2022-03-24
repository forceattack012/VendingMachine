using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using VendingMachine.Models;
using VendingMachine.Repositories.Interfaces;

namespace VendingMachine.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MachineController : ControllerBase
    {
        private readonly IMachineRepository _machineRepository;

        public MachineController(IMachineRepository machineRepository)
        {
            _machineRepository = machineRepository;
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> GetMachines()
        {
            var result = await _machineRepository.GetMachinesAsync();

            var locations = result.Select(x => new LocationResponse()
            {
                LocationId = x.LocationId,
                LocationName = x.Location.Address,
                MachineName = x.Name
            });

            return Ok(locations);
        }

        [HttpGet("{locationId}")]
        public async Task<IActionResult> GetMachineByLocationId([Required] string locationId)
        {
            var machines = await _machineRepository.FindMachineInLocationId(locationId);
            if(machines == null) return NotFound();

            return Ok(machines);
        }
    }
}
