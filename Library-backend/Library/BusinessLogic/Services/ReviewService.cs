using AutoMapper;
using BusinessLogic.Configurations.DTOs.ReviewDto;
using BusinessLogic.Interfaces;
using DataAccess.Data.Entities;
using DataAccess.Repositories;
using LinqKit;

namespace BusinessLogic.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IRepository<Review> repo;
        private readonly IMapper mapper;

        public ReviewService(IRepository<Review> repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        public async Task<ReviewDto> Create(CreateReviewDto dto)
        {
            var review = mapper.Map<Review>(dto);

            await repo.AddAsync(review);

            return mapper.Map<ReviewDto>(review);
        }

        public async Task Delete(int id)
        {
            if(id < 0)
                throw new Exception("Id can`t be negative");

            var review = await repo.GetByIdAsync(id);

            if (review == null)
                throw new Exception("Review not found.");

            await repo.DeleteAsync(id);
        }

        public async Task<IList<ReviewDto>> GetAll(string? bookTitle, string? userName, int numberPage = 1)
        {
            var filters = PredicateBuilder.New<Review>(true);

            if(bookTitle  != null)
                filters = filters.And(x => x.Book.Title.Contains(bookTitle));

            if(userName != null)
                filters = filters.And(x => x.User.UserName.Contains(userName));

            var reviews = await repo.GetAllAsync(numberPage, 10, filters, "Book", "User");

            return mapper.Map<IList<ReviewDto>>(reviews);
        }

        public async Task<ReviewDto?> GetById(int id)
        {
            if(id < 0)
                throw new Exception("Id can`t be negative");

            var review = await repo.GetByIdAsync(id, "Book", "User");

            if (review == null)
                return null;

            return mapper.Map<ReviewDto>(review);
        }

        public async Task Update(int id, UpdateReviewDto dto)
        {
            var review = await repo.GetByIdAsync(id);

            if (review == null)
                throw new Exception("Review not found.");

            mapper.Map(dto, review);

            await repo.UpdateAsync(review);
        }
    }
}
