using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Handbook.Data.Migrations
{
    public partial class InitialPriceConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "ProductPrice" },
                values: new object[] { new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 3.14m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "ProductPrice" },
                values: new object[] { new Guid("5ccc3dac-3272-45b8-b45e-0256b1e943dd"), 17.22m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "ProductPrice" },
                values: new object[] { new Guid("ffffdc53-390c-4c91-a2a7-261d4fc98db9"), 16.22m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "ProductPrice" },
                values: new object[] { new Guid("ee0421d0-2b3a-47d6-8a94-f7770ec5b1a4"), 15.22m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "ProductPrice" },
                values: new object[] { new Guid("00cf91bd-7b40-49f3-936c-d1ca320a57f2"), 14.22m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "ProductPrice" },
                values: new object[] { new Guid("6b2e6bbe-2862-4538-a42c-df6fb9706543"), 13.22m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "ProductPrice" },
                values: new object[] { new Guid("b63138b1-dd16-424f-813d-f52c8cd8d6fc"), 12.22m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "ProductPrice" },
                values: new object[] { new Guid("865e193f-d71a-4d67-9bd2-520bb132af47"), 11.22m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "ProductPrice" },
                values: new object[] { new Guid("07cb300f-531f-464f-badd-395fd5c9a6ed"), 10.22m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "ProductPrice" },
                values: new object[] { new Guid("c646d491-08f5-41df-a602-a76eef999f65"), 9.22m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "ProductPrice" },
                values: new object[] { new Guid("ff7cd27d-6a76-40a6-bd3c-e2745123f798"), 8.22m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "ProductPrice" },
                values: new object[] { new Guid("e873881f-e1f7-45e9-b12b-ac5022720548"), 17.99m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "ProductPrice" },
                values: new object[] { new Guid("9993aff8-02f5-4503-81a6-1d166e82a7fe"), 16.99m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "ProductPrice" },
                values: new object[] { new Guid("3e2508c1-0461-4a5d-856f-53e62ab12ba1"), 15.99m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "ProductPrice" },
                values: new object[] { new Guid("59d3b1cc-071f-49f3-9e59-7c5c794870ca"), 14.99m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "ProductPrice" },
                values: new object[] { new Guid("2d89ce36-5107-450a-8f90-020984f662ee"), 13.99m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "ProductPrice" },
                values: new object[] { new Guid("fa7a0e4b-07c7-4a67-a67c-c2117d581383"), 12.99m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "ProductPrice" },
                values: new object[] { new Guid("05484e57-1b7f-45a0-9512-d36621240031"), 11.99m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "ProductPrice" },
                values: new object[] { new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 2.14m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "ProductPrice" },
                values: new object[] { new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"), 4m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "ProductPrice" },
                values: new object[] { new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 9.13m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "ProductPrice" },
                values: new object[] { new Guid("275fb044-2514-4adf-8f4d-e52edd0f0182"), 8.62m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "ProductPrice" },
                values: new object[] { new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 7.91m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "ProductPrice" },
                values: new object[] { new Guid("f38ea1ef-fed8-4193-9558-5d08f9db095d"), 39.1m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "ProductPrice" },
                values: new object[] { new Guid("2136e23c-8266-4889-bfdc-d2256ff37411"), 18.22m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "ProductPrice" },
                values: new object[] { new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 2.99m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "ProductPrice" },
                values: new object[] { new Guid("b911297c-91b4-4ac2-83d0-314f44c8fc32"), 6.4m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "ProductPrice" },
                values: new object[] { new Guid("3e18544c-64ff-4023-b94a-66fd1bd6b11c"), 7.99m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "ProductPrice" },
                values: new object[] { new Guid("9219bb63-1644-4eb8-a189-aabedc10071a"), 8.99m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "ProductPrice" },
                values: new object[] { new Guid("477523ae-f023-46f9-86d8-097bd63d299b"), 9.99m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "ProductPrice" },
                values: new object[] { new Guid("f6e2b8ed-ed2f-45d2-b533-efb2553b9423"), 19.99m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "ProductPrice" },
                values: new object[] { new Guid("46ecdba4-c87a-44bd-a81d-cf23105acf3f"), 10.99m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "ProductPrice" },
                values: new object[] { new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 5.99m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "ProductPrice" },
                values: new object[] { new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb"), 3.01m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("00cf91bd-7b40-49f3-936c-d1ca320a57f2"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("05484e57-1b7f-45a0-9512-d36621240031"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("07cb300f-531f-464f-badd-395fd5c9a6ed"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("2136e23c-8266-4889-bfdc-d2256ff37411"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("275fb044-2514-4adf-8f4d-e52edd0f0182"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("2d89ce36-5107-450a-8f90-020984f662ee"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("3e18544c-64ff-4023-b94a-66fd1bd6b11c"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("3e2508c1-0461-4a5d-856f-53e62ab12ba1"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("46ecdba4-c87a-44bd-a81d-cf23105acf3f"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("477523ae-f023-46f9-86d8-097bd63d299b"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("59d3b1cc-071f-49f3-9e59-7c5c794870ca"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("5ccc3dac-3272-45b8-b45e-0256b1e943dd"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("6b2e6bbe-2862-4538-a42c-df6fb9706543"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("865e193f-d71a-4d67-9bd2-520bb132af47"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("9219bb63-1644-4eb8-a189-aabedc10071a"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("9993aff8-02f5-4503-81a6-1d166e82a7fe"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("b63138b1-dd16-424f-813d-f52c8cd8d6fc"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("b911297c-91b4-4ac2-83d0-314f44c8fc32"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("c646d491-08f5-41df-a602-a76eef999f65"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("e873881f-e1f7-45e9-b12b-ac5022720548"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("ee0421d0-2b3a-47d6-8a94-f7770ec5b1a4"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("f38ea1ef-fed8-4193-9558-5d08f9db095d"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("f6e2b8ed-ed2f-45d2-b533-efb2553b9423"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("fa7a0e4b-07c7-4a67-a67c-c2117d581383"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("ff7cd27d-6a76-40a6-bd3c-e2745123f798"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("ffffdc53-390c-4c91-a2a7-261d4fc98db9"));
        }
    }
}
