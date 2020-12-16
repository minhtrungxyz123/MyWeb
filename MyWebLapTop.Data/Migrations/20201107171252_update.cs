using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebLapTop.Data.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8bfb3400-2632-46a5-a3d4-058f152d14eb", "AQAAAAEAACcQAAAAEKkLRsQGugQNQbJL6oMM8A0hIyx4p60g/HWzmDvgLzh+f+9nZ/y5qLJNBWmhqnR8Hw==" });

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
                columns: new[] { "DateCreated", "OriginalPrice", "Price" },
                values: new object[] { new DateTime(2020, 11, 8, 0, 12, 52, 252, DateTimeKind.Local).AddTicks(6276), 38989000m, 42499000m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "b23d0439-1d00-4b7c-9a5d-9886291011e4");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8bc927ab-e697-40b8-8f1a-4e041cdc2e59", "AQAAAAEAACcQAAAAEBjdcnOoJY1WWPJf55yvI4dJAJIVB09jkMHIOFxcNwW96tyOpvdzeFIX3nk9wTXaJA==" });

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
                columns: new[] { "DateCreated", "OriginalPrice", "Price" },
                values: new object[] { new DateTime(2020, 11, 8, 0, 8, 27, 408, DateTimeKind.Local).AddTicks(855), 100000m, 200000m });
        }
    }
}
