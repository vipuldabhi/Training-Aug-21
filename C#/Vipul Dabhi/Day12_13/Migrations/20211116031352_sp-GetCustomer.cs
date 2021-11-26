using Microsoft.EntityFrameworkCore.Migrations;

namespace Day12_13.Migrations
{
    public partial class spGetCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[GetCustomer]
                    
                AS
                BEGIN
                    SET NOCOUNT ON;
                    select * from CustomerDetails
                END";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
