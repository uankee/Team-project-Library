using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CoverImage",
                value: "https://m.media-amazon.com/images/I/410qtwm57cL._AC_UF1000%2C1000_QL80_.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CoverImage",
                value: "https://m.media-amazon.com/images/I/81%2BSDwFNDyL._AC_UF1000%2C1000_QL80_.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "CoverImage",
                value: "https://www.hachette.com.au/content/books/9781472112699.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "CoverImage",
                value: "chttps://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1673020125i/72404657.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "CoverImage",
                value: "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1699208745i/201610825.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "CoverImage",
                value: "https://m.media-amazon.com/images/I/71hi9RNaieL.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "CoverImage",
                value: "https://naasr.org/cdn/shop/products/WindsofDestinylg_1200x1200.jpg?v=1661464372");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "CoverImage",
                value: "https://m.media-amazon.com/images/I/91CBdKf3gpL._UF1000%2C1000_QL80_.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "CoverImage",
                value: "https://images.thalia.media/07/-/050ad87e2bc9463e8ac4656f54f9683d/avatar-legends-city-of-echoes-avatar-legends-book-1-gebundene-ausgabe-judy-i-lin-englisch.jpeg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "CoverImage",
                value: "https://m.media-amazon.com/images/I/71NscVJhd6L._AC_UF1000%2C1000_QL80_.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CoverImage",
                value: "covers/silent_library.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CoverImage",
                value: "covers/echoes_of_time.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "CoverImage",
                value: "covers/whispers_dark.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "CoverImage",
                value: "covers/beyond_horizon.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "CoverImage",
                value: "covers/lost_kingdom.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "CoverImage",
                value: "covers/shadows_mind.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "CoverImage",
                value: "covers/winds_destiny.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "CoverImage",
                value: "covers/fragments_tomorrow.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "CoverImage",
                value: "covers/city_echoes.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "CoverImage",
                value: "covers/forgotten_path.jpg");
        }
    }
}
