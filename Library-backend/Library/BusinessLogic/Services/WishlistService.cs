using AutoMapper;
using BusinessLogic.Configurations.DTOs.WishlistDto;
using BusinessLogic.Interfaces;
using DataAccess.Data.Entities;
using DataAccess.Repositories;

namespace BusinessLogic.Services
{
    public class WishlistService : IWishlistService
    {
        private readonly IRepository<Wishlist> _wishlistRepository;
        private readonly IMapper _mapper;

        public WishlistService(IRepository<Wishlist> wishlistRepository, IMapper mapper)
        {
            _wishlistRepository = wishlistRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<WishlistDto>> GetAllAsync()
        {
            var wishlists = await _wishlistRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<WishlistDto>>(wishlists);
        }

        public async Task<WishlistDto?> GetByIdAsync(int id)
        {
            var wishlist = await _wishlistRepository.GetByIdAsync(id);
            return wishlist == null ? null : _mapper.Map<WishlistDto>(wishlist);
        }

        public async Task<WishlistDto> CreateAsync(CreateWishlistDto dto)
        {
            var entity = _mapper.Map<Wishlist>(dto);
            await _wishlistRepository.AddAsync(entity);
            return _mapper.Map<WishlistDto>(entity);
        }

        public async Task<WishlistDto?> UpdateAsync(int id, UpdateWishlistDto dto)
        {
            var entity = await _wishlistRepository.GetByIdAsync(id);
            if (entity == null) return null;

            _mapper.Map(dto, entity);
            await _wishlistRepository.UpdateAsync(entity);
            return _mapper.Map<WishlistDto>(entity);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await _wishlistRepository.GetByIdAsync(id);
            if (entity == null) return false;

            await _wishlistRepository.DeleteAsync(entity);
            return true;
        }
    }
}
