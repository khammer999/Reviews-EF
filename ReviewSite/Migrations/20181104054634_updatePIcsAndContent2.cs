using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewSite.Migrations
{
    public partial class updatePIcsAndContent2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "/images/redOctober.jpg");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "/images/ofMiceAndMen.jpg");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "Content",
                value: "Jeet jet? Jah wanna sammich N'at? then yinz better get dahntahn for this-un. I cut the sammiches half in two for yinz cuz Mills on Wills don't never bring halupki, haluski, or kolachis. It's a 'Burgh Thing!");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "/images/bookcover.jpg");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "/images/bookcover.jpg");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "Content",
                value: "Jeet jet?, If yer nebbin fura sammich N'at, then yinz better get dahntown for this-un. I cut the sammiches half in two for yinz cuz Mills on Wills don't never bring halupki, haluski, or kolachis. ");
        }
    }
}
