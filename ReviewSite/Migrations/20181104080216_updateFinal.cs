using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewSite.Migrations
{
    public partial class updateFinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "Content",
                value: "Blue Eyed Soul, Rhythym and Blues from \"The PGH Rockers\" featuring the hits \"Darkest Side of Town\" and \"The Man Who Won The War\"");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "Content",
                value: "Blue Eyed Soul, Rhythym and Blues from \"The PGH Rockers\" ");
        }
    }
}
