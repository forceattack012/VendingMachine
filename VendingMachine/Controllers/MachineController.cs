using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using VendingMachine.Repositories.Interfaces;

namespace VendingMachine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MachineController : ControllerBase
    {
        private readonly IMachineRepository _machineRepository;

        public MachineController(IMachineRepository machineRepository)
        {
            _machineRepository = machineRepository;
        }


        [HttpGet]
        public async Task<IActionResult> GetMachines()
        {
            var result = await _machineRepository.GetMachinesAsync();
            return Ok(result);
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
