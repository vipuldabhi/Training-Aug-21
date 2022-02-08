using Microsoft.EntityFrameworkCore.Migrations;

namespace Tiffin.Migrations
{
    public partial class foreignkeychange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Restaurants_RestaurantsRestaurantId",
                table: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "RestaurantId",
                table: "Restaurants",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RestaurantsRestaurantId",
                table: "OrderDetails",
                newName: "RestaurantsId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_RestaurantsRestaurantId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_RestaurantsId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Restaurants_RestaurantsId",
                table: "OrderDetails",
                column: "RestaurantsId",
                principalTable: "Restaurants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Restaurants_RestaurantsId",
                table: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Restaurants",
                newName: "RestaurantId");

            migrationBuilder.RenameColumn(
                name: "RestaurantsId",
                table: "OrderDetails",
                newName: "RestaurantsRestaurantId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_RestaurantsId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_RestaurantsRestaurantId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Restaurants_RestaurantsRestaurantId",
                table: "OrderDetails",
                column: "RestaurantsRestaurantId",
                principalTable: "Restaurants",
                principalColumn: "RestaurantId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
