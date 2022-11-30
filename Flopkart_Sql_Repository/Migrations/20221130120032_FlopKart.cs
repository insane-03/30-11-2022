using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlopkartSqlRepository.Migrations
{
    /// <inheritdoc />
    public partial class FlopKart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SqlProducts",
                columns: table => new
                {
                    ProductName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SqlProducts", x => x.ProductName);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SqlProducts");
        }
    }
}
