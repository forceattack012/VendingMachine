using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace VendingMachine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        
        [HttpGet("{machineId}")]
        public async Task<IActionResult> GetProductByMachineId([Required]string machineId)
        {
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct([Required]string productId)
        {
            return Ok();
        }
    }
}
