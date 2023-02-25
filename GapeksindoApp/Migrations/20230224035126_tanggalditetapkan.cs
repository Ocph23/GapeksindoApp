using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GapeksindoApp.Migrations
{
    /// <inheritdoc />
    public partial class tanggalditetapkan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "TanggalDitetapkan",
                table: "Permohonans",
                type: "datetime(6)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TanggalDitetapkan",
                table: "Permohonans");
        }
    }
}
