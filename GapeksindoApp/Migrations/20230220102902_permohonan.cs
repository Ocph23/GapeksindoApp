using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GapeksindoApp.Migrations
{
    /// <inheritdoc />
    public partial class permohonan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Keterangan",
                table: "Permohonans",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Nomor",
                table: "Permohonans",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Permohonans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PermohonanId",
                table: "Kualifikasis",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DataPersyaratan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PersyaratanId = table.Column<int>(type: "int", nullable: false),
                    FileNama = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PermohonanId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataPersyaratan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataPersyaratan_Permohonans_PermohonanId",
                        column: x => x.PermohonanId,
                        principalTable: "Permohonans",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DataPersyaratan_Persyaratans_PersyaratanId",
                        column: x => x.PersyaratanId,
                        principalTable: "Persyaratans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Kualifikasis_PermohonanId",
                table: "Kualifikasis",
                column: "PermohonanId");

            migrationBuilder.CreateIndex(
                name: "IX_DataPersyaratan_PermohonanId",
                table: "DataPersyaratan",
                column: "PermohonanId");

            migrationBuilder.CreateIndex(
                name: "IX_DataPersyaratan_PersyaratanId",
                table: "DataPersyaratan",
                column: "PersyaratanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kualifikasis_Permohonans_PermohonanId",
                table: "Kualifikasis",
                column: "PermohonanId",
                principalTable: "Permohonans",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kualifikasis_Permohonans_PermohonanId",
                table: "Kualifikasis");

            migrationBuilder.DropTable(
                name: "DataPersyaratan");

            migrationBuilder.DropIndex(
                name: "IX_Kualifikasis_PermohonanId",
                table: "Kualifikasis");

            migrationBuilder.DropColumn(
                name: "Keterangan",
                table: "Permohonans");

            migrationBuilder.DropColumn(
                name: "Nomor",
                table: "Permohonans");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Permohonans");

            migrationBuilder.DropColumn(
                name: "PermohonanId",
                table: "Kualifikasis");
        }
    }
}
