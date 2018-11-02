using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewSite.Migrations
{
    public partial class _201811020014hrs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "Title" },
                values: new object[] { "Hard Rain rocked the house to a sold out crowd Friday August 10th, 2018 ", "Hard Rain at MusicBox Supper Club" });

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
                keyValue: 4,
                columns: new[] { "Content", "ImageUrl" },
                values: new object[] { "Blue Eyed Soul, Rhythym and Blues from \"The PGH Rockers\" ", "/images/deepInTheShadowsAlbum.jpg" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "Title" },
                values: new object[] { "/images/piggyLunch.jpg", "Triple ByPass Cheese Steak Deluxe from Mr. Burger" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "Title" },
                values: new object[] { "Hard Rain rocked the house to a sold out crowd Friday 10-19-18", "Hard Rain at Natalies Coal Fired Pizza" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "./www.root/images/bookcover.jpg");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "./www.root/images/bookcover.jpg");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Content", "ImageUrl" },
                values: new object[] { "Blue Eyed Soul, Rythem and Blues from \"The PGH Rockers\" ", "./www.root/images/album.jpg" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "Title" },
                values: new object[] { "./www.root/images/piggyLunch.jpg", " Double Philly Cheese Steak Deluxe from Mr. Hero" });
        }
    }
}
