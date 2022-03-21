using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Handbook.Data.Migrations
{
    public partial class FixedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "id",
                keyValue: new Guid("6c7e12cb-9f24-428d-8b64-ffb8bd2abb20"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1403d9ca-45f8-4a24-9df2-9f5aaef2db2f"));

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "id", "ProductPrice" },
                values: new object[] { new Guid("4e9f1871-aacb-4934-a94a-21ad576e11cc"), 12.22m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("9a1cb0f8-19c9-4d43-a8d7-5590346ca3f2"), "PC-1-CC", 0, "Red", new DateTime(2022, 3, 21, 13, 24, 8, 517, DateTimeKind.Local).AddTicks(5365), "Sugar", "Coca-cola", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Drink", "1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "id",
                keyValue: new Guid("4e9f1871-aacb-4934-a94a-21ad576e11cc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a1cb0f8-19c9-4d43-a8d7-5590346ca3f2"));

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "id", "ProductPrice" },
                values: new object[] { new Guid("6c7e12cb-9f24-428d-8b64-ffb8bd2abb20"), 12.22m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("1403d9ca-45f8-4a24-9df2-9f5aaef2db2f"), "PC-1-CC", 0, "Red", new DateTime(2022, 3, 21, 13, 22, 51, 956, DateTimeKind.Local).AddTicks(9872), "Sugar", "Coca-cola", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Drink", "1" });
        }
    }
}
