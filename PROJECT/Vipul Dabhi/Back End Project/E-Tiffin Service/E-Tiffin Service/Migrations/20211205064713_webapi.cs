using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Tiffin_Service.Migrations
{
    public partial class webapi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactInfo",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ContactNo = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    Subject = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Message = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    IsSolve = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "FridayDinnerMenu",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__FridayDi__727E838B038E88E2", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "FridayLunchMenu",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__FridayLu__727E838B814023EC", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "MondayDinnerMenu",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MondayDi__727E838B495B93A1", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "MondayLunchMenu",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MondayLu__727E838BE8C27D70", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MobileNo = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    Area = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TiffinTime = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TiffinType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TiffinPlan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Extra = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__OrderDet__C3905BCF5FEB492B", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "SaturdayDinnerMenu",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Saturday__727E838B12FD2CD4", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "SaturdayLunchMenu",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Saturday__727E838B1842E485", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "SundayDinnerMenu",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SundayDi__727E838BD146E777", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "SundayLunchMenu",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SundayLu__727E838BBCD08622", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "ThursdayDinnerMenu",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Thursday__727E838B1B797EB4", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "ThursdayLunchMenu",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Thursday__727E838BF159AD09", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "TuesdayDinnerMenu",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TuesdayD__727E838B3517EA1C", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "TuesdayLunchMenu",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TuesdayL__727E838B75CCF279", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "WednesdayDinnerMenu",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Wednesda__727E838B5A71795B", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "WednesdayLunchMenu",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Wednesda__727E838B01B2AF9A", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "CancellationStatus",
                columns: table => new
                {
                    CancellationId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Lunch = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "('false')"),
                    Dinner = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "('false')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Cancella__6A2D9A3A22110A49", x => x.CancellationId);
                    table.ForeignKey(
                        name: "FK__Cancellat__Order__7B5B524B",
                        column: x => x.OrderId,
                        principalTable: "OrderDetails",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryStatus",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Lunch = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "('false')"),
                    Dinner = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "('false')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Delivery__C3905BCFA90050D2", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK__DeliveryS__Order__6E01572D",
                        column: x => x.OrderId,
                        principalTable: "OrderDetails",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymentStatus",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "('Pending')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PaymentS__9B556A38A6087ABE", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK__PaymentSt__Order__76969D2E",
                        column: x => x.OrderId,
                        principalTable: "OrderDetails",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CancellationStatus_OrderId",
                table: "CancellationStatus",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentStatus_OrderId",
                table: "PaymentStatus",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CancellationStatus");

            migrationBuilder.DropTable(
                name: "ContactInfo");

            migrationBuilder.DropTable(
                name: "DeliveryStatus");

            migrationBuilder.DropTable(
                name: "FridayDinnerMenu");

            migrationBuilder.DropTable(
                name: "FridayLunchMenu");

            migrationBuilder.DropTable(
                name: "MondayDinnerMenu");

            migrationBuilder.DropTable(
                name: "MondayLunchMenu");

            migrationBuilder.DropTable(
                name: "PaymentStatus");

            migrationBuilder.DropTable(
                name: "SaturdayDinnerMenu");

            migrationBuilder.DropTable(
                name: "SaturdayLunchMenu");

            migrationBuilder.DropTable(
                name: "SundayDinnerMenu");

            migrationBuilder.DropTable(
                name: "SundayLunchMenu");

            migrationBuilder.DropTable(
                name: "ThursdayDinnerMenu");

            migrationBuilder.DropTable(
                name: "ThursdayLunchMenu");

            migrationBuilder.DropTable(
                name: "TuesdayDinnerMenu");

            migrationBuilder.DropTable(
                name: "TuesdayLunchMenu");

            migrationBuilder.DropTable(
                name: "WednesdayDinnerMenu");

            migrationBuilder.DropTable(
                name: "WednesdayLunchMenu");

            migrationBuilder.DropTable(
                name: "OrderDetails");
        }
    }
}
