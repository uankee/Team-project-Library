using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SmallSeedBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "CoverImage",
                value: "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1673020125i/72404657.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "CoverImage",
                value: "chttps://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1673020125i/72404657.jpg");
        }
    }
}
