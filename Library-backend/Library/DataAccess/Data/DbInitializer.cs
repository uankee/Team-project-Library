using DataAccess.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data
{
    public static class DbInitializer
    {
        public static void SeedBooks(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(new[]
            {
                new Book { Id = 1, Title = "The Silent Library", CoverImage = "https://m.media-amazon.com/images/I/410qtwm57cL._AC_UF1000%2C1000_QL80_.jpg", PublishedDate = new DateTime(2015, 6, 12), AvailableCopies = 5, AuthorId = 1, GenreId = 1 },
                new Book { Id = 2, Title = "Echoes of Time", CoverImage = "https://m.media-amazon.com/images/I/81%2BSDwFNDyL._AC_UF1000%2C1000_QL80_.jpg", PublishedDate = new DateTime(2018, 2, 25), AvailableCopies = 8, AuthorId = 2, GenreId = 2 },
                new Book { Id = 3, Title = "Whispers in the Dark", CoverImage = "https://www.hachette.com.au/content/books/9781472112699.jpg", PublishedDate = new DateTime(2020, 11, 3), AvailableCopies = 3, AuthorId = 3, GenreId = 3 },
                new Book { Id = 4, Title = "Beyond the Horizon", CoverImage = "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1673020125i/72404657.jpg", PublishedDate = new DateTime(2017, 9, 15), AvailableCopies = 6, AuthorId = 4, GenreId = 4 },
                new Book { Id = 5, Title = "The Lost Kingdom", CoverImage = "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1699208745i/201610825.jpg", PublishedDate = new DateTime(2016, 5, 1), AvailableCopies = 7, AuthorId = 5, GenreId = 1 },
                new Book { Id = 6, Title = "Shadows of the Mind", CoverImage = "https://m.media-amazon.com/images/I/71hi9RNaieL.jpg", PublishedDate = new DateTime(2019, 12, 8), AvailableCopies = 4, AuthorId = 2, GenreId = 2 },
                new Book { Id = 7, Title = "Winds of Destiny", CoverImage = "https://naasr.org/cdn/shop/products/WindsofDestinylg_1200x1200.jpg?v=1661464372", PublishedDate = new DateTime(2014, 3, 20), AvailableCopies = 9, AuthorId = 1, GenreId = 5 },
                new Book { Id = 8, Title = "Fragments of Tomorrow", CoverImage = "https://m.media-amazon.com/images/I/91CBdKf3gpL._UF1000%2C1000_QL80_.jpg", PublishedDate = new DateTime(2021, 7, 10), AvailableCopies = 2, AuthorId = 3, GenreId = 3 },
                new Book { Id = 9, Title = "City of Echoes", CoverImage = "https://images.thalia.media/07/-/050ad87e2bc9463e8ac4656f54f9683d/avatar-legends-city-of-echoes-avatar-legends-book-1-gebundene-ausgabe-judy-i-lin-englisch.jpeg", PublishedDate = new DateTime(2022, 4, 17), AvailableCopies = 10, AuthorId = 4, GenreId = 4 },
                new Book { Id = 10, Title = "The Forgotten Path", CoverImage = "https://m.media-amazon.com/images/I/71NscVJhd6L._AC_UF1000%2C1000_QL80_.jpg", PublishedDate = new DateTime(2023, 8, 29), AvailableCopies = 5, AuthorId = 5, GenreId = 5 }
            });
        }

        public static void SeedAuthors(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new[]
            {
                new Author { Id = 1, Name = "Emily Carter", Bio = "Emily Carter — сучасна британська письменниця, відома своїми психологічними романами та творами з глибоким емоційним змістом." },
                new Author { Id = 2, Name = "James Thornton", Bio = "James Thornton — американський автор наукової фантастики, який поєднує технологічні теми з філософськими питаннями майбутнього." },
                new Author { Id = 3, Name = "Sophia Alvarez", Bio = "Sophia Alvarez — іспанська письменниця, що спеціалізується на трилерах та детективах із сильними жіночими персонажами." },
                new Author { Id = 4, Name = "Liam O’Connor", Bio = "Liam O’Connor — ірландський автор пригодницьких романів, натхненних історією та міфологією своєї батьківщини." },
                new Author { Id = 5, Name = "Ava Bennett", Bio = "Ava Bennett — канадська письменниця, відома своїми фентезійними циклами про світ магії, природи та давніх цивілізацій." }
            });
        }

        public static void SeedReviews(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Review>().HasData(new[]
            {
                new Review { Id = 1, BookId = 1, UserId = "1", Rating = 4.9, Comment = "Дуже захоплююча історія, не міг відірватися до самого кінця!", CreatedAt = new DateTime(2023, 3, 15) },
                new Review { Id = 2, BookId = 2, UserId = "2", Rating = 4.2, Comment = "Цікаві персонажі, але середина трохи затягнута.", CreatedAt = new DateTime(2023, 5, 2) },
                new Review { Id = 3, BookId = 3, UserId = "3", Rating = 4.3, Comment = "Неймовірна атмосфера, напруга сюжету передана ідеально.", CreatedAt = new DateTime(2023, 6, 10) },
                new Review { Id = 4, BookId = 4, UserId = "4", Rating = 3.5, Comment = "Добре написано, але фінал залишив багато питань.", CreatedAt = new DateTime(2023, 8, 22) },
                new Review { Id = 5, BookId = 5, UserId = "5", Rating = 4.7, Comment = "Сподобався світ і персонажі, трохи бракувало динаміки.", CreatedAt = new DateTime(2023, 9, 12) },
                new Review { Id = 6, BookId = 6, UserId = "2", Rating = 4.1, Comment = "Чудова книга, змусила замислитися над багатьма речами.", CreatedAt = new DateTime(2023, 10, 1) },
                new Review { Id = 7, BookId = 7, UserId = "1", Rating = 4.2, Comment = "Гарний сюжет і стиль, але хотілося б більше глибини у героях.", CreatedAt = new DateTime(2024, 1, 5) },
                new Review { Id = 8, BookId = 8, UserId = "3", Rating = 4.7, Comment = "Фантастичний сюжет! Дуже емоційно та потужно.", CreatedAt = new DateTime(2024, 2, 18) },
                new Review { Id = 9, BookId = 9, UserId = "4", Rating = 3.1, Comment = "Місцями нуднувато, але кінець компенсує усе.", CreatedAt = new DateTime(2024, 3, 8) },
                new Review { Id = 10, BookId = 10, UserId = "5", Rating = 3.8, Comment = "Просто шедевр! Обов’язково перечитаю ще раз.", CreatedAt = new DateTime(2024, 4, 25) }

            });
        }

        public static void SeedBorrows(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Borrow>().HasData(new[]
            {
                 new Borrow { Id = 1, BookId = 1, UserId = "1", BorrowedAt = new DateTime(2023, 3, 1), DueDate = new DateTime(2023, 3, 15), ReturnedAt = new DateTime(2023, 3, 12) },
                new Borrow { Id = 2, BookId = 2, UserId = "2", BorrowedAt = new DateTime(2023, 4, 10), DueDate = new DateTime(2023, 4, 24), ReturnedAt = new DateTime(2023, 4, 22) },
                new Borrow { Id = 3, BookId = 3, UserId = "3", BorrowedAt = new DateTime(2023, 5, 5), DueDate = new DateTime(2023, 5, 19), ReturnedAt = new DateTime(2023, 5, 18) },
                new Borrow { Id = 4, BookId = 4, UserId = "4", BorrowedAt = new DateTime(2023, 6, 2), DueDate = new DateTime(2023, 6, 16), ReturnedAt = new DateTime(2023, 6, 14) },
                new Borrow { Id = 5, BookId = 5, UserId = "5", BorrowedAt = new DateTime(2023, 7, 7), DueDate = new DateTime(2023, 7, 21), ReturnedAt = new DateTime(2023, 7, 19) },
                new Borrow { Id = 6, BookId = 6, UserId = "2", BorrowedAt = new DateTime(2023, 8, 1), DueDate = new DateTime(2023, 8, 15), ReturnedAt = new DateTime(2023, 8, 13) },
                new Borrow { Id = 7, BookId = 7, UserId = "3", BorrowedAt = new DateTime(2023, 9, 10), DueDate = new DateTime(2023, 9, 24), ReturnedAt = new DateTime(2023, 9, 23) },
                new Borrow { Id = 8, BookId = 8, UserId = "4", BorrowedAt = new DateTime(2023, 10, 5), DueDate = new DateTime(2023, 10, 19), ReturnedAt = new DateTime(2023, 10, 17) },
                new Borrow { Id = 9, BookId = 9, UserId = "1", BorrowedAt = new DateTime(2023, 11, 3), DueDate = new DateTime(2023, 11, 17), ReturnedAt = new DateTime(2023, 11, 15) },
                new Borrow { Id = 10, BookId = 10, UserId = "5", BorrowedAt = new DateTime(2023, 12, 1), DueDate = new DateTime(2023, 12, 15), ReturnedAt = new DateTime(2023, 12, 14) }
            });
        }

        public static void SeedWishlists(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Wishlist>().HasData(new[]
            {
                new Wishlist { Id = 1, UserId = "1", BookId = 5 },
                new Wishlist { Id = 2, UserId = "1", BookId = 9 },
                new Wishlist { Id = 3, UserId = "2", BookId = 1 },
                new Wishlist { Id = 4, UserId = "2", BookId = 8 },
                new Wishlist { Id = 5, UserId = "3", BookId = 2 },
                new Wishlist { Id = 6, UserId = "3", BookId = 10 },
                new Wishlist { Id = 7, UserId = "4", BookId = 3 },
                new Wishlist { Id = 8, UserId = "4", BookId = 7 },
                new Wishlist { Id = 9, UserId = "5", BookId = 4 },
                new Wishlist { Id = 10, UserId = "5", BookId = 6 }
            });
        }

        public static void SeedGenres(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(new[]
            {
                new Genre { Id = 1, Name = "Fantasy", Description = "Жанр, у якому описуються вигадані світи, магія та неймовірні пригоди." },
                new Genre { Id = 2, Name = "Science Fiction", Description = "Розповіді про наукові відкриття, технології майбутнього та космічні подорожі." },
                new Genre { Id = 3, Name = "Thriller", Description = "Напружені історії, що тримають у постійній напрузі та часто мають несподівані повороти." },
                new Genre { Id = 4, Name = "Adventure", Description = "Книги про подорожі, небезпеки, випробування та мужність головних героїв." },
                new Genre { Id = 5, Name = "Mystery", Description = "Сюжети, побудовані навколо загадок, розслідувань і таємниць, які треба розкрити." }
            });
        }

        public static void SeedUsers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new[]
            {
                new User
                {
                    Id = "1",
                    UserName = "john.doe@library.com",
                    NormalizedUserName = "JOHN.DOE@LIBRARY.COM",
                    Email = "john.doe@library.com",
                    NormalizedEmail = "JOHN.DOE@LIBRARY.COM",
                    EmailConfirmed = true,
                    Country = "United States",
                    SecurityStamp = "SECURITY-STAMP-USER-1",
                    ConcurrencyStamp = "CONCURRENCY-STAMP-USER-1",
                    // Пароль: User123!
                    PasswordHash = "AQAAAAIAAYagAAAAEJL8xKzQ7TlP5x7xTqBvZxKl0J0YjhI8yMvL6xK3wQ5L2N3M4O5P6Q7R8S9T0U1V2W3X4Y5Z6A7B8C9D0E1F2G3H4I5J6K7L8M9N0O1P2Q3R4S5T6U7V8W9X0Y1Z2A3B4C5D6E7F8G9H0I1J2K3L4M5N6O7P8Q9R0S1T2U3V4W5X6Y7Z8A9B0="
                },
                new User
                {
                    Id = "2",
                    UserName = "maria.garcia@library.com",
                    NormalizedUserName = "MARIA.GARCIA@LIBRARY.COM",
                    Email = "maria.garcia@library.com",
                    NormalizedEmail = "MARIA.GARCIA@LIBRARY.COM",
                    EmailConfirmed = true,
                    Country = "Spain",
                    SecurityStamp = "SECURITY-STAMP-USER-2",
                    ConcurrencyStamp = "CONCURRENCY-STAMP-USER-2",
                    // Пароль: Library456@
                    PasswordHash = "AQAAAAIAAYagAAAAEMK9yLzR8UmQ6y8yUrCwZyLm1K1ZkiJ9zNwM7yL4xR6M3O4N5P6O7Q8R9S0T1U2V3W4X5Y6Z7A8B9C0D1E2F3G4H5I6J7K8L9M0N1O2P3Q4R5S6T7U8V9W0X1Y2Z3A4B5C6D7E8F9G0H1I2J3K4L5M6N7O8P9Q0R1S2T3U4V5W6X7Y8Z9A0B1C2D3E4F5G6H7I8J9K0L1M2N3O4P5Q6R7S8T9U0V1W2X3Y4Z5A6B7C8D9E0="
                },
                new User
                {
                    Id = "3",
                    UserName = "hans.mueller@library.com",
                    NormalizedUserName = "HANS.MUELLER@LIBRARY.COM",
                    Email = "hans.mueller@library.com",
                    NormalizedEmail = "HANS.MUELLER@LIBRARY.COM",
                    EmailConfirmed = true,
                    Country = "Germany",
                    SecurityStamp = "SECURITY-STAMP-USER-3",
                    ConcurrencyStamp = "CONCURRENCY-STAMP-USER-3",
                    // Пароль: User123!
                    PasswordHash = "AQAAAAIAAYagAAAAEJL8xKzQ7TlP5x7xTqBvZxKl0J0YjhI8yMvL6xK3wQ5L2N3M4O5P6Q7R8S9T0U1V2W3X4Y5Z6A7B8C9D0E1F2G3H4I5J6K7L8M9N0O1P2Q3R4S5T6U7V8W9X0Y1Z2A3B4C5D6E7F8G9H0I1J2K3L4M5N6O7P8Q9R0S1T2U3V4W5X6Y7Z8A9B0="
                },
                new User
                {
                    Id = "4",
                    UserName = "yuki.tanaka@library.com",
                    NormalizedUserName = "YUKI.TANAKA@LIBRARY.COM",
                    Email = "yuki.tanaka@library.com",
                    NormalizedEmail = "YUKI.TANAKA@LIBRARY.COM",
                    EmailConfirmed = true,
                    Country = "Japan",
                    SecurityStamp = "SECURITY-STAMP-USER-4",
                    ConcurrencyStamp = "CONCURRENCY-STAMP-USER-4",
                    // Пароль: Library456@
                    PasswordHash = "AQAAAAIAAYagAAAAEMK9yLzR8UmQ6y8yUrCwZyLm1K1ZkiJ9zNwM7yL4xR6M3O4N5P6O7Q8R9S0T1U2V3W4X5Y6Z7A8B9C0D1E2F3G4H5I6J7K8L9M0N1O2P3Q4R5S6T7U8V9W0X1Y2Z3A4B5C6D7E8F9G0H1I2J3K4L5M6N7O8P9Q0R1S2T3U4V5W6X7Y8Z9A0B1C2D3E4F5G6H7I8J9K0L1M2N3O4P5Q6R7S8T9U0V1W2X3Y4Z5A6B7C8D9E0="
                },
                new User
                {
                    Id = "5",
                    UserName = "pierre.dubois@library.com",
                    NormalizedUserName = "PIERRE.DUBOIS@LIBRARY.COM",
                    Email = "pierre.dubois@library.com",
                    NormalizedEmail = "PIERRE.DUBOIS@LIBRARY.COM",
                    EmailConfirmed = true,
                    Country = "France",
                    SecurityStamp = "SECURITY-STAMP-USER-5",
                    ConcurrencyStamp = "CONCURRENCY-STAMP-USER-5",
                    // Пароль: User123!
                    PasswordHash = "AQAAAAIAAYagAAAAEJL8xKzQ7TlP5x7xTqBvZxKl0J0YjhI8yMvL6xK3wQ5L2N3M4O5P6Q7R8S9T0U1V2W3X4Y5Z6A7B8C9D0E1F2G3H4I5J6K7L8M9N0O1P2Q3R4S5T6U7V8W9X0Y1Z2A3B4C5D6E7F8G9H0I1J2K3L4M5N6O7P8Q9R0S1T2U3V4W5X6Y7Z8A9B0="
                },
            });
        }
    }
}
