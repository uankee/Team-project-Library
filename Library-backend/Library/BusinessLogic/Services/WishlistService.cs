using AutoMapper;
using BusinessLogic.Configurations.DTOs.WishlistDto;
using BusinessLogic.Interfaces;
using DataAccess.Data;
using DataAccess.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class WishlistService : IWishlistService
    {
        private readonly LibraryDbContext _context;
        private readonly IMapper _mapper;

        public WishlistService(LibraryDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<WishlistDto>> GetAllAsync()
        {
            var wishlists = await _context.Wishlists
                .Include(w => w.Book)
                .Include(w => w.User)
                .ToListAsync();

            return _mapper.Map<IEnumerable<WishlistDto>>(wishlists);
        }

        public async Task<WishlistDto?> GetByIdAsync(int id)
        {
            var wishlist = await _context.Wishlists
                .Include(w => w.Book)
                .Include(w => w.User)
                .FirstOrDefaultAsync(w => w.Id == id);

            return _mapper.Map<WishlistDto?>(wishlist);
        }

        public async Task<WishlistDto> CreateAsync(CreateWishlistDto dto)
        {
            var wishlist = _mapper.Map<Wishlist>(dto);
            _context.Wishlists.Add(wishlist);
            await _context.SaveChangesAsync();

            return _mapper.Map<WishlistDto>(wishlist);
        }

        public async Task<WishlistDto?> UpdateAsync(int id, UpdateWishlistDto dto)
        {
            var wishlist = await _context.Wishlists.FindAsync(id);
            if (wishlist == null) return null;

            _mapper.Map(dto, wishlist);
            await _context.SaveChangesAsync();

            return _mapper.Map<WishlistDto>(wishlist);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var wishlist = await _context.Wishlists.FindAsync(id);
            if (wishlist == null) return false;

            _context.Wishlists.Remove(wishlist);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
