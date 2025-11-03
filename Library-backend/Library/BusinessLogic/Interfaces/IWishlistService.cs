using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Configurations.DTOs.WishlistDto;

namespace BusinessLogic.Interfaces
{
    public interface IWishlistService
    {
        Task<IEnumerable<WishlistDto>> GetAllAsync();
        Task<WishlistDto?> GetByIdAsync(int id);
        Task<WishlistDto> CreateAsync(CreateWishlistDto dto);
        Task<WishlistDto?> UpdateAsync(int id, UpdateWishlistDto dto);
        Task<bool> DeleteAsync(int id);
    }
}
