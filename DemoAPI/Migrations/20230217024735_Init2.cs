using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DemoAPI.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "description", "name", "price", "quantity" },
                values: new object[,]
                {
                    { 1, "All kinds of books related to business and investing: management, finance, entrepreneurs, startup, skills, sales, etc", "Business & Economics", 23000, 300 },
                    { 2, "All kinds of books for children to learn, entertain and have fun such as graphic books, children stories, fairy tales, comics, etc.", "Children's Books", 240000, 20 },
                    { 3, "Fictions, novels, chicklit, poem and more", "Fiction - Literature", 20000, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
