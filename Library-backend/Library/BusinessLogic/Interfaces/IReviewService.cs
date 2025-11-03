using BusinessLogic.Configurations.DTOs.ReviewDto;

namespace BusinessLogic.Interfaces
{
    public interface IReviewService
    {
        Task<IList<ReviewDto>> GetAllAsync(string? bookTitle, string? userName, int pageNumber);

        Task<ReviewDto?> GetByIdAsync(int id);

        Task<ReviewDto> CreateAsync(CreateReviewDto dto);

        Task UpdateAsync(int id, UpdateReviewDto dto);

        Task DeleteAsync(int id);
    }
}
