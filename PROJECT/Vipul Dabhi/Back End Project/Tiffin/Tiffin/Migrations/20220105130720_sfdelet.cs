using Microsoft.EntityFrameworkCore.Migrations;

namespace Tiffin.Migrations
{
    public partial class sfdelet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RestaurantId",
                table: "OrderDetails",
                newName: "TotalAmmount");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Interval",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "DeliveryStatus",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CancellationStatus",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Interval");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "DeliveryStatus");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CancellationStatus");

            migrationBuilder.RenameColumn(
                name: "TotalAmmount",
                table: "OrderDetails",
                newName: "RestaurantId");
        }
    }
}
