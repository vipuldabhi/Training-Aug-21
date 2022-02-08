using Microsoft.EntityFrameworkCore.Migrations;

namespace Tiffin.Migrations
{
    public partial class foreignkeychange3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RestaurantId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "RestaurantId",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "RestaurantId",
                table: "MealCharges");

            migrationBuilder.AddColumn<int>(
                name: "RestaurantsId",
                table: "Menu",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IntervalId",
                table: "MealCharges",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "RestaurantsId",
                table: "MealCharges",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Menu_RestaurantsId",
                table: "Menu",
                column: "RestaurantsId");

            migrationBuilder.CreateIndex(
                name: "IX_MealCharges_IntervalId",
                table: "MealCharges",
                column: "IntervalId");

            migrationBuilder.CreateIndex(
                name: "IX_MealCharges_RestaurantsId",
                table: "MealCharges",
                column: "RestaurantsId");

            migrationBuilder.AddForeignKey(
                name: "FK_MealCharges_Interval_IntervalId",
                table: "MealCharges",
                column: "IntervalId",
                principalTable: "Interval",
                principalColumn: "IntervalId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MealCharges_Restaurants_RestaurantsId",
                table: "MealCharges",
                column: "RestaurantsId",
                principalTable: "Restaurants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Menu_Restaurants_RestaurantsId",
                table: "Menu",
                column: "RestaurantsId",
                principalTable: "Restaurants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MealCharges_Interval_IntervalId",
                table: "MealCharges");

            migrationBuilder.DropForeignKey(
                name: "FK_MealCharges_Restaurants_RestaurantsId",
                table: "MealCharges");

            migrationBuilder.DropForeignKey(
                name: "FK_Menu_Restaurants_RestaurantsId",
                table: "Menu");

            migrationBuilder.DropIndex(
                name: "IX_Menu_RestaurantsId",
                table: "Menu");

            migrationBuilder.DropIndex(
                name: "IX_MealCharges_IntervalId",
                table: "MealCharges");

            migrationBuilder.DropIndex(
                name: "IX_MealCharges_RestaurantsId",
                table: "MealCharges");

            migrationBuilder.DropColumn(
                name: "RestaurantsId",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "RestaurantsId",
                table: "MealCharges");

            migrationBuilder.AddColumn<int>(
                name: "RestaurantId",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RestaurantId",
                table: "Menu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "IntervalId",
                table: "MealCharges",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RestaurantId",
                table: "MealCharges",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
