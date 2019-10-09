using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiGrain.DAL.Migrations
{
    public partial class Add_FileDocument_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "FileDocument",
                newName: "FileName");

            migrationBuilder.AddColumn<string>(
                name: "ContentType",
                table: "FileDocument",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContentType",
                table: "FileDocument");

            migrationBuilder.RenameColumn(
                name: "FileName",
                table: "FileDocument",
                newName: "Name");
        }
    }
}
