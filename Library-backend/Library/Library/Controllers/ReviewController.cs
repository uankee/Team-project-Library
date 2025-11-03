using BusinessLogic.Configurations.DTOs.ReviewDto;
using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewService reviewService;

        public ReviewController(IReviewService reviewService)
        {
            this.reviewService = reviewService;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAll(string? bookTitle, string? userName, int pageNumber = 1)
        {
            var reviews = await reviewService.GetAll(bookTitle, userName, pageNumber);

            return Ok(reviews);
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<IActionResult> GetById(int id)
        {
            var review = await reviewService.GetById(id);

            if (review == null)
                return NotFound();

            return Ok(review);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(CreateReviewDto dto)
        {
            var createdReview = await reviewService.Create(dto);

            return CreatedAtAction(nameof(GetById), new { id = createdReview.Id }, createdReview);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(int id, UpdateReviewDto dto)
        {
            await reviewService.Update(id, dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            await reviewService.Delete(id);
            return NoContent();
        }
    }
}
