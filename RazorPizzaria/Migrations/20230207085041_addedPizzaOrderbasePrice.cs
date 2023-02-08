using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPizzaria.Migrations
{
    /// <inheritdoc />
    public partial class addedPizzaOrderbasePrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "BasePrice",
                table: "PizzaOrders",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BasePrice",
                table: "PizzaOrders");
        }
    }
}
