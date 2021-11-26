using Microsoft.EntityFrameworkCore.Migrations;

namespace Day12_13.Migrations
{
    public partial class spGetPlantsDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[GetPlantsDetails]
                    
                AS
                BEGIN
                    SET NOCOUNT ON;
                    select * from PlantsDetails
                END";

            migrationBuilder.Sql(sp);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
