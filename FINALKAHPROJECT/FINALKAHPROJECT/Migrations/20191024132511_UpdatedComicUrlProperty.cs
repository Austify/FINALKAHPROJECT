using Microsoft.EntityFrameworkCore.Migrations;

namespace FINALKAHPROJECT.Migrations
{
    public partial class UpdatedComicUrlProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ComicImage",
                table: "comic",
                newName: "ComicImageUrl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ComicImageUrl",
                table: "comic",
                newName: "ComicImage");
        }
    }
}
