using BusinessLogic.Configurations.DTOs.WishlistDto;
using BusinessLogic.Interfaces;
using BusinessLogic.Services;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WishlistController : ControllerBase
    {
        private readonly IWishlistService _wishlistService;

        public WishlistController(IWishlistService wishlistService)
        {
            _wishlistService = wishlistService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var wishlists = await _wishlistService.GetAllAsync();
            return Ok(wishlists);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var wishlist = await _wishlistService.GetByIdAsync(id);
            if (wishlist == null) return NotFound();

            return Ok(wishlist);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateWishlistDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var created = await _wishlistService.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateWishlistDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var updated = await _wishlistService.UpdateAsync(id, dto);
            if (updated == null) return NotFound();

            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _wishlistService.DeleteAsync(id);
            if (!deleted) return NotFound();

            return NoContent();
        }
    }
}
