using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GapeksindoApp.Migrations
{
    /// <inheritdoc />
    public partial class _validatedatapersyaratan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Keterangan",
                table: "Persyaratans",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Keterangan",
                table: "Kualifikasis",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "Validate",
                table: "DataPersyaratan",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Validate",
                table: "DataPersyaratan");

            migrationBuilder.UpdateData(
                table: "Persyaratans",
                keyColumn: "Keterangan",
                keyValue: null,
                column: "Keterangan",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Keterangan",
                table: "Persyaratans",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Kualifikasis",
                keyColumn: "Keterangan",
                keyValue: null,
                column: "Keterangan",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Keterangan",
                table: "Kualifikasis",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
