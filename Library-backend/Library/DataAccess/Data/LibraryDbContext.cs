using DataAccess.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data
{
    public class LibraryDbContext : IdentityDbContext<User>
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options) { }

        DbSet<Book> Books { get; set; } = default!;
        DbSet<Author> Authors { get; set; } = default!;
        DbSet<Genre> Genres { get; set; } = default!;
        DbSet<Review> Reviews { get; set; } = default!;
        DbSet<Borrow> Borrows { get; set; } = default!;
        DbSet<Wishlist> Wishlists { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.SeedBooks();
            modelBuilder.SeedAuthors();
            modelBuilder.SeedGenres();
            modelBuilder.SeedReviews();
            modelBuilder.SeedBorrows();
            modelBuilder.SeedWishlists();
            modelBuilder.SeedUsers();
        }
    }
}
