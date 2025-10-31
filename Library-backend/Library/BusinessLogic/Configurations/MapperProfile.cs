using AutoMapper;
using DataAccess.Data.Entities;
using BusinessLogic.Configurations.DTOs.AuthorDto;
using BusinessLogic.Configurations.DTOs.BookDto;
using BusinessLogic.Configurations.DTOs.BorrowDto;
using BusinessLogic.Configurations.DTOs.GenreDto;
using BusinessLogic.Configurations.DTOs.ReviewDto;
using BusinessLogic.Configurations.DTOs.UserDto;
using BusinessLogic.Configurations.DTOs.WishlistDto;

namespace BusinessLogic.Configurations
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            // Author
            CreateMap<Author, AuthorDto>().ReverseMap();
            CreateMap<Author, CreateAuthorDto>().ReverseMap();
            CreateMap<Author, UpdateAuthorDto>().ReverseMap();

            // Book
            CreateMap<Book, BookDto>().ReverseMap();
            CreateMap<Book, CreateBookDto>().ReverseMap();
            CreateMap<Book, UpdateBookDto>().ReverseMap();

            // Borrow (Rent)
            CreateMap<Borrow, BorrowDto>().ReverseMap();
            CreateMap<Borrow, CreateBorrowDto>().ReverseMap();
            CreateMap<Borrow, UpdateBorrowDto>().ReverseMap();

            // Genre
            CreateMap<Genre, GenreDto>().ReverseMap();
            CreateMap<Genre, CreateGenreDto>().ReverseMap();
            CreateMap<Genre, UpdateGenreDto>().ReverseMap();

            // Review
            CreateMap<Review, ReviewDto>().ReverseMap();
            CreateMap<Review, CreateReviewDto>().ReverseMap();
            CreateMap<Review, UpdateReviewDto>().ReverseMap();

            // User
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, CreateUserDto>().ReverseMap();
            CreateMap<User, UpdateUserDto>().ReverseMap();

            // Wishlist
            CreateMap<Wishlist, WishlistDto>().ReverseMap();
            CreateMap<Wishlist, CreateWishlistDto>().ReverseMap();
            CreateMap<Wishlist, UpdateWishlistDto>().ReverseMap();
        }
    }
}
