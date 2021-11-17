using Microsoft.EntityFrameworkCore.Migrations;

namespace Day12_13.Migrations
{
    public partial class spGetToysDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[GetToysDetails]
                    
                AS
                BEGIN
                    SET NOCOUNT ON;
                    select * from ToysDetails
                END";

            migrationBuilder.Sql(sp);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
