using Auctionsite_Backend.Core.Interface;
using Auctionsite_Backend.Data.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Auctionsite_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuctionsController : ControllerBase
    {
        private readonly IAuctionsService _auctionsService;

        public AuctionsController(IAuctionsService auctionsService)
        {
            _auctionsService = auctionsService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAuctionsList()
        {
            var response = await _auctionsService.GetAuctionsList();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAuctionById(int id)
        {
            var response = await _auctionsService.GetAuctionById(id);
            if (response == null) return BadRequest(response);
            else return Ok(response);
        }

        [Authorize("UserOrAdmin")]
        [HttpPost]
        public async Task<IActionResult> CreateNewAuction([FromBody] CreateNewAuctionDTO auction)
        {
            var userId = GetUserIdFromJWT();
            if (userId == 0) return BadRequest("No user found");
            var response = await _auctionsService.CreateNewAuction(auction, userId);
            if (response.Message != "success") return BadRequest(response.Message);
            return Ok(response);
        }

        [Authorize("UserOrAdmin")]
        [HttpPut]
        public async Task<IActionResult> EditAuction([FromBody] EditAuctionDTO auction)
        {
            var userId = GetUserIdFromJWT();
            if (userId == 0) return BadRequest("No user found");
            var userRole = User.FindFirstValue(ClaimTypes.Role);

            if (userRole == "admin" || userId == auction.AuctionCreaterId)
            {
                var response = await _auctionsService.EditAuction(auction);
                return Ok(response);
            }
            else return BadRequest("You are not authorized to edit this auction");
        }

        [Authorize("UserOrAdmin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAuction([FromBody] DeleteAuctionDTO auction)
        {
            //admin eller ägaren av auctionen kan deleta
            return Ok();
        }

        private int GetUserIdFromJWT()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null) return 0;
            else return int.Parse(userId);
        }
    }
}
