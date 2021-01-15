using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebLapTop.Data.Migrations
{
    public partial class post : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bantins",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Noidung = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bantins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chitiets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdBantin = table.Column<int>(nullable: false),
                    Tieude = table.Column<string>(maxLength: 200, nullable: false),
                    Noidung = table.Column<string>(maxLength: 5000, nullable: false),
                    Lanxem = table.Column<int>(nullable: false, defaultValue: 0),
                    Ngaydang = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chitiets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chitiets_Bantins_IdBantin",
                        column: x => x.IdBantin,
                        principalTable: "Bantins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "6a0b6c7d-ab7a-44f4-9fa8-c17b6aff2d81");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "50b6f36c-42da-4af6-af6c-c4509a54b68a", "AQAAAAEAACcQAAAAEES3jw97x0ypuYcq6vChtHXgnCRNiIsSjjaE+1B8NpeQh5o2KP8SeRKNouhM7NwThA==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 1, 11, 21, 8, 25, 344, DateTimeKind.Local).AddTicks(2930));

            migrationBuilder.CreateIndex(
                name: "IX_Chitiets_IdBantin",
                table: "Chitiets",
                column: "IdBantin");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chitiets");

            migrationBuilder.DropTable(
                name: "Bantins");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "7fd9ff57-d49d-45ff-aa39-5154b4ca0554");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "64c2ffcb-d325-4740-a186-e6d0b0f239c0", "AQAAAAEAACcQAAAAEA26DSMW8cjKNJ7jKC326sJZx+wfcgQ7dq9VIrv/XRULrBWA0LFfZIsmGnl+yheCTA==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 22, 18, 28, 49, 508, DateTimeKind.Local).AddTicks(7174));
        }
    }
}
