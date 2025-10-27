using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoverImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublishedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AvailableCopies = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Borrows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BorrowedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Borrows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Borrows_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Borrows_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wishlists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wishlists_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wishlists_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "CONCURRENCY-STAMP-USER-1", "United States", "john.doe@library.com", true, false, null, "JOHN.DOE@LIBRARY.COM", "JOHN.DOE@LIBRARY.COM", "AQAAAAIAAYagAAAAEJL8xKzQ7TlP5x7xTqBvZxKl0J0YjhI8yMvL6xK3wQ5L2N3M4O5P6Q7R8S9T0U1V2W3X4Y5Z6A7B8C9D0E1F2G3H4I5J6K7L8M9N0O1P2Q3R4S5T6U7V8W9X0Y1Z2A3B4C5D6E7F8G9H0I1J2K3L4M5N6O7P8Q9R0S1T2U3V4W5X6Y7Z8A9B0=", null, false, "SECURITY-STAMP-USER-1", false, "john.doe@library.com" },
                    { "2", 0, "CONCURRENCY-STAMP-USER-2", "Spain", "maria.garcia@library.com", true, false, null, "MARIA.GARCIA@LIBRARY.COM", "MARIA.GARCIA@LIBRARY.COM", "AQAAAAIAAYagAAAAEMK9yLzR8UmQ6y8yUrCwZyLm1K1ZkiJ9zNwM7yL4xR6M3O4N5P6O7Q8R9S0T1U2V3W4X5Y6Z7A8B9C0D1E2F3G4H5I6J7K8L9M0N1O2P3Q4R5S6T7U8V9W0X1Y2Z3A4B5C6D7E8F9G0H1I2J3K4L5M6N7O8P9Q0R1S2T3U4V5W6X7Y8Z9A0B1C2D3E4F5G6H7I8J9K0L1M2N3O4P5Q6R7S8T9U0V1W2X3Y4Z5A6B7C8D9E0=", null, false, "SECURITY-STAMP-USER-2", false, "maria.garcia@library.com" },
                    { "3", 0, "CONCURRENCY-STAMP-USER-3", "Germany", "hans.mueller@library.com", true, false, null, "HANS.MUELLER@LIBRARY.COM", "HANS.MUELLER@LIBRARY.COM", "AQAAAAIAAYagAAAAEJL8xKzQ7TlP5x7xTqBvZxKl0J0YjhI8yMvL6xK3wQ5L2N3M4O5P6Q7R8S9T0U1V2W3X4Y5Z6A7B8C9D0E1F2G3H4I5J6K7L8M9N0O1P2Q3R4S5T6U7V8W9X0Y1Z2A3B4C5D6E7F8G9H0I1J2K3L4M5N6O7P8Q9R0S1T2U3V4W5X6Y7Z8A9B0=", null, false, "SECURITY-STAMP-USER-3", false, "hans.mueller@library.com" },
                    { "4", 0, "CONCURRENCY-STAMP-USER-4", "Japan", "yuki.tanaka@library.com", true, false, null, "YUKI.TANAKA@LIBRARY.COM", "YUKI.TANAKA@LIBRARY.COM", "AQAAAAIAAYagAAAAEMK9yLzR8UmQ6y8yUrCwZyLm1K1ZkiJ9zNwM7yL4xR6M3O4N5P6O7Q8R9S0T1U2V3W4X5Y6Z7A8B9C0D1E2F3G4H5I6J7K8L9M0N1O2P3Q4R5S6T7U8V9W0X1Y2Z3A4B5C6D7E8F9G0H1I2J3K4L5M6N7O8P9Q0R1S2T3U4V5W6X7Y8Z9A0B1C2D3E4F5G6H7I8J9K0L1M2N3O4P5Q6R7S8T9U0V1W2X3Y4Z5A6B7C8D9E0=", null, false, "SECURITY-STAMP-USER-4", false, "yuki.tanaka@library.com" },
                    { "5", 0, "CONCURRENCY-STAMP-USER-5", "France", "pierre.dubois@library.com", true, false, null, "PIERRE.DUBOIS@LIBRARY.COM", "PIERRE.DUBOIS@LIBRARY.COM", "AQAAAAIAAYagAAAAEJL8xKzQ7TlP5x7xTqBvZxKl0J0YjhI8yMvL6xK3wQ5L2N3M4O5P6Q7R8S9T0U1V2W3X4Y5Z6A7B8C9D0E1F2G3H4I5J6K7L8M9N0O1P2Q3R4S5T6U7V8W9X0Y1Z2A3B4C5D6E7F8G9H0I1J2K3L4M5N6O7P8Q9R0S1T2U3V4W5X6Y7Z8A9B0=", null, false, "SECURITY-STAMP-USER-5", false, "pierre.dubois@library.com" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Bio", "Name" },
                values: new object[,]
                {
                    { 1, "Emily Carter — сучасна британська письменниця, відома своїми психологічними романами та творами з глибоким емоційним змістом.", "Emily Carter" },
                    { 2, "James Thornton — американський автор наукової фантастики, який поєднує технологічні теми з філософськими питаннями майбутнього.", "James Thornton" },
                    { 3, "Sophia Alvarez — іспанська письменниця, що спеціалізується на трилерах та детективах із сильними жіночими персонажами.", "Sophia Alvarez" },
                    { 4, "Liam O’Connor — ірландський автор пригодницьких романів, натхненних історією та міфологією своєї батьківщини.", "Liam O’Connor" },
                    { 5, "Ava Bennett — канадська письменниця, відома своїми фентезійними циклами про світ магії, природи та давніх цивілізацій.", "Ava Bennett" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Жанр, у якому описуються вигадані світи, магія та неймовірні пригоди.", "Fantasy" },
                    { 2, "Розповіді про наукові відкриття, технології майбутнього та космічні подорожі.", "Science Fiction" },
                    { 3, "Напружені історії, що тримають у постійній напрузі та часто мають несподівані повороти.", "Thriller" },
                    { 4, "Книги про подорожі, небезпеки, випробування та мужність головних героїв.", "Adventure" },
                    { 5, "Сюжети, побудовані навколо загадок, розслідувань і таємниць, які треба розкрити.", "Mystery" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "AvailableCopies", "CoverImage", "GenreId", "PublishedDate", "Title" },
                values: new object[,]
                {
                    { 1, 1, 5, "covers/silent_library.jpg", 1, new DateTime(2015, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Silent Library" },
                    { 2, 2, 8, "covers/echoes_of_time.jpg", 2, new DateTime(2018, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Echoes of Time" },
                    { 3, 3, 3, "covers/whispers_dark.jpg", 3, new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Whispers in the Dark" },
                    { 4, 4, 6, "covers/beyond_horizon.jpg", 4, new DateTime(2017, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beyond the Horizon" },
                    { 5, 5, 7, "covers/lost_kingdom.jpg", 1, new DateTime(2016, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lost Kingdom" },
                    { 6, 2, 4, "covers/shadows_mind.jpg", 2, new DateTime(2019, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shadows of the Mind" },
                    { 7, 1, 9, "covers/winds_destiny.jpg", 5, new DateTime(2014, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Winds of Destiny" },
                    { 8, 3, 2, "covers/fragments_tomorrow.jpg", 3, new DateTime(2021, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fragments of Tomorrow" },
                    { 9, 4, 10, "covers/city_echoes.jpg", 4, new DateTime(2022, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "City of Echoes" },
                    { 10, 5, 5, "covers/forgotten_path.jpg", 5, new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Forgotten Path" }
                });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "Id", "BookId", "BorrowedAt", "DueDate", "ReturnedAt", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "1" },
                    { 2, 2, new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "2" },
                    { 3, 3, new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "3" },
                    { 4, 4, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "4" },
                    { 5, 5, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "5" },
                    { 6, 6, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "2" },
                    { 7, 7, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "3" },
                    { 8, 8, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "4" },
                    { 9, 9, new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "1" },
                    { 10, 10, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "5" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "BookId", "Comment", "CreatedAt", "Rating", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "Дуже захоплююча історія, не міг відірватися до самого кінця!", new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9000000000000004, "1" },
                    { 2, 2, "Цікаві персонажі, але середина трохи затягнута.", new DateTime(2023, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2000000000000002, "2" },
                    { 3, 3, "Неймовірна атмосфера, напруга сюжету передана ідеально.", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2999999999999998, "3" },
                    { 4, 4, "Добре написано, але фінал залишив багато питань.", new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5, "4" },
                    { 5, 5, "Сподобався світ і персонажі, трохи бракувало динаміки.", new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7000000000000002, "5" },
                    { 6, 6, "Чудова книга, змусила замислитися над багатьма речами.", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.0999999999999996, "2" },
                    { 7, 7, "Гарний сюжет і стиль, але хотілося б більше глибини у героях.", new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2000000000000002, "1" },
                    { 8, 8, "Фантастичний сюжет! Дуже емоційно та потужно.", new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7000000000000002, "3" },
                    { 9, 9, "Місцями нуднувато, але кінець компенсує усе.", new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1000000000000001, "4" },
                    { 10, 10, "Просто шедевр! Обов’язково перечитаю ще раз.", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.7999999999999998, "5" }
                });

            migrationBuilder.InsertData(
                table: "Wishlists",
                columns: new[] { "Id", "BookId", "UserId" },
                values: new object[,]
                {
                    { 1, 5, "1" },
                    { 2, 9, "1" },
                    { 3, 1, "2" },
                    { 4, 8, "2" },
                    { 5, 2, "3" },
                    { 6, 10, "3" },
                    { 7, 3, "4" },
                    { 8, 7, "4" },
                    { 9, 4, "5" },
                    { 10, 6, "5" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreId",
                table: "Books",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Borrows_BookId",
                table: "Borrows",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Borrows_UserId",
                table: "Borrows",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BookId",
                table: "Reviews",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlists_BookId",
                table: "Wishlists",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlists_UserId",
                table: "Wishlists",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Borrows");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Wishlists");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
