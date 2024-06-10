using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace İntProgOdev.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblOgrenciDersler_tblDersler_Dersid",
                table: "tblOgrenciDersler");

            migrationBuilder.DropForeignKey(
                name: "FK_tblOgrenciDersler_tblOgrenciler_Ogrenciid",
                table: "tblOgrenciDersler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblOgrenciler",
                table: "tblOgrenciler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblOgrenciDersler",
                table: "tblOgrenciDersler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblDersler",
                table: "tblDersler");

            migrationBuilder.RenameTable(
                name: "tblOgrenciler",
                newName: "tblOgrencilerNew");

            migrationBuilder.RenameTable(
                name: "tblOgrenciDersler",
                newName: "tblOgrenciDerslerNew");

            migrationBuilder.RenameTable(
                name: "tblDersler",
                newName: "tblDerslerNew");

            migrationBuilder.RenameIndex(
                name: "IX_tblOgrenciDersler_Dersid",
                table: "tblOgrenciDerslerNew",
                newName: "IX_tblOgrenciDerslerNew_Dersid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblOgrencilerNew",
                table: "tblOgrencilerNew",
                column: "Ogrenciid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblOgrenciDerslerNew",
                table: "tblOgrenciDerslerNew",
                columns: new[] { "Ogrenciid", "Dersid" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblDerslerNew",
                table: "tblDerslerNew",
                column: "Dersid");

            migrationBuilder.AddForeignKey(
                name: "FK_tblOgrenciDerslerNew_tblDerslerNew_Dersid",
                table: "tblOgrenciDerslerNew",
                column: "Dersid",
                principalTable: "tblDerslerNew",
                principalColumn: "Dersid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblOgrenciDerslerNew_tblOgrencilerNew_Ogrenciid",
                table: "tblOgrenciDerslerNew",
                column: "Ogrenciid",
                principalTable: "tblOgrencilerNew",
                principalColumn: "Ogrenciid",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblOgrenciDerslerNew_tblDerslerNew_Dersid",
                table: "tblOgrenciDerslerNew");

            migrationBuilder.DropForeignKey(
                name: "FK_tblOgrenciDerslerNew_tblOgrencilerNew_Ogrenciid",
                table: "tblOgrenciDerslerNew");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblOgrencilerNew",
                table: "tblOgrencilerNew");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblOgrenciDerslerNew",
                table: "tblOgrenciDerslerNew");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblDerslerNew",
                table: "tblDerslerNew");

            migrationBuilder.RenameTable(
                name: "tblOgrencilerNew",
                newName: "tblOgrenciler");

            migrationBuilder.RenameTable(
                name: "tblOgrenciDerslerNew",
                newName: "tblOgrenciDersler");

            migrationBuilder.RenameTable(
                name: "tblDerslerNew",
                newName: "tblDersler");

            migrationBuilder.RenameIndex(
                name: "IX_tblOgrenciDerslerNew_Dersid",
                table: "tblOgrenciDersler",
                newName: "IX_tblOgrenciDersler_Dersid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblOgrenciler",
                table: "tblOgrenciler",
                column: "Ogrenciid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblOgrenciDersler",
                table: "tblOgrenciDersler",
                columns: new[] { "Ogrenciid", "Dersid" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblDersler",
                table: "tblDersler",
                column: "Dersid");

            migrationBuilder.AddForeignKey(
                name: "FK_tblOgrenciDersler_tblDersler_Dersid",
                table: "tblOgrenciDersler",
                column: "Dersid",
                principalTable: "tblDersler",
                principalColumn: "Dersid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblOgrenciDersler_tblOgrenciler_Ogrenciid",
                table: "tblOgrenciDersler",
                column: "Ogrenciid",
                principalTable: "tblOgrenciler",
                principalColumn: "Ogrenciid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
