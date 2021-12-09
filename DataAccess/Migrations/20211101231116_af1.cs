using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class af1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "YoneticiID1",
                table: "Kullanici",
                newName: "OgretmenId");

            migrationBuilder.RenameColumn(
                name: "YoneticiAdi1",
                table: "Kullanici",
                newName: "OgrenmenAdi");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OgretmenId",
                table: "Kullanici",
                newName: "YoneticiID1");

            migrationBuilder.RenameColumn(
                name: "OgrenmenAdi",
                table: "Kullanici",
                newName: "YoneticiAdi1");
        }
    }
}
