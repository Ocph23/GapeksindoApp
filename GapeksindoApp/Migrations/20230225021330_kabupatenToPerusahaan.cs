using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GapeksindoApp.Migrations
{
    /// <inheritdoc />
    public partial class kabupatenToPerusahaan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KabupatenId",
                table: "Perusahaans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Perusahaans_KabupatenId",
                table: "Perusahaans",
                column: "KabupatenId");

            migrationBuilder.AddForeignKey(
                name: "FK_Perusahaans_Kabupatens_KabupatenId",
                table: "Perusahaans",
                column: "KabupatenId",
                principalTable: "Kabupatens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Perusahaans_Kabupatens_KabupatenId",
                table: "Perusahaans");

            migrationBuilder.DropIndex(
                name: "IX_Perusahaans_KabupatenId",
                table: "Perusahaans");

            migrationBuilder.DropColumn(
                name: "KabupatenId",
                table: "Perusahaans");
        }
    }
}
