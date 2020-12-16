using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebLapTop.Data.Migrations
{
    public partial class koduoc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "4fd6b1a2-86b9-4884-80db-005eb676e86b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "700aa1aa-0c23-49db-aec1-946ecb050869", "AQAAAAEAACcQAAAAEB6BIcv/LZvhhTE5xN+lbH7BwaOR1K3ZVp7Yi2H1Z9Z/8YlB6k+g1I7omcs5/FQpZQ==" });

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
                value: new DateTime(2020, 11, 9, 21, 3, 36, 765, DateTimeKind.Local).AddTicks(4273));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "89ded989-ba1c-4b88-b143-cee4b9d3e27a");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2888ca7f-2d1b-46c8-afae-a179df73afe3", "AQAAAAEAACcQAAAAEE8S2LW9Pv2acwLj5ofD/Nms21dV9NIcGv7J6K72325+uRusPQ1LFiNZSDOXSP73TQ==" });

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
                value: new DateTime(2020, 11, 8, 9, 40, 1, 823, DateTimeKind.Local).AddTicks(6930));
        }
    }
}
