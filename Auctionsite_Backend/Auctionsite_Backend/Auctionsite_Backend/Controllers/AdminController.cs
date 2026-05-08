using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Auctionsite_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        [Authorize("AdminOnly")]
        [HttpPut("deactivate-auction-{id}")]
        public async Task<IActionResult> DeactivateAuction(int id)
        {
            return Ok();
        }

        [Authorize("AdminOnly")]
        [HttpPut("deactivate-user-{id}")]
        public async Task<IActionResult> DeactivateUser(int id)
        {
            return Ok();
        }
    }
}
