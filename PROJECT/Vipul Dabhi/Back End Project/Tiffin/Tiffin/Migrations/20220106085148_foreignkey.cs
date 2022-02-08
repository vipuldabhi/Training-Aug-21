using Microsoft.EntityFrameworkCore.Migrations;

namespace Tiffin.Migrations
{
    public partial class foreignkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ChargeId",
                table: "OrderDetails",
                newName: "TotalCharge");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "OrderDetails",
                type: "bit",
                nullable: false,
                defaultValueSql: "((0))",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValueSql: "((0))");

            migrationBuilder.AddColumn<int>(
                name: "RestaurantsRestaurantId",
                table: "OrderDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_RestaurantsRestaurantId",
                table: "OrderDetails",
                column: "RestaurantsRestaurantId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Restaurants_RestaurantsRestaurantId",
                table: "OrderDetails",
                column: "RestaurantsRestaurantId",
                principalTable: "Restaurants",
                principalColumn: "RestaurantId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Restaurants_RestaurantsRestaurantId",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_RestaurantsRestaurantId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "RestaurantsRestaurantId",
                table: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "TotalCharge",
                table: "OrderDetails",
                newName: "ChargeId");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "OrderDetails",
                type: "bit",
                nullable: true,
                defaultValueSql: "((0))",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "((0))");
        }
    }
}
