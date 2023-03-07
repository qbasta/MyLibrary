using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyLibrary.Data.Migrations
{
    /// <inheritdoc />
    public partial class BookModelChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Book");
        }
    }
}
