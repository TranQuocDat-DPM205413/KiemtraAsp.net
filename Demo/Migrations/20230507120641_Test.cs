using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "wsHocSinh",
                columns: table => new
                {
                    uID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    uHoTen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    uGioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    uNgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    uSoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    uDiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wsHocSinh", x => x.uID);
                });

            migrationBuilder.CreateTable(
                name: "wsUser",
                columns: table => new
                {
                    uID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    uFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    uSex = table.Column<bool>(type: "bit", nullable: false),
                    uInformation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    uMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    uEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isActived = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wsUser", x => x.uID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "wsHocSinh");

            migrationBuilder.DropTable(
                name: "wsUser");
        }
    }
}
