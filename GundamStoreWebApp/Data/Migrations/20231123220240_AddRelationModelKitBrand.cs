using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GundamStoreWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationModelKitBrand : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BrandID",
                table: "ModelKit",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ModelKit_BrandID",
                table: "ModelKit",
                column: "BrandID");

            migrationBuilder.AddForeignKey(
                name: "FK_ModelKit_Brand_BrandID",
                table: "ModelKit",
                column: "BrandID",
                principalTable: "Brand",
                principalColumn: "BrandID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModelKit_Brand_BrandID",
                table: "ModelKit");

            migrationBuilder.DropIndex(
                name: "IX_ModelKit_BrandID",
                table: "ModelKit");

            migrationBuilder.DropColumn(
                name: "BrandID",
                table: "ModelKit");
        }
    }
}
