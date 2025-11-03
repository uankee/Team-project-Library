using BusinessLogic.Configurations.DTOs.GenreDto;
using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IGenreService genreService;

        public GenreController(IGenreService genreService)
        {
            this.genreService = genreService;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAll(string? genreName, int pageNumber = 1)
        {
            var genres = await genreService.GetAllAsync(genreName, pageNumber);

            return Ok(genres);
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<IActionResult> GetById(int id)
        {
            var genre = await genreService.GetByIdAsync(id);

            if (genre == null)
                return NotFound();

            return Ok(genre);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(CreateGenreDto dto)
        {
            var createdGenre = await genreService.CreateAsync(dto);

            return CreatedAtAction(nameof(GetById), new { id = createdGenre.Id }, createdGenre);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            await genreService.DeleteAsync(id);

            return NoContent();
        }
    }
}
