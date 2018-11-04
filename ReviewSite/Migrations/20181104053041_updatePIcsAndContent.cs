using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewSite.Migrations
{
    public partial class updatePIcsAndContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Content", "ImageUrl", "Title" },
                values: new object[] { "Jeet jet? Jah wanna sammich N'at, then yinz better get dahntahn for this-un. I cut the sammiches half in two for yinz cuz Mills on Wills don't never bring halupki, haluski, or kolachis. It's a 'Burgh Thing! ", "/images/primantiBros.jpg", "Primanti Bothers" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Content", "ImageUrl", "Title" },
                values: new object[] { "If grease brings you gastronomic peace, then this dish should be your wish!", "/images/piggyLunch.jpg", "Triple ByPass Cheese Steak Deluxe from Mr. Burger" });
        }
    }
}
