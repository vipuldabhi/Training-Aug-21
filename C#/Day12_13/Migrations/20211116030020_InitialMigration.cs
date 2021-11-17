using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Day12_13.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderID);
                });

            migrationBuilder.CreateTable(
                name: "PlantsDetails",
                columns: table => new
                {
                    PlantID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlantName = table.Column<string>(nullable: true),
                    PlantAddress = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantsDetails", x => x.PlantID);
                });

            migrationBuilder.CreateTable(
                name: "CustomerDetails",
                columns: table => new
                {
                    CustomerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(nullable: true),
                    CustomerAddress = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    OrderDetailsOrderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerDetails", x => x.CustomerID);
                    table.ForeignKey(
                        name: "FK_CustomerDetails_OrderDetails_OrderDetailsOrderID",
                        column: x => x.OrderDetailsOrderID,
                        principalTable: "OrderDetails",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ToyCatageory",
                columns: table => new
                {
                    CatageoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategeoryName = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    PlantsDetailsPlantID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToyCatageory", x => x.CatageoryID);
                    table.ForeignKey(
                        name: "FK_ToyCatageory_PlantsDetails_PlantsDetailsPlantID",
                        column: x => x.PlantsDetailsPlantID,
                        principalTable: "PlantsDetails",
                        principalColumn: "PlantID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ToysDetails",
                columns: table => new
                {
                    ToyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ToyName = table.Column<string>(nullable: true),
                    ToyPrice = table.Column<int>(nullable: false),
                    ManufactureDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    OrderDetailsOrderID = table.Column<int>(nullable: true),
                    PlantsDetailsPlantID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToysDetails", x => x.ToyID);
                    table.ForeignKey(
                        name: "FK_ToysDetails_OrderDetails_OrderDetailsOrderID",
                        column: x => x.OrderDetailsOrderID,
                        principalTable: "OrderDetails",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ToysDetails_PlantsDetails_PlantsDetailsPlantID",
                        column: x => x.PlantsDetailsPlantID,
                        principalTable: "PlantsDetails",
                        principalColumn: "PlantID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerDetails_OrderDetailsOrderID",
                table: "CustomerDetails",
                column: "OrderDetailsOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_ToyCatageory_PlantsDetailsPlantID",
                table: "ToyCatageory",
                column: "PlantsDetailsPlantID");

            migrationBuilder.CreateIndex(
                name: "IX_ToysDetails_OrderDetailsOrderID",
                table: "ToysDetails",
                column: "OrderDetailsOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_ToysDetails_PlantsDetailsPlantID",
                table: "ToysDetails",
                column: "PlantsDetailsPlantID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerDetails");

            migrationBuilder.DropTable(
                name: "ToyCatageory");

            migrationBuilder.DropTable(
                name: "ToysDetails");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "PlantsDetails");
        }
    }
}
