using Microsoft.EntityFrameworkCore.Migrations;

namespace FINALKAHPROJECT.Migrations
{
    public partial class UpdateComic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "comic",
                newName: "ComicImage");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ComicImage",
                table: "comic",
                newName: "Image");
        }
    }
}
