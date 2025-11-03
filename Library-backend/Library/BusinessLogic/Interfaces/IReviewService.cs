using BusinessLogic.Configurations.DTOs.ReviewDto;

namespace BusinessLogic.Interfaces
{
    public interface IReviewService
    {
        Task<IList<ReviewDto>> GetAll(string? bookTitle, string? userName, int numberPage);

        Task<ReviewDto?> GetById(int id);

        Task<ReviewDto> Create(CreateReviewDto dto);

        Task Update(int id, UpdateReviewDto dto);

        Task Delete(int id);
    }
}
