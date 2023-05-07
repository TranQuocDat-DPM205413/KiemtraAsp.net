using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo.Migrations
{
    public partial class Db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "wsHocSinh");

            migrationBuilder.CreateTable(
                name: "wsSinhVien",
                columns: table => new
                {
                    uID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    uMaSv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    uHoTen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    uGioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    uNgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    uSoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    uDiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wsSinhVien", x => x.uID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "wsSinhVien");

            migrationBuilder.CreateTable(
                name: "wsHocSinh",
                columns: table => new
                {
                    uID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    uDiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    uGioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    uHoTen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    uNgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    uSoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wsHocSinh", x => x.uID);
                });
        }
    }
}
