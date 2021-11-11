using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace kShopSolution.Data.Migrations
{
    public partial class ChangfileLengthtype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "ba43a001-3424-49f1-978c-bace6c12933b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "81e427df-21ca-4f79-9464-f5cca35dcf4e", "AQAAAAEAACcQAAAAEB8vodXKE/Qd+Ps66HAahY/bZxta536lyFm42Bzw1ZkWJ8eJ1SMocMBPoiBcY/gy0w==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 11, 11, 14, 26, 11, 159, DateTimeKind.Local).AddTicks(7869));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "021a9e1d-3d72-4b59-b527-46b947731e31");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "28ad0c78-b90b-45f8-9fd7-d6989eaed9bd", "AQAAAAEAACcQAAAAEDNqwkXk7gHLS1TmGaz6dnvJ/HX/7P1GLwTlz6Zxu18tt8tKB4vbDihPiKtonfXX7w==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 11, 8, 17, 10, 40, 710, DateTimeKind.Local).AddTicks(9635));
        }
    }
}
