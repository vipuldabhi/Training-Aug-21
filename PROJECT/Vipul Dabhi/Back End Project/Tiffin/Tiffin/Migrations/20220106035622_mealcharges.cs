using Microsoft.EntityFrameworkCore.Migrations;

namespace Tiffin.Migrations
{
    public partial class mealcharges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalAmmount",
                table: "OrderDetails",
                newName: "ChargeId");

            migrationBuilder.CreateTable(
                name: "MealCharges",
                columns: table => new
                {
                    ChargeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    IntervalId = table.Column<int>(type: "int", nullable: false),
                    Charge = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealCharges", x => x.ChargeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MealCharges");

            migrationBuilder.RenameColumn(
                name: "ChargeId",
                table: "OrderDetails",
                newName: "TotalAmmount");
        }
    }
}
