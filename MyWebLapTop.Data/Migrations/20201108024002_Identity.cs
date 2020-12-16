using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebLapTop.Data.Migrations
{
    public partial class Identity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "2888ca7f-2d1b-46c8-afae-a179df73afe3", "minhtrungxyz123@gmail.com", "Trung", "Phạm", "minhtrungxyz123@gmail.com", "AQAAAAEAACcQAAAAEE8S2LW9Pv2acwLj5ofD/Nms21dV9NIcGv7J6K72325+uRusPQ1LFiNZSDOXSP73TQ==" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "4befa9b8-a348-4635-994a-6d0cb9195169");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "8bfb3400-2632-46a5-a3d4-058f152d14eb", "tedu.international@gmail.com", "Toan", "Bach", "tedu.international@gmail.com", "AQAAAAEAACcQAAAAEKkLRsQGugQNQbJL6oMM8A0hIyx4p60g/HWzmDvgLzh+f+9nZ/y5qLJNBWmhqnR8Hw==" });

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
                value: new DateTime(2020, 11, 8, 0, 12, 52, 252, DateTimeKind.Local).AddTicks(6276));
        }
    }
}
