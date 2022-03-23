using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VendingMachine.Repositories.Interfaces;

namespace VendingMachine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private ILocationRepository _locationRepository;

        public LocationController(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetLocations()
        {
            var locations = await _locationRepository.GetLocationsAsync();
            return Ok(locations);
        }

        [HttpGet("machine")]
        public async Task<IActionResult> GetLocationWithMachine()
        {
            var locations = await _locationRepository.GetLocationWithMachine();
            return Ok(locations);
        }
    }
}
