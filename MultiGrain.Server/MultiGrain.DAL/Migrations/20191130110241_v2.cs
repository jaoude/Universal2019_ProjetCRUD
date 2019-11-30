using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiGrain.DAL.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Catalog_Year_YearId",
                table: "Catalog");

            migrationBuilder.DropIndex(
                name: "IX_Catalog_YearId",
                table: "Catalog");

            migrationBuilder.DropColumn(
                name: "YearId",
                table: "Catalog");

            migrationBuilder.AddColumn<int>(
                name: "CatalogId",
                table: "Year",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RequiredBy",
                table: "TeachingUnit",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Year_CatalogId",
                table: "Year",
                column: "CatalogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Year_Catalog_CatalogId",
                table: "Year",
                column: "CatalogId",
                principalTable: "Catalog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Year_Catalog_CatalogId",
                table: "Year");

            migrationBuilder.DropIndex(
                name: "IX_Year_CatalogId",
                table: "Year");

            migrationBuilder.DropColumn(
                name: "CatalogId",
                table: "Year");

            migrationBuilder.AlterColumn<int>(
                name: "RequiredBy",
                table: "TeachingUnit",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "YearId",
                table: "Catalog",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Catalog_YearId",
                table: "Catalog",
                column: "YearId");

            migrationBuilder.AddForeignKey(
                name: "FK_Catalog_Year_YearId",
                table: "Catalog",
                column: "YearId",
                principalTable: "Year",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
