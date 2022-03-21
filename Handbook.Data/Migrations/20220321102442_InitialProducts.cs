using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Handbook.Data.Migrations
{
    public partial class InitialProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("f8f744a2-a92a-49d6-975a-ad9f1ef82a65"), 12.22m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("7be0c894-5408-416a-9410-7f0fbc0d09bf"), "SD-3-L-708", 707, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4941), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f7ee2ef4-d780-4649-97d0-1848df6b61d0"), "SD-3-L-709", 708, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4945), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("1d3f14b7-fe08-4072-b875-f5c224ffa0d5"), "SD-3-L-710", 709, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4950), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("43977ec4-e3fc-44a7-9c91-6add03f2e197"), "SD-3-L-711", 710, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4954), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c88dc306-ca3a-4c68-99c1-51bcdbd74562"), "SD-3-L-712", 711, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4958), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("55d21efe-55e5-488e-917c-6470ad094583"), "SD-3-L-713", 712, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4963), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4d88265d-2364-498e-8f28-52fccf5a48c7"), "SD-3-L-714", 713, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4969), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b3339ac4-d3d4-41ab-8087-b936cb618591"), "SD-3-L-715", 714, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4974), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("2d85f871-b0c5-48b9-bc05-8a7f85783250"), "SD-3-L-716", 715, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4978), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("cd50e070-582f-480c-908f-5c40cfa36258"), "SD-3-L-717", 716, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4982), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ed7f655f-b239-4c7f-84da-aab33bb91e1c"), "SD-3-L-718", 717, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4986), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("393b05ea-7f58-4a14-9fbc-cd48671f472a"), "SD-3-L-719", 718, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4991), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("0c9eeddb-6727-485b-90e6-5f81fc34c227"), "SD-3-L-720", 719, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4995), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("90ebdcd7-7c5a-49ca-9d44-7dc4723a66d3"), "SD-3-L-721", 720, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4999), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6a868189-e142-45ce-97bb-788cda5381d2"), "SD-3-L-722", 721, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5007), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ff089577-6b6c-4400-a41b-33d18bd6b3ab"), "SD-3-L-723", 722, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5011), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("1e616e26-50cc-43af-b8cd-088738d28c76"), "SD-3-L-724", 723, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5015), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("14a4b043-280e-40d9-86ba-238e3a16c06f"), "SD-3-L-725", 724, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5019), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("d77d5336-6bbd-47b9-aaac-56613bfb27e2"), "SD-3-L-726", 725, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5024), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("0064219a-b17d-4d56-9079-a2fa897de73d"), "SD-3-L-727", 726, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5028), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f4e32d5c-a5fa-4599-82d3-5aa335c5389e"), "SD-3-L-728", 727, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5032), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("5f1cd2ae-28a5-48e8-97fa-f9857957535f"), "SD-3-L-729", 728, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5036), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("5a8295cd-5bdf-4345-b242-80eab6e9dd00"), "SD-3-L-730", 729, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5044), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b4b43f9d-cfc4-4d21-92ec-997829af13b4"), "SD-3-L-731", 730, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5048), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("432a7608-c8c5-432f-83f6-6994b86aa518"), "SD-3-L-732", 731, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5052), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b717679a-fc03-47f7-988a-ab131273abc2"), "SD-3-L-733", 732, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5057), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("58817238-6e13-4314-8abe-7cc1b0572578"), "SD-3-L-734", 733, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5061), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4784f754-8e8d-4e3c-a789-d9c193df6f81"), "SD-3-L-735", 734, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5065), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6f324c8a-1f60-4191-8943-3e516e689e1a"), "SD-3-L-736", 735, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5069), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("805f0658-7188-4d9d-bfa6-d99406e2bf8c"), "SD-3-L-707", 706, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4937), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("656c7b79-6d1e-48e7-a737-5d493f5106e6"), "SD-3-L-706", 705, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4931), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("54bc9675-f514-4947-a208-153d697fe298"), "SD-3-L-705", 704, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4925), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("9bd49cee-10ec-462a-8866-d3993c5290ab"), "SD-3-L-704", 703, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4921), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ecb2df2e-326a-4cca-bb7a-0dcf99710a7a"), "SD-3-L-674", 673, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4712), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f7b02d52-5b8d-4ed2-8a04-b9ae871ec507"), "SD-3-L-675", 674, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4716), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("48e427b1-b409-4e5a-8c10-4d23d9e99c8a"), "SD-3-L-676", 675, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4720), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ea6ccbbd-c23e-49e4-8bce-f920d9e06eab"), "SD-3-L-677", 676, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4725), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6c5feb55-5ae3-4252-a183-d8e592ed48ab"), "SD-3-L-678", 677, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4729), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("85f56ae0-0cb3-470b-900d-326cd4b0aa00"), "SD-3-L-679", 678, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4733), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("3a169b66-41bf-4944-a5cc-dd3906219199"), "SD-3-L-680", 679, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4738), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("7bfbab54-84e9-4500-a5d7-b3eabf6dbca7"), "SD-3-L-681", 680, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4742), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("5d709fdd-e423-4adb-9315-8c669252e4cf"), "SD-3-L-682", 681, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4748), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("71f56234-e466-42ba-b8f3-f36b6ac1541e"), "SD-3-L-683", 682, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4753), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a44d5989-f040-4f4a-b766-0a15cc98f56d"), "SD-3-L-684", 683, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4758), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("237f6fb3-8686-4e8b-8fed-48d1ad182fe1"), "SD-3-L-685", 684, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4762), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("288728cf-02e0-43f7-8d83-3bad6af65dfa"), "SD-3-L-686", 685, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4766), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("8f52a171-d5b3-45e3-a46b-2a5e3a3c1244"), "SD-3-L-687", 686, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4770), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b9e595dd-7f02-4221-89cb-edfde7887e33"), "SD-3-L-737", 736, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5074), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("36513507-dc00-446d-a94d-f11b7ca7a0f9"), "SD-3-L-688", 687, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4775), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("8686f09c-060b-49e7-a83a-6dd479f47c57"), "SD-3-L-690", 689, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4786), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4d82cba7-fb04-47fd-bdae-bb7c33e85c5a"), "SD-3-L-691", 690, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4790), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("dcebde61-924e-4661-8cbe-7c9f2e1eb751"), "SD-3-L-692", 691, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4794), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("7b89e71f-e465-44e8-a110-5ab0dd33c4e0"), "SD-3-L-693", 692, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4799), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("8024a73a-e56f-4c60-a13b-f73eabf912da"), "SD-3-L-694", 693, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4803), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ec8ebf96-8e99-42fb-bb8e-ef243429690b"), "SD-3-L-695", 694, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4807), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6cd88c5d-2127-4388-bd45-459c82c82d99"), "SD-3-L-696", 695, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4811), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("d361218d-8a92-4563-afaa-bd6e40b912ad"), "SD-3-L-697", 696, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4886), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("d90e49a7-ec22-41a2-bf1d-60ac4b0753cc"), "SD-3-L-698", 697, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4894), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("0d48610b-2372-4645-ab5f-090b08b60452"), "SD-3-L-699", 698, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4899), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("8fa0baa3-3a5e-4e21-8bfb-4cb9dc5ca5db"), "SD-3-L-700", 699, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4904), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a0505402-506f-40f8-b80a-5506fb2bde10"), "SD-3-L-701", 700, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4908), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c3c6e6d9-6fb0-4f19-9fbe-4351f1e08d0d"), "SD-3-L-702", 701, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4912), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("3c005404-9b20-4fd0-af35-45105aa232d7"), "SD-3-L-703", 702, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4916), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("24ba916f-691d-4b39-94df-52f1d203b188"), "SD-3-L-689", 688, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4779), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("5edadda7-dad5-4b96-9b09-c32f1d71dff8"), "SD-3-L-673", 672, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4705), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("3aa744b5-0744-4489-8b92-45bf9750ee3b"), "SD-3-L-738", 737, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5080), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("8ddae73b-072a-4557-a783-4512f3606fa9"), "SD-3-L-740", 739, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5089), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("74e1e19b-6bd4-404d-acc7-94a144bb4d23"), "CHLY-1-L-775", 774, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5295), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e97b170a-505f-4624-b1e7-c65d8d9ef5a8"), "CHLY-1-L-776", 775, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5300), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("0ed1678b-98cf-4a8c-a389-0aa2fa433d68"), "CHLY-1-L-777", 776, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5304), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("3f1a1418-fcea-4a7a-8b31-8bf53f923aa3"), "CHLY-1-L-778", 777, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5310), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("da36c4e7-8ea8-4406-bc61-53ac5841530d"), "CHLY-1-L-779", 778, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5314), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("db279430-a7ba-4827-bbc5-921d7c5a3c0a"), "CHLY-1-L-780", 779, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5319), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f2cd22ae-b25c-4808-9934-ba7a4d9e9e0d"), "CHLY-1-L-781", 780, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5323), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("30763818-ad6c-4dd1-ba9f-1bbe5e457084"), "CHLY-1-L-782", 781, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5328), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("165820d6-297c-4267-8b8e-ddb38e774636"), "CHLY-1-L-783", 782, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5332), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("9715a5cd-b1ad-49f5-b819-c8a22924846e"), "CHLY-1-L-784", 783, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5336), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c0e9f997-f1de-407d-8d9b-0a082fcafef2"), "CHLY-1-L-785", 784, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5340), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e06349a8-6448-4202-a9d6-ee9eeef3c071"), "CHLY-1-L-786", 785, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5347), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("71059850-ed1e-40dd-acd8-eaed50b995c4"), "CHLY-1-L-787", 786, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5351), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("89a080b6-1f27-4063-8dfc-c1bdf73e7747"), "CHLY-1-L-788", 787, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5356), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("237e1a0b-383f-4198-80e9-e237bc5735f8"), "CHLY-1-L-789", 788, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5360), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f22a113f-92af-4aa5-921b-3826d940f550"), "CHLY-1-L-790", 789, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5365), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("596b8841-9f28-40e4-9c32-881e823ae668"), "CHLY-1-L-791", 790, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5370), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("1c0bd186-6bdd-4c78-8726-a81b6d2dc150"), "CHLY-1-L-792", 791, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5374), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("83256631-55de-4883-9c92-a9dacab8bfb0"), "CHLY-1-L-793", 792, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5378), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("fe4f7376-053c-401a-b4ba-0d7417b42b63"), "CHLY-1-L-794", 793, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5385), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b313d450-473b-4e0d-b380-2af31d52f21f"), "CHLY-1-L-795", 794, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5389), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("04cd20be-9244-45cf-88a8-58e83bc923d8"), "CHLY-1-L-796", 795, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5393), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("82872008-d8c6-46a2-91ff-e39745e0a503"), "CHLY-1-L-797", 796, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5398), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("d2dfc1fd-77fd-44f4-b491-3b5fab8e7d44"), "CHLY-1-L-798", 797, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5404), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("9a51ab49-ed78-42fc-8f86-4525f3157935"), "CHLY-1-L-799", 798, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5408), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e60d1915-b8d5-4b8c-9d7b-9d51e5f0304a"), "CHLY-1-L-800", 799, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5413), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e1b7e303-c4cf-4491-8544-2817b901cda2"), "CHLY-1-L-801", 800, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5417), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("82cf2397-3462-43cb-ae47-6d54f526f8bb"), "CHLY-1-L-802", 801, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5424), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b0d30e98-9eaa-451f-9335-83d7dfb54356"), "CHLY-1-L-803", 802, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5428), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("3db71e31-0ac5-457f-ba4f-57675438c66d"), "CHLY-1-L-774", 773, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5291), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("26fc0f29-ac38-4fda-8d7e-ee4c43dfd331"), "CHLY-1-L-773", 772, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5287), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("27d462b3-ed8c-432a-9e67-cf543b93d64f"), "CHLY-1-L-772", 771, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5282), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("112c910d-ee80-43b7-b33e-11b1d531bb4f"), "CHLY-1-L-771", 770, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5278), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c3365730-6d24-41ef-a891-6d6c70ec45a0"), "SD-3-L-741", 740, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5093), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("312bdb8a-37c1-4fcf-ac6a-8f1909f4db23"), "SD-3-L-742", 741, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5097), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("25251c02-342e-4d08-856a-ee448a8d3f80"), "SD-3-L-743", 742, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5102), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("7f594974-a007-4d6d-806a-6493a1d453f7"), "SD-3-L-744", 743, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5106), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("47b35807-aebc-41c2-806f-a96d93faea4a"), "SD-3-L-745", 744, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5111), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("60e58d6b-324f-45de-acdb-01c66442f170"), "SD-3-L-746", 745, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5117), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("907661d9-f219-482d-aac5-a2a230f83065"), "SD-3-L-747", 746, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5122), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("8a06864f-a23f-4ebf-acff-92643d43b014"), "SD-3-L-748", 747, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5126), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ba0f88e4-fd08-4a87-8805-8e81c9858ce6"), "SD-3-L-749", 748, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5130), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("3ba9e087-8962-4d8c-9667-879f4893045c"), "SD-3-L-750", 749, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5134), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ba82f382-23c6-4582-adf3-2f6b0b0dd4d6"), "SD-3-L-751", 750, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5139), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("12a6408a-e02d-428e-8197-606210f82325"), "CHLY-1-L-752", 751, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5143), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f6841af5-9533-44a1-9f39-a471c54b18cc"), "CHLY-1-L-753", 752, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5190), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c56c1192-9c10-417d-b24a-774a106a6594"), "CHLY-1-L-754", 753, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5198), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("90f1af82-939e-42d6-951b-bd28a6c904d0"), "SD-3-L-739", 738, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5085), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("16c3a52b-7ee8-47f4-a2eb-732653b85d08"), "CHLY-1-L-755", 754, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5203), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("7867659a-4097-4afd-89dd-44dbf825df2d"), "CHLY-1-L-757", 756, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5211), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("52090aba-1684-4579-8ac5-26626e58ee44"), "CHLY-1-L-758", 757, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5216), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("38e4aa2e-22f9-492c-a0aa-fcdd2ca8f47e"), "CHLY-1-L-759", 758, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5220), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("785edc88-fa0b-422a-a962-76aeabeeee1d"), "CHLY-1-L-760", 759, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5224), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("53613df4-893a-4321-960e-723dae32ea68"), "CHLY-1-L-761", 760, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5230), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("0adf972a-a7d7-462b-a965-b28e3b5cde60"), "CHLY-1-L-762", 761, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5236), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("95d8e89a-eea0-4602-8cf8-92e11fee62fd"), "CHLY-1-L-763", 762, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5240), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("d5a2ed18-5141-42b3-9aba-624c53696209"), "CHLY-1-L-764", 763, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5245), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("44189d96-14af-4360-9cad-bfb3ff9874cc"), "CHLY-1-L-765", 764, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5249), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("fd0e86b9-ebcb-463e-849b-b61cc2775285"), "CHLY-1-L-766", 765, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5253), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a8ca0648-cdd8-4450-9451-d4a266deda9f"), "CHLY-1-L-767", 766, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5258), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a2c879fe-e511-4c1c-87b2-e3206d48a6ac"), "CHLY-1-L-768", 767, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5263), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b0edc212-3c24-4409-ac60-0d388f5afbe8"), "CHLY-1-L-769", 768, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5267), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a6c7efe9-5365-438e-a38c-591ae075eef1"), "CHLY-1-L-770", 769, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5273), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("03a34fcb-2c1d-4f0e-b91c-bd0ea5eefb09"), "CHLY-1-L-756", 755, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5207), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("11a60611-8cc8-4e75-8abb-45b89bd8ff7a"), "CHLY-1-L-804", 803, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5432), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f95054be-6269-4481-a02b-12865f7350a0"), "SD-3-L-672", 671, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4701), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("68a3ba24-fe86-4905-941b-a2d0c069d1ce"), "SD-3-L-670", 669, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4692), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("bbebe9fb-68ba-4ed9-9a17-7b9cc54fbd96"), "SD-3-L-574", 573, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4168), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("0be4eaf1-b7e0-4415-891f-401d3df7a01c"), "SD-3-L-575", 574, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4172), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4e15e903-0a04-490e-9e79-a676f31db6c1"), "SD-3-L-576", 575, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4177), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a0c224cb-5559-467d-b28c-31e4f60ec502"), "SD-3-L-577", 576, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4181), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b8d45edb-106d-4017-ba75-20ae31b75038"), "SD-3-L-578", 577, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4188), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("55bb62cf-f904-47f8-94d2-40cadec21f9c"), "SD-3-L-579", 578, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4193), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("709f62c1-8c37-41d1-870d-fc6b41d12287"), "SD-3-L-580", 579, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4197), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("9f13d3c0-aff0-4408-b7de-3b86bbc5a40c"), "SD-3-L-581", 580, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4201), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("22b9f70b-7953-4b90-b2c3-f646e4a51392"), "SD-3-L-582", 581, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4205), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("02433a74-a835-4cf4-a518-29c6fbe21cd4"), "SD-3-L-583", 582, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4209), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("84acf872-b4d7-4279-9959-b83ef8057988"), "SD-3-L-584", 583, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4254), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("fb0b113a-127c-4c09-bdff-121dbb59f727"), "SD-3-L-585", 584, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4260), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b93143ac-4aee-4a53-8eb2-1699b1979176"), "SD-3-L-586", 585, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4267), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("8d332584-2d45-41c5-88ca-62dc7bec40e1"), "SD-3-L-587", 586, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4271), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("5899fb58-9280-469d-a6f9-b345a90df279"), "SD-3-L-588", 587, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4276), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("fbc3020b-39ba-4490-8210-00221923ded4"), "SD-3-L-589", 588, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4280), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("936578e6-f70f-4e69-bf58-25ca118ceee9"), "SD-3-L-590", 589, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4285), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("3d62207e-8fc5-4737-92e7-de2c7d197465"), "SD-3-L-591", 590, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4289), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("59d8955d-a589-4ade-95e9-1e5a6f7f8f39"), "SD-3-L-592", 591, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4294), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("00ec03b8-0493-40cb-94a7-dff96882d127"), "SD-3-L-593", 592, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4299), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a1662723-acf5-462f-91f0-a706280c276e"), "SD-3-L-594", 593, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4305), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a3b3af14-2d32-400c-9815-0d6f83531054"), "SD-3-L-595", 594, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4310), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("5a1d0c98-b8a0-45e9-84c7-84ecd809c311"), "SD-3-L-596", 595, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4314), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c9af57d1-833f-4d59-802c-c49f8f945059"), "SD-3-L-597", 596, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4318), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("8749d19a-1849-453d-a9c4-60a123e90e4e"), "SD-3-L-598", 597, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4323), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("54776031-6f5a-462e-aab2-28600f72101e"), "SD-3-L-599", 598, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4327), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("dc46ed81-1d13-4ffc-981a-f1bddbb22954"), "SD-3-L-600", 599, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4332), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f4607728-93d7-47ac-98c7-eafad78365e9"), "SD-3-L-601", 600, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4337), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("1d46d2f2-0d2c-49d3-ab70-6f7958ff6571"), "SD-3-L-602", 601, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4343), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b30391ef-005c-4c6c-9637-b073571f9a85"), "SD-3-L-573", 572, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4164), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ef4084a2-8b45-499b-b627-865ccb8c0ef5"), "SD-3-L-572", 571, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4160), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("313b5e5f-0773-4a6a-8a7f-b05685bf9f47"), "SD-3-L-571", 570, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4155), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("7e58b54b-46ff-41e0-bfbc-c57fff01b589"), "SD-3-L-570", 569, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4151), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("36aa8a7b-7f63-47c1-8b95-2e1f9161c186"), "SD-3-L-540", 539, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4012), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a3edfbf7-9a41-4f3d-9a72-55fd83994080"), "SD-3-L-541", 540, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4017), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f9434d46-2c61-4356-a639-bd898f611e2d"), "SD-3-L-542", 541, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4021), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("0e5bca9c-d7a7-4802-81b6-86b7edad7641"), "SD-3-L-543", 542, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4025), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c5ddb2c1-42c8-4408-b7c2-7d7d99dc4259"), "SD-3-L-544", 543, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4029), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ecf33fb0-41ab-44e6-9c1b-5ce067d269ad"), "SD-3-L-545", 544, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4033), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("60096114-f519-4ce1-ae77-70aed540ee26"), "SD-3-L-546", 545, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4041), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("583e95d0-e253-4483-8e89-3e62b01cd731"), "SD-3-L-547", 546, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4045), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("9c434aeb-0865-431a-a847-06410cc88296"), "SD-3-L-548", 547, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4049), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("9a53131e-d7ff-4786-b3a5-498c91f436c2"), "SD-3-L-549", 548, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4053), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("fcd01285-818d-4ed0-899e-acad02ee2f38"), "SD-3-L-550", 549, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4057), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c3b2f1ea-1246-4e89-961b-5c79f605bd68"), "SD-3-L-551", 550, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4061), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("8f05c58f-e3b7-4758-94b7-b007e803775f"), "SD-3-L-552", 551, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4066), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f226a11c-d8ce-4c9b-b7fa-0f1e59cc7d13"), "SD-3-L-553", 552, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4070), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("3451ab95-03fd-467a-be95-639a37dc0178"), "SD-3-L-603", 602, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4348), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("607b8c08-f0f1-49c7-8498-6df378ec458c"), "SD-3-L-554", 553, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4077), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("89264ef1-a22e-4670-ad9e-380173d9f57a"), "SD-3-L-556", 555, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4086), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("0258f348-6ba0-4f39-8b33-1721425c5ca1"), "SD-3-L-557", 556, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4090), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4d06710f-f807-4776-8228-7b4ebd445b0c"), "SD-3-L-558", 557, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4094), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ae0b0f87-d6c5-469a-8643-a6dfb91c0345"), "SD-3-L-559", 558, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4098), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("d0411b32-efb3-416c-b69e-199a46508a6a"), "SD-3-L-560", 559, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4102), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("d3df7aaa-4ad5-463b-bfe3-6eb530398c96"), "SD-3-L-561", 560, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4106), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c148aee0-4266-41c4-93eb-7dea228c4fe8"), "SD-3-L-562", 561, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4114), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("75ccdc2d-d0b8-45f0-9036-b0dcdbc69d34"), "SD-3-L-563", 562, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4118), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("1f2261b9-a5ff-4fb0-9b3b-a229ea0da893"), "SD-3-L-564", 563, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4122), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("620304a5-5e73-4cdd-82a1-69372ee100ec"), "SD-3-L-565", 564, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4126), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("91eeed61-610f-4dd5-ac55-f8a9f5511de3"), "SD-3-L-566", 565, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4130), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e94747f3-9d03-4dfe-b29f-748ce37a358e"), "SD-3-L-567", 566, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4135), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c765a59f-2e62-498f-99b7-868d6e1897b1"), "SD-3-L-568", 567, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4139), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("dc6282e9-2733-4d1d-8adb-1c85c89966ea"), "SD-3-L-569", 568, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4144), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("171b7307-e5e5-4187-89ae-3c2db22b483a"), "SD-3-L-555", 554, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4081), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f1a8229f-c217-4ebf-ac01-89c32ff61704"), "SD-3-L-671", 670, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4696), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("711fea52-c107-44c1-be47-4f274606f340"), "SD-3-L-604", 603, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4352), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("2ec9ba3f-95fc-4500-ab09-6b3951ac66f2"), "SD-3-L-606", 605, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4361), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("cb8811c5-bd17-456e-836c-868e1ec3e01e"), "SD-3-L-641", 640, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4553), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("eece48fd-ea72-4156-bdb1-8ed6e08966d9"), "SD-3-L-642", 641, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4560), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6536863a-aed5-4fea-a869-05ea4864377a"), "SD-3-L-643", 642, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4564), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("95c903b1-83f5-4c77-8b60-fcc9b674db9c"), "SD-3-L-644", 643, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4568), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("3b0c9f7e-5112-4c76-bd00-2aaff345c5e4"), "SD-3-L-645", 644, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4572), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4e21804c-5594-4ee1-8fd9-2c157ff440ee"), "SD-3-L-646", 645, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4578), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("0d8aa215-6afc-4597-8051-f21ffd11faca"), "SD-3-L-647", 646, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4582), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a1040912-a044-4918-b4c5-f4ce0a0a82f3"), "SD-3-L-648", 647, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4587), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("310793a8-d015-458e-b0e5-e059ea0999e9"), "SD-3-L-649", 648, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4591), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b3355be5-8ab3-48a1-864e-11f305be82c7"), "SD-3-L-650", 649, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4597), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4f42340c-449a-4cec-9985-9d2b1f31abd8"), "SD-3-L-651", 650, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4602), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("164cabc6-dfe8-44b2-9eed-b24a1f42c1c4"), "SD-3-L-652", 651, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4606), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("d32540d9-f9f6-433e-9c9d-1fe95554685c"), "SD-3-L-653", 652, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4610), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("0be6d597-0646-4093-b3ac-eb3ffa45d09c"), "SD-3-L-654", 653, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4617), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("069ef79f-66c5-4e2a-ac72-ee42147e7d93"), "SD-3-L-655", 654, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4621), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("236e9089-f715-482e-bea7-1021e7cf96c1"), "SD-3-L-656", 655, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4626), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e0c9fd19-d843-4f7b-9f4e-f0a7e6419c98"), "SD-3-L-657", 656, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4631), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f319c499-15d1-4cac-9d21-056a99001e2d"), "SD-3-L-658", 657, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4638), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ff8903d2-2c3d-46c6-8c2c-ba192acc4749"), "SD-3-L-659", 658, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4642), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f9c6da9c-96a0-487b-93c6-d56d58aa1b02"), "SD-3-L-660", 659, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4646), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("389d219d-426c-440a-ba1d-586b8ef06fd4"), "SD-3-L-661", 660, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4651), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("39599055-7429-4c86-bb79-b8bdad9dfe6e"), "SD-3-L-662", 661, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4655), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("fb894d92-0f13-4a14-9711-d8d55dee2926"), "SD-3-L-663", 662, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4660), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ba7788e5-be17-44dd-91e4-5f61160d2a8f"), "SD-3-L-664", 663, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4664), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("97512776-9347-4159-be71-35e7b58cd035"), "SD-3-L-665", 664, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4668), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f1c253fa-8eaf-4825-849c-98c92affd142"), "SD-3-L-666", 665, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4675), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("26d4fa25-627c-4bfb-9d09-ee50aa90e237"), "SD-3-L-667", 666, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4679), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("826db9d7-134d-4e83-818b-25577cdeac26"), "SD-3-L-668", 667, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4683), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("d3d0096b-a91a-49aa-a9e5-aa2638259e30"), "SD-3-L-669", 668, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4688), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a9c5fe0f-7510-4f58-bff0-c0df409596d1"), "SD-3-L-640", 639, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4547), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a8f01221-89be-4820-b0db-8c736d17d5d6"), "SD-3-L-639", 638, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4518), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("eb0c7d89-3f68-4d32-95c3-318b7214ade5"), "SD-3-L-638", 637, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4513), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("31c3ba03-e3dc-4ddd-b525-2ebe408f9984"), "SD-3-L-637", 636, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4509), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c5bcbacf-2707-4f1c-8238-90b2dc0f45b8"), "SD-3-L-607", 606, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4366), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c107a1ff-f203-405a-a6c2-87474083c5a9"), "SD-3-L-608", 607, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4371), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("910558ee-11d1-4d1e-93b8-9d9d739e4f0c"), "SD-3-L-609", 608, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4375), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("62604891-e720-4e9f-b49c-7cbe47e9aa93"), "SD-3-L-610", 609, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4381), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a246faf2-84a2-439f-8275-2866f1d1265f"), "SD-3-L-611", 610, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4386), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("857428da-7c99-45fc-8913-fd51b79bbe64"), "SD-3-L-612", 611, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4390), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6410c170-ff47-442e-ba32-4c20a124ee21"), "SD-3-L-613", 612, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4395), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("96cc5edf-f516-4f86-979e-483d0eb3a89d"), "SD-3-L-614", 613, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4400), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("28a120e9-c5fd-4afe-a93f-73e31a705648"), "SD-3-L-615", 614, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4406), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("be3d0251-dfe6-4fbc-b758-f10d56b76e65"), "SD-3-L-616", 615, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4410), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b1cecd84-037f-446f-b08b-ab9f21094196"), "SD-3-L-617", 616, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4414), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("2142f78e-be17-44f7-bde0-9f440a796329"), "SD-3-L-618", 617, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4421), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a2529c49-3246-4f87-94c0-d4fcd9855928"), "SD-3-L-619", 618, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4426), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f339f129-a875-4f9b-a0d0-13ad85e8337a"), "SD-3-L-620", 619, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4430), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("282917aa-3fde-406b-bab1-afc882251c47"), "SD-3-L-605", 604, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4357), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("fe091a34-333d-4021-85a7-6a828b6d57de"), "SD-3-L-621", 620, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4434), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("38608a1b-eeb5-4806-89cd-10afcf19d792"), "SD-3-L-623", 622, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4443), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f16796d3-5bfd-409e-8eee-ac87747cd3bf"), "SD-3-L-624", 623, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4447), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("50290830-b952-4e6b-a63b-13f0be9ae163"), "SD-3-L-625", 624, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4452), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e0e9900f-6f5a-4dd5-bfea-6d34a31f3284"), "SD-3-L-626", 625, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4459), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("be1df106-c947-4370-865a-16c8551957bb"), "SD-3-L-627", 626, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4464), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("3fee6def-86a6-4c0d-8d53-e375f1486f7d"), "SD-3-L-628", 627, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4468), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("78a1f480-3543-4ddd-bd56-51f709cc29ea"), "SD-3-L-629", 628, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4472), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("798b6133-03dd-4d86-8cd5-a7c57c776d85"), "SD-3-L-630", 629, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4476), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("fd01f4ca-1c47-452a-96e7-dfdfc6ee51b2"), "SD-3-L-631", 630, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4481), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("9d762867-8d51-4383-887b-5bf4cf09e7ac"), "SD-3-L-632", 631, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4485), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6e66a94c-b435-4657-a517-bc0c20c7a6e9"), "SD-3-L-633", 632, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4489), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("66de500b-c6f0-4fc4-bdf4-343cf2ea3fb6"), "SD-3-L-634", 633, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4496), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4a6eae04-6dbd-471e-82b5-73e5ea40587e"), "SD-3-L-635", 634, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4501), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("5fff454e-5b2a-45b0-9bac-732a9dcc64a0"), "SD-3-L-636", 635, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4505), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("45ba8eb2-6f06-4ef2-9145-6cfd6cba9e12"), "SD-3-L-622", 621, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4438), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c7c11d0c-16b2-47f1-b3da-c09a4d0b94c5"), "CHLY-1-L-805", 804, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5437), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("9bceb273-5413-49ba-8e88-3b1632c9b2c1"), "CHLY-1-L-806", 805, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5441), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6a8cae75-d9df-499e-8057-a74842798b11"), "CHLY-1-L-807", 806, "Black", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5445), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 2m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("0190b6bc-acaf-44d1-9638-98706425b140"), "CHLY-2-L-977", 976, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6410), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a3ddb193-8200-4da7-b1b3-ae610213cf94"), "CHLY-2-L-978", 977, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6416), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6c89be8c-78b0-427c-a6d5-913e39010f82"), "CHLY-2-L-979", 978, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6420), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b4c31aec-3158-41d0-a504-2257ded7c1c0"), "CHLY-2-L-980", 979, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6467), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e3981273-0a54-48d3-90f4-4090632e4fa6"), "CHLY-2-L-981", 980, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6472), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ae77f493-80cb-4b8e-a4f4-0702da87d14a"), "CHLY-2-L-982", 981, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6476), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("5925eb14-c9d9-4f4d-85b0-1260c6257487"), "CHLY-2-L-983", 982, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6481), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("82da3073-b549-480c-a257-cd919c75f256"), "CHLY-2-L-984", 983, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6485), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("1cb819db-ac8f-4c79-9a13-7d249d5603a5"), "CHLY-2-L-985", 984, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6490), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("47dcc4af-5028-4643-bb66-9e01b8c69768"), "CHLY-2-L-986", 985, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6497), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a7ac170a-0094-4337-9ccd-987e8fe817f9"), "CHLY-2-L-987", 986, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6502), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c32aad36-9f65-4852-8220-69161c48c689"), "CHLY-2-L-988", 987, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6506), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("dca27272-846c-4178-b433-1228be169833"), "CHLY-2-L-989", 988, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6510), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6c67588f-3867-4ea4-876a-0e1aecccdda7"), "CHLY-2-L-990", 989, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6515), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("5bcd5d6d-0aef-467d-af2f-c7d678b2fb05"), "CHLY-2-L-991", 990, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6519), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("9afa1afc-5b28-4532-b7b5-7355d5f90f6d"), "CHLY-2-L-992", 991, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6524), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("5e11a1e9-2522-4a92-b6a6-cc9efc030ad6"), "CHLY-2-L-993", 992, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6528), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f967850f-2a82-4d23-a49d-1017854262f9"), "CHLY-2-L-994", 993, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6534), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4b6ea1c4-1e55-461c-9250-63103fc18a9d"), "CHLY-2-L-995", 994, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6539), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("06e6c17f-3a00-46e2-b692-301cae32e155"), "CHLY-2-L-996", 995, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6543), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f8499a4c-7f3a-4434-b9c7-864512b7d0b4"), "CHLY-2-L-997", 996, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6548), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("804d0d6a-dc76-488c-bec9-db866676aff0"), "CHLY-2-L-998", 997, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6554), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e8ad32a7-b7df-4dfa-8521-b4fc06f983dc"), "CHLY-2-L-999", 998, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6558), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a549412c-43ae-4e00-b688-b9d831a070c3"), "CHLY-2-L-1000", 999, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6562), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("8ca54009-5881-4c6f-88fa-59233ff54ed7"), "CHLY-2-L-1001", 1000, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6569), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("62ea1143-d869-40d8-8e89-adc767a377a8"), "CHLY-2-L-1002", 1001, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6578), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("73d2dedb-3bc8-4e3a-9cdc-0eb540a0964d"), "CHLY-2-L-1003", 1002, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6586), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4120737b-2370-42c9-9696-8f1636749a30"), "CHLY-2-L-1004", 1003, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6595), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("36ecd3e3-e4aa-45d5-8b26-fec3e8db9489"), "CHLY-2-L-1005", 1004, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6603), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("5cf9fe1f-b67e-4c36-a3d3-a24ff6de47df"), "CHLY-2-L-976", 975, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6406), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("1932c862-513c-4111-8b82-865d381faeb2"), "CHLY-2-L-975", 974, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6401), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("08564cb2-61de-40e9-899b-a0dff9bfe2ad"), "CHLY-2-L-974", 973, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6396), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("d3e0abd1-6726-4416-ad2a-fb10efaf6924"), "CHLY-2-L-973", 972, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6392), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("5d694da7-6063-4f92-aa3a-191a21636344"), "CHLY-2-L-943", 942, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6250), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("263c6612-6a7a-47f0-8b87-22ea13c56575"), "CHLY-2-L-944", 943, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6254), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("eefda5e2-4ace-45eb-ab93-aa1ea3797c0e"), "CHLY-2-L-945", 944, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6260), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("213219ab-d51b-4c4e-9999-48b58b4b043b"), "CHLY-2-L-946", 945, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6267), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("bedfca1a-dc0d-475e-8391-0d842e00ac9e"), "CHLY-2-L-947", 946, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6271), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c7d3ca07-9c98-469e-8cdd-cd2c9848b2de"), "CHLY-2-L-948", 947, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6276), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("74e3ef62-3755-4acc-8f3b-f0c7c0b6187a"), "CHLY-2-L-949", 948, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6280), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c3b5fc08-7653-4866-9733-992054973c34"), "CHLY-2-L-950", 949, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6284), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("d2065220-75af-4845-9791-32e4be92be91"), "CHLY-2-L-951", 950, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6288), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("22c38c87-483b-483e-976e-301ab11817c7"), "CHLY-2-L-952", 951, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6293), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f2bea811-b670-446c-a880-c2eedca62149"), "CHLY-2-L-953", 952, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6298), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("3ab2b947-fca8-4ccd-8522-0b87c20d9927"), "CHLY-2-L-954", 953, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6304), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("85fa1c35-1f13-4aa6-87f3-1b188dc5a2ec"), "CHLY-2-L-955", 954, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6308), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c0d6e6a1-5f95-41a8-9557-5759783a0a18"), "CHLY-2-L-956", 955, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6313), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a4ce7d73-ef7d-44e0-b123-cb4f888be45c"), "CHLY-2-L-1006", 1005, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6614), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("02156e18-45b5-40b1-9f15-c4c3725b538e"), "CHLY-2-L-957", 956, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6317), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("5d99a1c0-ad26-48e6-9196-4de412b44bab"), "CHLY-2-L-959", 958, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6325), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("8b525c2c-7814-436c-aec7-b5f445d4c398"), "CHLY-2-L-960", 959, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6330), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("7ec54e86-c632-493b-98b0-6070102c4caa"), "CHLY-2-L-961", 960, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6334), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("1eb4fd94-ffd7-4203-8414-6c8bd9a35163"), "CHLY-2-L-962", 961, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6341), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("eaf0bd38-d017-4808-9a6e-6448a87d8624"), "CHLY-2-L-963", 962, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6345), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("0da4e21a-3a85-4c5d-b1c2-0c72eba11cb6"), "CHLY-2-L-964", 963, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6349), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("d15aeb15-4fe7-482a-95af-e91a82bdc00b"), "CHLY-2-L-965", 964, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6354), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("1234e77c-aba6-47ce-b0d6-5be7f7d791ce"), "CHLY-2-L-966", 965, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6358), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("2035ac34-63c3-4e89-87b2-128a82a98761"), "CHLY-2-L-967", 966, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6363), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("7496d5f6-5891-48de-81e5-7a0ca65c4e3a"), "CHLY-2-L-968", 967, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6367), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c16e2dd1-2129-4df9-bbd5-3d64f30e5498"), "CHLY-2-L-969", 968, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6371), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("167b9074-4207-48e8-9826-5ab952fedac8"), "CHLY-2-L-970", 969, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6379), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e76e59c2-1067-401a-972d-88aa29b475f3"), "CHLY-2-L-971", 970, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6384), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("48e559f0-5204-41e9-8521-04947700256c"), "CHLY-2-L-972", 971, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6388), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("410fa392-cdf2-47ac-a5f2-519a5d78a5be"), "CHLY-2-L-958", 957, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6321), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("92d57f5f-113d-4748-b1e5-be2beab8dc87"), "CHLY-2-L-942", 941, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6245), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("3c419bfa-5761-4c9c-b8c6-c9eaf3b9c836"), "CHLY-2-L-1007", 1006, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6621), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("82624268-dc27-4141-b2c0-a770b660fbbf"), "CHLY-2-L-1009", 1008, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6637), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b95a135b-1d39-40ec-adfa-c58aa4ceacb5"), "CHLY-2-L-1044", 1043, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7285), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("20e797c4-7585-4db4-bf50-8bd515072315"), "CHLY-2-L-1045", 1044, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7298), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4dc0fe53-309f-4d97-91ff-8a102fc01c1c"), "CHLY-2-L-1046", 1045, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7310), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ec3c051a-1f55-40a5-b1fa-62f87b2db365"), "CHLY-2-L-1047", 1046, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7322), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("95f20196-85eb-431e-bd2e-83516daf2340"), "CHLY-2-L-1048", 1047, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7334), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("5ea4b1f8-e19f-4d2f-af23-179177afbe9e"), "CHLY-2-L-1049", 1048, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7346), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("3b53d450-eca1-4ab0-a97e-05cdc1452e23"), "CHLY-2-L-1050", 1049, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7365), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f663eb97-9e89-46fc-a500-41717c577a8d"), "CHLY-2-L-1051", 1050, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7378), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("794d3e88-5bb0-4bdc-8732-a1b69ab513d6"), "CHLY-2-L-1052", 1051, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7394), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4cbe9fd0-4dd7-4b18-a607-b32b22efc0fe"), "CHLY-2-L-1053", 1052, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7405), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("641e0432-f8ec-41ae-b625-0846b34adc18"), "CHLY-2-L-1054", 1053, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7418), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("960a9268-3e65-4f73-9fca-7e2f7023dd1c"), "CHLY-2-L-1055", 1054, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7432), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("99dff0c4-c709-4989-aee5-35e9963b2bd1"), "CHLY-2-L-1056", 1055, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7445), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("3a9565fc-422a-4dd9-8beb-07656f6409d6"), "CHLY-2-L-1057", 1056, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7458), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("04556e51-3957-4ec0-b081-056dc74b8135"), "CHLY-2-L-1058", 1057, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7475), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("cca5ba80-b18d-42af-a6e7-656c1a286d45"), "CHLY-2-L-1059", 1058, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7492), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("0b1e5ce6-0374-4c12-b648-8ffcbd861223"), "CHLY-2-L-1060", 1059, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7507), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("137e0172-a236-4072-8294-753d9de0d5bc"), "CHLY-2-L-1061", 1060, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7519), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ecb71a66-7769-4cc2-953c-36a9a0ae2d28"), "CHLY-2-L-1062", 1061, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7534), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("3dcab791-d3c1-4380-bd1c-260ba3d9bea6"), "CHLY-2-L-1063", 1062, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7546), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("124038ec-3b16-46c8-bbd8-111c25becc8b"), "CHLY-2-L-1064", 1063, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7558), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("913767c4-be17-4c59-aecf-19e3553cfd3d"), "CHLY-2-L-1065", 1064, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7571), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("14c6611b-cced-485e-be50-791015661d25"), "CHLY-2-L-1066", 1065, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7587), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("077f54b4-c60a-4bd0-b796-a4f76197888c"), "CHLY-2-L-1067", 1066, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7601), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("223e713c-cbf8-4cef-92d3-61521943ac76"), "CHLY-2-L-1068", 1067, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7615), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("dbf4ecd1-7e07-45d9-88d0-a7175d7d8241"), "CHLY-2-L-1069", 1068, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7628), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("45db7c6b-abf8-49de-aab2-201c4428453a"), "CHLY-2-L-1070", 1069, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7641), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("68a24940-0097-4c6f-b841-72f359053315"), "CHLY-2-L-1071", 1070, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7653), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("83cb5910-e10d-4449-a3ae-ffb48c13d5fb"), "CHLY-2-L-1072", 1071, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7666), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("83f05c97-cd8d-4f2c-86a7-02eeebb190c3"), "CHLY-2-L-1043", 1042, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7271), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e2dd8ddb-9f9e-460e-8d2b-9bb28473d5b1"), "CHLY-2-L-1042", 1041, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7257), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("5d5a7616-cfd6-4d17-a2c8-6a1a822cb752"), "CHLY-2-L-1041", 1040, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7242), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("219615f6-0508-4b90-a602-58e2180e126d"), "CHLY-2-L-1040", 1039, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7235), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("7aefd5d1-b7a8-48be-a572-063e53f20f1b"), "CHLY-2-L-1010", 1009, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6649), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f9ee32d2-ecbf-4d5e-9d42-8fad5ea5410f"), "CHLY-2-L-1011", 1010, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6657), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("487503cc-cf6a-43b6-b577-730ba62ee7a6"), "CHLY-2-L-1012", 1011, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6665), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("64fa558d-eccd-4563-b7fa-3f4aee5107ea"), "CHLY-2-L-1013", 1012, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6720), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("069d9744-03be-4684-8463-72bad79a51b6"), "CHLY-2-L-1014", 1013, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6727), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e65f98c1-de84-42a2-9a0e-f0044d84a5c3"), "CHLY-2-L-1015", 1014, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6734), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c3aecdfd-fd0c-484b-95c9-79547fc53f68"), "CHLY-2-L-1016", 1015, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6741), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c5a1c119-7a0a-4d27-86d6-1efcb4a3f5ae"), "CHLY-2-L-1017", 1016, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6748), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("efb321fd-6e6f-47f5-8ceb-296a5c913513"), "CHLY-2-L-1018", 1017, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6759), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("7a3abfec-1f3f-4ef8-9774-07b730401490"), "CHLY-2-L-1019", 1018, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6767), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("60e77d5c-8ba2-4962-885a-b816d5fbd45d"), "CHLY-2-L-1020", 1019, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6776), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("3ae0143a-4551-4016-bd4f-4006f36b5e88"), "CHLY-2-L-1021", 1020, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6784), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("02296f57-603f-4d87-a968-5962110a8384"), "CHLY-2-L-1022", 1021, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6792), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("1d4d3a69-9029-435b-a3e3-e94254acbde7"), "CHLY-2-L-1023", 1022, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6799), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f9b87050-f749-4e18-ae18-c65225b69736"), "CHLY-2-L-1008", 1007, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6629), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("5f3ad2e4-a718-49b7-acba-0583d6ba53e7"), "CHLY-2-L-1024", 1023, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6807), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("885231da-a486-4d4a-b594-eb7550d53933"), "CHLY-2-L-1026", 1025, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6830), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("0e2ca993-506b-4989-b40f-a80934c9df4d"), "CHLY-2-L-1027", 1026, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7016), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f5dd6b40-8c32-4407-8f01-774b9d35c168"), "CHLY-2-L-1028", 1027, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7026), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ef9ed929-6756-4b80-8a5a-a2d9a6c5ba55"), "CHLY-2-L-1029", 1028, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7035), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("d6ab13d6-4ceb-4a15-a40d-c263ef4488ea"), "CHLY-2-L-1030", 1029, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7070), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("7dc61853-5019-459d-9799-28758537f2b8"), "CHLY-2-L-1031", 1030, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7080), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f58cb1ff-e7dd-422d-8fa0-f62bb8088a76"), "CHLY-2-L-1032", 1031, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7088), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("5e84edd7-6aec-4b12-a46f-6d38d5e0d223"), "CHLY-2-L-1033", 1032, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7095), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e4fa113d-02cf-472a-9df9-a79dc86eeb3e"), "CHLY-2-L-1034", 1033, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7108), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("cbee2a5d-926f-4021-a27d-e2eac2e757aa"), "CHLY-2-L-1035", 1034, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7117), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("aa916efa-7133-475d-b3b6-afdf9a2f8851"), "CHLY-2-L-1036", 1035, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7132), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("d3cbf915-97e1-46ad-8f67-5c613db507a9"), "CHLY-2-L-1037", 1036, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7214), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e6dd7432-f066-4917-991f-76e3201bbbcd"), "CHLY-2-L-1038", 1037, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7222), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("7e5518f3-5385-440b-b92a-082f5af2664d"), "CHLY-2-L-1039", 1038, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7229), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("597d40d9-8b51-4227-95c9-36eadaa97e57"), "CHLY-2-L-1025", 1024, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6816), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("d5b7c414-05a5-417b-beda-3a8755e642b2"), "CHLY-2-L-941", 940, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6241), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ccc627dc-e610-4ae9-bb7a-31b4e4bd0e92"), "CHLY-2-L-940", 939, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6237), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("493610d6-d7f2-4c73-a25a-8a9b036dc7f4"), "CHLY-2-L-939", 938, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6231), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4315bf04-9d46-4581-8420-cc2591cd4bcd"), "CHLY-2-L-842", 841, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5659), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c678a7bd-367a-4a95-9c23-e8a392577817"), "CHLY-2-L-843", 842, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5664), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("31b34f92-7cbc-4eb3-a2e0-d5470e956106"), "CHLY-2-L-844", 843, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5668), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("d7b643e8-2920-4b0a-88a9-b8d7382bc1ae"), "CHLY-2-L-845", 844, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5673), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f01e6820-7d87-44d2-a469-21ef0862df6b"), "CHLY-2-L-846", 845, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5677), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("05a90edc-f844-4d30-b5fb-fda66fbd000f"), "CHLY-2-L-847", 846, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5682), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a315a241-cc25-4d23-a893-a201c82873b1"), "CHLY-2-L-848", 847, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5686), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("9ebe87a5-8965-4735-82ee-6c77346a610e"), "CHLY-2-L-849", 848, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5690), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("53175ae3-1b46-4c03-bcbc-ee460ad8641e"), "CHLY-2-L-850", 849, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5696), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("bd0aec76-2ff5-4e86-8842-e362daf8420d"), "CHLY-2-L-851", 850, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5700), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("957a94c1-d024-4155-931b-51721323a470"), "CHLY-2-L-852", 851, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5704), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("00b0dd0e-310a-4ed1-bdbb-74b8c288eef4"), "CHLY-2-L-853", 852, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5709), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("8deff9e1-5c06-4e28-8410-5651ce77e6b8"), "CHLY-2-L-854", 853, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5714), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("8201a765-7f3f-462c-87f3-277ddfcbf28f"), "CHLY-2-L-855", 854, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5718), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c7a4e1c0-1fb6-4475-a021-873287f86835"), "CHLY-2-L-856", 855, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5722), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e0afe803-9189-44f1-aa60-f43ab733af86"), "CHLY-2-L-857", 856, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5726), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("cac4fbbc-a0e7-42d0-9883-143b74171a62"), "CHLY-2-L-858", 857, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5732), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("551aa2a2-da64-458f-b6b0-35a75ff66a6f"), "CHLY-2-L-859", 858, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5736), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("7b2d13d7-cc97-4efc-b7b7-211cc45ac51a"), "CHLY-2-L-860", 859, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5741), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6ef4201f-b699-4c73-a181-6646525439d1"), "CHLY-2-L-861", 860, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5746), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("31706221-ace6-4aad-9ddd-3b0a102a5264"), "CHLY-2-L-862", 861, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5750), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f6ffcb24-bb8f-4adc-817f-190e11890aed"), "CHLY-2-L-863", 862, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5754), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6004d687-988e-4404-bc6f-de70861a0f79"), "CHLY-2-L-864", 863, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5759), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e7248be3-edfe-485a-b1b4-f7dcb23c99d5"), "CHLY-2-L-865", 864, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5763), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e132431f-6534-4b65-80a9-f5c78e0711ea"), "CHLY-2-L-866", 865, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5769), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4c269ecc-d878-43f3-bba3-87b68ed29d97"), "CHLY-2-L-867", 866, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5815), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("58fc4609-5759-48ef-97c5-91c0e7cdcab1"), "CHLY-2-L-868", 867, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5821), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b69a4876-74c3-4967-ada2-81001e662056"), "CHLY-2-L-869", 868, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5826), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("74d908ff-82d0-4c8d-93fb-c3e38556c8aa"), "CHLY-2-L-870", 869, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5830), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("13bc4847-3d76-44bf-bc59-f644441bb691"), "CHLY-2-L-841", 840, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5653), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("892ede7e-c8fa-484c-b62f-6a8fbba136bc"), "CHLY-2-L-840", 839, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5649), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("fc0e45b1-755c-4494-88ad-1f06da8842dc"), "CHLY-2-L-839", 838, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5644), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("86d32df8-dd2e-4b20-b097-42b204aef208"), "CHLY-2-L-838", 837, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5640), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6ee0d954-241a-43e5-86b9-4f92d86e0cc9"), "CHLY-2-L-808", 807, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5450), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("afcd2019-39d8-4cd3-938f-7077cba46059"), "CHLY-2-L-809", 808, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5455), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("340e620e-8f9c-4cfb-a17f-ee178f11f368"), "CHLY-2-L-810", 809, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5503), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("21d9473a-e057-4908-b785-751718b51132"), "CHLY-2-L-811", 810, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5509), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ba81c59c-06cf-40d7-a123-a8172c442405"), "CHLY-2-L-812", 811, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5513), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("001deaec-44cf-4110-98af-7e799fced7b4"), "CHLY-2-L-813", 812, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5518), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("7f53270e-4ac7-430a-974f-92d9705a4f3a"), "CHLY-2-L-814", 813, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5523), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("fc3972d8-c5c5-4abe-a3d3-009da69d2487"), "CHLY-2-L-815", 814, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5527), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c3292b05-9912-433b-bbf1-21dd505e6cdf"), "CHLY-2-L-816", 815, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5531), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("804eb3bb-2d03-4e1a-9ab3-431fc3a62c22"), "CHLY-2-L-817", 816, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5536), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("376c667a-74b2-4484-a104-0c60cd79f219"), "CHLY-2-L-818", 817, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5542), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ccb5a8bd-da39-42b6-b329-14949f57b427"), "CHLY-2-L-819", 818, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5547), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b8aca821-a884-4b53-a06a-98359b15c14c"), "CHLY-2-L-820", 819, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5551), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("80377c51-4243-4fb9-b4d0-96b5f7a7a91f"), "CHLY-2-L-821", 820, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5556), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ee2ad184-7493-4445-bb19-70de66642728"), "CHLY-2-L-871", 870, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5834), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("530b358d-7d00-494b-af7b-4bb51f1790c4"), "CHLY-2-L-822", 821, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5561), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("77d95f69-5835-45f0-8de9-b7efd7353e37"), "CHLY-2-L-824", 823, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5570), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("369d1464-c61f-4d6d-aca1-f0853f7d4c6c"), "CHLY-2-L-825", 824, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5574), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f775b443-a6fa-49ac-be3b-da6eb654b8f4"), "CHLY-2-L-826", 825, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5581), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("8b84587e-fc0f-430b-acb2-29eb74aef60c"), "CHLY-2-L-827", 826, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5586), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6e79a65b-5610-4742-a921-3f9b5a3b4205"), "CHLY-2-L-828", 827, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5590), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6fe1eb42-b962-4ed7-8100-65728b74734a"), "CHLY-2-L-829", 828, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5594), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("2c12daeb-5970-467e-bd22-b1043027f187"), "CHLY-2-L-830", 829, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5599), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("3d32fba6-ed76-4fe4-b7d1-872cd1666679"), "CHLY-2-L-831", 830, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5603), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("13bc40bd-fec2-4f1b-a4bf-68216866351e"), "CHLY-2-L-832", 831, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5608), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c8a9e9a7-197f-4ef3-8f4c-f205949cdb4e"), "CHLY-2-L-833", 832, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5613), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("89bbc231-c142-4551-9237-ad1d9beb37e6"), "CHLY-2-L-834", 833, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5620), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("7fbd3629-7b77-494e-a6b4-7f0769dde49e"), "CHLY-2-L-835", 834, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5624), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("2cfc2637-a589-4cda-852a-187a7f6a9269"), "CHLY-2-L-836", 835, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5629), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("95952007-aec8-48fb-9fdb-a21d6b5a2ff2"), "CHLY-2-L-837", 836, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5636), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("762eca00-3087-4a64-bbcf-a8bda526fd63"), "CHLY-2-L-823", 822, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5565), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("9d5c6395-c912-4fe8-be30-19f47cbf4e96"), "CHLY-2-L-872", 871, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5838), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a5515321-b6fc-4bae-abc3-6075c17daf62"), "CHLY-2-L-873", 872, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5842), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("5874a386-747e-4149-b8bc-c40c1829f079"), "CHLY-2-L-874", 873, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5849), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("0ffc3efe-a77c-46e3-b0c6-ae86b9a387c1"), "CHLY-2-L-909", 908, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6019), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("cfc2b96b-d0b5-4aa8-867e-39ffbc7dfce0"), "CHLY-2-L-910", 909, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6023), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("5d58bad5-f9f4-41b6-badf-89a43d3520af"), "CHLY-2-L-911", 910, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6028), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("9702605d-88dc-4966-8069-755ebd3a8df8"), "CHLY-2-L-912", 911, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6032), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("1594296c-024b-4671-be5a-446f3ae973b9"), "CHLY-2-L-913", 912, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6037), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("5a7d9f40-eb91-4999-bba3-b6f3ab14b270"), "CHLY-2-L-914", 913, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6046), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("7fab2792-a22a-42b5-8322-6a804a911e86"), "CHLY-2-L-915", 914, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6050), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("53b5d9d8-5ed6-4952-a292-40c357a42a9f"), "CHLY-2-L-916", 915, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6055), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("aa44a61a-e827-4154-aa2f-85fc8f45f725"), "CHLY-2-L-917", 916, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6059), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("34031312-c042-43f1-b5f3-dac7cb1f9a87"), "CHLY-2-L-918", 917, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6069), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("69579acc-d5da-4090-a597-a7a167955d52"), "CHLY-2-L-919", 918, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6073), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c0788b13-3d33-48a9-b7f2-261b61c4cad7"), "CHLY-2-L-920", 919, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6077), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("fca7f595-b2f7-4c2c-a77e-7990b66964a9"), "CHLY-2-L-921", 920, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6082), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("3efecc59-d5e4-4293-971b-82c35bace12f"), "CHLY-2-L-922", 921, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6096), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("21edc997-78c4-4bfb-a225-b3b8dfbcf4c5"), "CHLY-2-L-908", 907, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6015), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("2e4d4984-8fea-4c90-88ca-4643e89e1b68"), "CHLY-2-L-923", 922, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6101), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("62efb331-59be-469a-a9fe-b62525dcfa6c"), "CHLY-2-L-925", 924, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6165), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ba5cb5e1-31ec-4e6c-8d21-7f2ec099091e"), "CHLY-2-L-926", 925, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6169), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("3bee798c-c17d-473d-bd51-eb90e7e1ac2c"), "CHLY-2-L-927", 926, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6173), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("812bec13-7e08-44a0-a360-9f8b98d1957e"), "CHLY-2-L-928", 927, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6177), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("96ddfc4d-af7b-4caa-a37a-55c29f717add"), "CHLY-2-L-929", 928, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6182), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b6e61a78-97c9-4e20-8627-8a909abcc16c"), "CHLY-2-L-930", 929, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6189), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("955c3d83-83bc-493a-a4f2-97f848933456"), "CHLY-2-L-931", 930, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6193), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("82108a5d-ff04-4efb-8fdd-385d2930dcd6"), "CHLY-2-L-932", 931, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6197), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("9bcc618b-8a17-4842-96d7-3e15d41a324c"), "CHLY-2-L-933", 932, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6202), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("7e4136bd-788e-4c9c-8c05-4e3b0986ec42"), "CHLY-2-L-934", 933, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6206), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("1f38118c-00da-4863-9565-6356c9102c65"), "CHLY-2-L-935", 934, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6210), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("600e1667-b88c-4427-b464-7d16f4ec8327"), "CHLY-2-L-936", 935, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6214), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e9d62447-8395-492a-be56-c14d9c137b77"), "CHLY-2-L-937", 936, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6219), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("096c44e7-a657-4b6f-845b-6037ff12ee8c"), "CHLY-2-L-938", 937, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6226), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("9beeb5be-1283-4646-84a9-12a21c726c2c"), "CHLY-2-L-924", 923, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6160), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("0d516e1d-600d-4a00-9027-10b96aa4f7ab"), "SD-3-L-539", 538, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4008), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("9764f853-ab73-404c-94a4-acb43261c235"), "CHLY-2-L-907", 906, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6010), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("68e1414d-2e19-4188-b8f3-deaab11ecb24"), "CHLY-2-L-905", 904, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5998), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("69d8be29-32f3-4060-a7e2-22ddd38f65b7"), "CHLY-2-L-875", 874, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5853), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("08e77e31-8c86-4367-954f-186c92c8e7fd"), "CHLY-2-L-876", 875, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5858), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("669306ab-d393-4247-b152-a20eac05d17b"), "CHLY-2-L-877", 876, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5863), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("5199baf5-acfc-4df7-972d-1d883ee4c18c"), "CHLY-2-L-878", 877, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5867), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f45d7c73-7fd1-4a99-81d1-d7573b153d26"), "CHLY-2-L-879", 878, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5871), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("aeaa1847-018d-4c30-be6f-fa63e5cde7dd"), "CHLY-2-L-880", 879, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5875), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("5f9d54bb-79b1-4630-aca4-d234875b719a"), "CHLY-2-L-881", 880, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5880), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a4a7709c-db70-44cf-9a2c-57e92cf3fec5"), "CHLY-2-L-882", 881, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5886), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("dba9c07d-768e-4176-80ca-127d2b51dbb8"), "CHLY-2-L-883", 882, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5892), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ed198145-8ed4-4378-ba21-c16406ec3dcf"), "CHLY-2-L-884", 883, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5896), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("33cf7961-6b40-4814-b09a-ea3bf5bf6f07"), "CHLY-2-L-885", 884, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5900), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6dc950d0-fb26-4813-b385-ef0034709a2d"), "CHLY-2-L-886", 885, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5904), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("82b16e67-1219-4156-a0de-106db75397ec"), "CHLY-2-L-887", 886, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5908), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("2fb69673-7cf9-41d0-a842-5295df624328"), "CHLY-2-L-888", 887, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5913), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("639bab1e-341e-4e8c-97ca-17cd1823cda5"), "CHLY-2-L-906", 905, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(6006), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("8153874f-d63f-4447-91d8-9da0ddff3d46"), "CHLY-2-L-889", 888, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5917), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("aeee8cbe-9fd5-4700-bf31-2c6c42e5152f"), "CHLY-2-L-891", 890, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5928), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b2581c4d-086a-4643-a9d8-81474b51b216"), "CHLY-2-L-892", 891, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5932), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ee9a2a6b-c50c-4ad0-a619-7aab4ee0aebf"), "CHLY-2-L-893", 892, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5937), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6d1e3505-61b0-4e7f-a7b5-a3041ea25037"), "CHLY-2-L-894", 893, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5941), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("2500e589-c95c-493e-805f-bd4ee9cd9f17"), "CHLY-2-L-895", 894, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5946), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("668cbd41-0ff8-406b-af3b-14c0d37f5d22"), "CHLY-2-L-896", 895, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5953), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("af7abc87-48b0-40dc-9d8d-0f9897059f56"), "CHLY-2-L-897", 896, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5957), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b487f9c4-cf24-4625-98c8-8254f9deee8a"), "CHLY-2-L-898", 897, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5964), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6f652f03-2a97-40e9-ad00-0a87d05fe79d"), "CHLY-2-L-899", 898, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5972), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c09219fa-af7e-475e-b6c6-63dc9a13bb69"), "CHLY-2-L-900", 899, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5977), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("adf22e07-23cc-4a68-886f-163257ffc5b4"), "CHLY-2-L-901", 900, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5981), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ac65602b-eab2-467b-b956-6b42f26c7435"), "CHLY-2-L-902", 901, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5985), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ef05e309-3bf5-4471-9729-7a7c6ce41021"), "CHLY-2-L-903", 902, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5989), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e0c7dd93-19ba-4958-8eb7-c95e9c0e7bfc"), "CHLY-2-L-904", 903, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5994), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("91431e71-2897-42de-b8d8-1a1afac692bf"), "CHLY-2-L-890", 889, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(5923), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b1867cf4-5695-444c-88d6-6f879fa6536b"), "SD-3-L-538", 537, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(4003), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("0873b37e-cda3-4423-95c6-9216dd5c756b"), "SD-3-L-537", 536, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3997), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("78951cf3-60f6-4fc1-a079-09e3b56e4bff"), "SD-3-L-536", 535, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3993), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("441c8e7a-9e17-41a6-8948-2d7c260497d0"), "FD-1-L-171", 170, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1652), "Crab", "Layes", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e457fab4-7cf9-4a67-81a7-60497f7631d2"), "FD-1-L-172", 171, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1656), "Crab", "Layes", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4bb5adbc-c665-4ab5-8048-2d6c248bc592"), "FD-1-L-173", 172, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1661), "Crab", "Layes", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("603c1a9b-4d5f-4071-b4c1-7c80faa2cae2"), "FD-1-L-174", 173, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1665), "Crab", "Layes", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("214e5638-e73a-4c29-bcfe-2f144ec24361"), "FD-1-L-175", 174, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1670), "Crab", "Layes", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("762ef9c5-9c26-4104-80f4-35d1a4e1604f"), "FD-1-L-176", 175, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1674), "Crab", "Layes", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("95c35f24-219e-4b00-b363-c61fc15aedfe"), "FD-1-L-177", 176, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1678), "Crab", "Layes", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f9a67a36-29fc-4e80-9ff2-6d550484ff05"), "FD-1-L-178", 177, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1685), "Crab", "Layes", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("996b8b09-a74d-4092-915c-5a1dcfa5dae3"), "FD-1-L-179", 178, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1690), "Crab", "Layes", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("8a2f9bff-efb0-44a4-b1a4-62dad8c07318"), "FD-1-L-180", 179, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1698), "Crab", "Layes", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c8287d67-ea3e-4b87-a7a7-66141e98be2e"), "FD-1-L-181", 180, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1702), "Crab", "Layes", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("d64f01dd-e28b-4a06-bdbc-1af7fe3fca31"), "FD-1-L-182", 181, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1706), "Crab", "Layes", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ca54858f-2410-4a4b-b114-8e6474261df2"), "FD-1-L-183", 182, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1710), "Crab", "Layes", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c8b03957-d0ec-4f27-9b69-43c70d5bc003"), "FD-1-L-184", 183, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1715), "Crab", "Layes", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("57e21092-ce04-4712-b3bf-7dd8a7158d52"), "FD-1-L-185", 184, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1719), "Crab", "Layes", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("04153407-68cf-459f-8d2f-04edbcbe7d64"), "FD-1-L-186", 185, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1726), "Crab", "Layes", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("581c696f-d6a7-40c5-81c3-7b30838f8d54"), "FD-1-L-187", 186, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1730), "Crab", "Layes", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b48500ba-b261-4548-a63e-3d239bed887c"), "FD-1-L-188", 187, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1736), "Crab", "Layes", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b2abcdb3-cf6b-4464-a71a-3e1eafeb3756"), "FD-1-L-189", 188, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1741), "Crab", "Layes", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("1ed625f2-141b-42f5-ba9d-12ce622283f9"), "FD-1-L-190", 189, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1745), "Crab", "Layes", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("743e30f6-e7ec-46d8-a5dd-58d7b720ea71"), "FD-1-L-191", 190, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1749), "Crab", "Layes", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e000a517-5b80-4b38-83ae-d2af9b159fc7"), "FD-1-L-192", 191, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1753), "Crab", "Layes", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f6f19356-98a8-4ca4-9fe6-63bf4be419ff"), "FD-2-L-193", 192, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1758), "Crab", "Layes", new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e9b3cb73-5adf-4859-bf69-624a9d65d1e8"), "FD-2-L-194", 193, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1765), "Crab", "Layes", new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("0944a515-b294-4cfe-bb11-0ec7850e69ef"), "FD-2-L-195", 194, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1769), "Crab", "Layes", new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("00694430-a963-4d72-90cd-f294c9e0abfd"), "FD-2-L-196", 195, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1775), "Crab", "Layes", new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("2f24ce9e-f819-4b21-a554-737b113a0460"), "FD-2-L-197", 196, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1779), "Crab", "Layes", new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("0a2b12d9-63b7-4fd6-8712-3943aaae3047"), "FD-2-L-198", 197, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1783), "Crab", "Layes", new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4b8af1ae-9863-4477-b037-3ddf693e799a"), "FD-2-L-199", 198, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1787), "Crab", "Layes", new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ca978604-6ee1-4a19-afa4-7c9bc51a2482"), "FD-1-L-170", 169, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1647), "Crab", "Layes", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("8c700267-ae7e-4bc7-982d-fcf607065466"), "FD-1-L-169", 168, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1640), "Crab", "Layes", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f4ac8a50-7539-42d3-a7cd-cac98c2b194a"), "FD-1-L-168", 167, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1636), "Crab", "Layes", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("cbb20627-c0f7-40d6-b94a-ef239732283f"), "FD-1-L-167", 166, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1632), "Crab", "Layes", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ef2969f2-3ba8-4c32-80f0-4b9a54f528c0"), "FD-2-L-137", 136, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1436), "Onion", "Layes", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("37ad2aa8-ef93-4f43-96ac-4784a0ca1168"), "FD-2-L-138", 137, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1443), "Onion", "Layes", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b72df52a-a778-48fd-9d48-c5d253b74bea"), "FD-2-L-139", 138, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1448), "Onion", "Layes", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f851307c-8561-4c13-a2fc-68f7bcd00f9b"), "FD-2-L-140", 139, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1452), "Onion", "Layes", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e7dda129-b5b5-4110-b4b9-61a90e347081"), "FD-2-L-141", 140, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1457), "Onion", "Layes", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("9986d2ca-80e3-4a04-b159-4dfcd8fcce4b"), "FD-2-L-142", 141, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1462), "Onion", "Layes", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("d8204698-885f-4bdd-a92d-fc17321325f7"), "FD-2-L-143", 142, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1466), "Onion", "Layes", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("699bd468-f6c9-4381-b9db-35f2741f23bc"), "FD-2-L-144", 143, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1471), "Onion", "Layes", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b2359cf6-7bbb-4850-bc1c-4484cb81410c"), "FD-2-L-145", 144, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1475), "Onion", "Layes", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("85f471b6-62e9-4239-8d67-35f0cafcb87e"), "FD-2-L-146", 145, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1483), "Onion", "Layes", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("3f0fd6aa-1c48-4b69-9bda-4d8e13307f35"), "FD-2-L-147", 146, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1487), "Onion", "Layes", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("5b081437-fcd2-4af4-aa87-5a762ba79ffb"), "FD-2-L-148", 147, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1491), "Onion", "Layes", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e5876669-665f-42f5-9901-d7730a585553"), "FD-2-L-149", 148, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1497), "Onion", "Layes", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4db3678f-b5ef-4712-b513-5860ed2b803d"), "FD-2-L-150", 149, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1502), "Onion", "Layes", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("fe008001-ec66-4f4e-9653-e9fe27758cf1"), "FD-2-L-200", 199, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1792), "Crab", "Layes", new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("7bc5d18c-0cb0-42a8-b13e-11cff56ae901"), "FD-2-L-151", 150, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1506), "Onion", "Layes", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("69dd660b-5001-4696-9861-9db56e22b3ed"), "FD-2-L-153", 152, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1515), "Onion", "Layes", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6379289f-4dd8-4279-95e5-b0f2dd4e38dc"), "FD-2-L-154", 153, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1522), "Onion", "Layes", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("fe83c18a-92cf-4d25-a30a-9ad9b725ebbc"), "FD-2-L-155", 154, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1526), "Onion", "Layes", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("525cd3e3-f3a0-4a45-921f-b47fab45412e"), "FD-2-L-156", 155, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1531), "Onion", "Layes", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c73b73da-8787-4012-937f-88c9ef1bc57b"), "FD-2-L-157", 156, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1536), "Onion", "Layes", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("d62d0c01-2474-42ee-b5be-13fc91d483e4"), "FD-2-L-158", 157, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1584), "Onion", "Layes", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("7e932f6b-b43c-46e8-9323-d5682a10b02d"), "FD-2-L-159", 158, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1589), "Onion", "Layes", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4193c66d-e168-45aa-9a95-e15b42d7dce3"), "FD-2-L-160", 159, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1595), "Onion", "Layes", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("fc958373-faf9-4c83-adeb-dc87a4773b2a"), "FD-2-L-161", 160, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1599), "Onion", "Layes", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ae57ab95-301d-45df-bd73-6024fd813343"), "FD-1-L-162", 161, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1607), "Crab", "Layes", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("be7d81f1-05da-49cf-8b2a-9c410641e459"), "FD-1-L-163", 162, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1612), "Crab", "Layes", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c1700259-886c-4483-a298-443a14625c3c"), "FD-1-L-164", 163, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1616), "Crab", "Layes", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4e052172-e232-46b1-8f2b-82b31a3ff8f1"), "FD-1-L-165", 164, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1623), "Crab", "Layes", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("8a8b5f0d-2f40-4d77-9591-13870a42bbbb"), "FD-1-L-166", 165, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1627), "Crab", "Layes", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b9089cba-dcec-4615-9a24-edadef6fc6b4"), "FD-2-L-152", 151, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1511), "Onion", "Layes", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("97390d89-d4ba-4e66-a9f0-e1c48198d647"), "FD-2-L-136", 135, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1432), "Onion", "Layes", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f84f635b-2ad3-49c4-b3e8-7332be511397"), "FD-2-L-201", 200, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1796), "Crab", "Layes", new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("bcc98f08-acc4-403a-8944-51744113ef03"), "FD-2-L-203", 202, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1807), "Crab", "Layes", new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("882274eb-d26e-4af3-846b-a4d1e0f4a794"), "SD-3-L-238", 237, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2022), "Yellow Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4f91ef2e-41ef-4830-bb71-9334744d749f"), "SD-3-L-239", 238, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2026), "Yellow Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("cee8b144-cd04-4150-92a3-48e8ccd02c3c"), "SD-3-L-240", 239, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2030), "Yellow Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a9855871-1092-47d8-8500-a717b63492c3"), "SD-3-L-241", 240, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2035), "Yellow Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4c0566a0-85e6-4a08-9ece-353189479af5"), "SD-3-L-242", 241, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2042), "Yellow Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("fb4645e3-450e-4740-bdec-2c16eadba39d"), "SD-3-L-243", 242, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2047), "Yellow Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("fa2b8248-f120-4d63-9ce3-60d5eed3e98e"), "SD-3-L-244", 243, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2052), "Yellow Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("9351db28-6c29-4aa9-8147-d9a0f5c9534d"), "SD-3-L-245", 244, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2056), "Yellow Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("0760dbfe-c0aa-4c3e-b5f9-6b728dadf08b"), "SD-3-L-246", 245, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2060), "Yellow Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("0b2abb5d-e3f1-4894-b647-737a94aa2950"), "SD-3-L-247", 246, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2065), "Yellow Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ba78bee7-9af9-47bc-bd24-9fd83e1d1e0a"), "SD-3-L-248", 247, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2069), "Yellow Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("40e607bb-3e84-4a16-8dc5-1346cb61ee9b"), "SD-3-L-249", 248, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2073), "Yellow Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("98138ceb-ce7f-4c91-8503-a295948adcba"), "SD-3-L-250", 249, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2081), "Yellow Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("3cbe67a2-db71-43e5-b18d-b5a579418f17"), "SD-3-L-251", 250, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2086), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4c0e61a3-fa16-49f4-a0ff-50d1b55fc7cf"), "SD-3-L-252", 251, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2092), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("83d42258-5fca-47a0-a83c-deb44f814904"), "SD-3-L-253", 252, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2096), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a5bb4cf9-8268-4b2a-8c5e-9d130930466c"), "SD-3-L-254", 253, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2101), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("2decf6b4-e164-44de-86b4-22e9c02259d8"), "SD-3-L-255", 254, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2105), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("64231079-18ae-4128-9f2a-82eacd6a087e"), "SD-3-L-256", 255, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2110), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("59d4ebf8-0746-485d-8ad8-736afa9446f2"), "SD-3-L-257", 256, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2114), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("9ddcf0aa-d2e8-4b84-9216-7f426433d151"), "SD-3-L-258", 257, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2122), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("57836563-f23c-4814-a46e-0bc933a5ce63"), "SD-3-L-259", 258, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2183), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("62491921-1312-4c0c-b03d-49c51ab0bef0"), "SD-3-L-260", 259, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2189), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("002a3a83-edb3-44a7-80c3-8b26db257d5d"), "SD-3-L-261", 260, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2193), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6be01fe5-56c2-4ad9-8178-74771c21ed24"), "SD-3-L-262", 261, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2197), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("985947a5-78e0-4dee-ab97-99ebbd94227b"), "SD-3-L-263", 262, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2203), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f31472ab-6267-4560-a1c8-9054d36b3d17"), "SD-3-L-264", 263, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2207), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("449a578a-f3f2-4fa6-99d2-6c02f7ad8317"), "SD-3-L-265", 264, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2211), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("716d185f-1387-456b-aa7e-f43a27f387c0"), "SD-3-L-266", 265, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2219), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("177e53ad-494e-48f4-b143-9ef4c0001baa"), "SD-3-L-237", 236, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2017), "Yellow Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("5c9b4545-29d8-4be3-b85b-2b98acdac1d4"), "SD-3-L-236", 235, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2013), "Yellow Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a46f5a83-6e86-43a4-8c4c-0e201b867327"), "SD-3-L-235", 234, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2008), "Yellow Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("49df3e75-5311-4e75-9b25-508306d4c3c1"), "SD-3-L-234", 233, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2003), "Yellow Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b47f8752-8ad3-4b6a-b5cf-cabe568d40ed"), "FD-2-L-204", 203, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1811), "Crab", "Layes", new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("057aec60-ea96-4ceb-9280-9bd48416bd65"), "FD-2-L-205", 204, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1816), "Crab", "Layes", new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("9170baf5-dc40-4c62-9619-c47991629b28"), "FD-2-L-206", 205, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1820), "Crab", "Layes", new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4fe15030-5a34-4ba7-b4e5-c95601ad5f4d"), "SD-2-L-207", 206, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1824), "White Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 1m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6bb312d2-2840-449e-957a-5b54a3cf8c01"), "SD-2-L-208", 207, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1830), "White Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 1m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e6f6c023-d10b-4cc6-a900-42e46b32555a"), "SD-2-L-209", 208, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1834), "White Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 1m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ee5a2bba-b1aa-49a8-949d-0eb6af560bfb"), "SD-2-L-210", 209, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1841), "White Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 1m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("796577bc-19a2-4f08-a7b5-b0d693cedf5f"), "SD-2-L-211", 210, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1846), "White Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 1m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f0768c1b-bb33-4f71-8611-a82faa23475d"), "SD-2-L-212", 211, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1851), "White Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 1m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("95a14b65-2fe5-4eb1-ab78-9e0c59c7ca31"), "SD-2-L-213", 212, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1855), "White Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 1m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ee29947f-bbe2-453a-ab7d-36a41995308a"), "SD-3-L-214", 213, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1860), "White Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a251c76d-528b-4322-bfee-90194e65923f"), "SD-3-L-215", 214, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1907), "White Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("5721bac8-1920-4157-9d71-25e565efba31"), "SD-3-L-216", 215, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1912), "White Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("60835563-6d4a-4ef8-a8e5-1b4db0d1a4dc"), "SD-3-L-217", 216, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1917), "White Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("55a40f0e-bc66-499d-af22-389b3c8c2ac4"), "FD-2-L-202", 201, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1803), "Crab", "Layes", new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("bf7dde3c-3e4c-4713-998c-c1022798a741"), "SD-3-L-218", 217, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1924), "White Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ac99a761-aecb-4d50-87a9-1fd9900e05c0"), "SD-3-L-220", 219, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1934), "White Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("77d4a1f4-2526-4021-bd48-7df7e58fdf96"), "SD-3-L-221", 220, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1939), "White Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("cb1f1b2c-5448-4de6-846f-31caafd37151"), "SD-3-L-222", 221, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1943), "Yellow Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("2a31394d-e2e5-46d4-a30d-e5860539d7d1"), "SD-3-L-223", 222, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1948), "Yellow Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c923ad0a-5377-433d-8472-6466d3045a85"), "SD-3-L-224", 223, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1953), "Yellow Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ca36d4f4-4e70-4034-8cff-d0be0d1bb683"), "SD-3-L-225", 224, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1957), "Yellow Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("fc8a80a4-4ec1-4e40-a5c6-e80bb6f8eade"), "SD-3-L-226", 225, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1964), "Yellow Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b7b445b5-978d-464f-b49b-5812450da80d"), "SD-3-L-227", 226, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1969), "Yellow Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a32dc191-c37c-4dfe-b86b-28f3bdef5cac"), "SD-3-L-228", 227, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1974), "Yellow Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("25f07af2-82d1-4c37-8338-7f610721cedd"), "SD-3-L-229", 228, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1978), "Yellow Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("70b8472d-1784-40a9-9b76-52663e53b26c"), "SD-3-L-230", 229, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1983), "Yellow Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("251ed232-e466-4179-97e8-f769c2c81064"), "SD-3-L-231", 230, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1987), "Yellow Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ae2b00aa-f53c-4ccc-9ea6-718485615062"), "SD-3-L-232", 231, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1991), "Yellow Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("76b8d726-a359-4887-b5ed-b9e14793d1fc"), "SD-3-L-233", 232, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1996), "Yellow Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("0e8eb880-92ab-42aa-8e42-19ca418341be"), "SD-3-L-219", 218, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1929), "White Caesar", "Caesar", new Guid("3093a172-99dc-47cc-9802-1626e5ce625a"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("5c60fd8a-1978-45bd-8edd-8b7a3340e44b"), "FD-2-L-135", 134, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1427), "Onion", "Layes", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("60c6594f-3036-4b9d-a620-a5afdb1e187f"), "FD-2-L-134", 133, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1422), "Onion", "Layes", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b5d7842d-3301-44be-9ddf-43b30e84af88"), "FD-2-L-133", 132, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1417), "Onion", "Layes", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Food", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("7d7f3661-b3b0-46c4-a9b1-b7553fde6827"), "PC-2-CC-36", 35, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(824), "Not sugar", "Coca-cola", new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("84127764-671b-4f7d-ac8a-d5c3036b26c7"), "PC-2-CC-37", 36, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(828), "Not sugar", "Coca-cola", new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("8faa2fb7-af46-44db-a900-af24d90347a9"), "PC-2-CC-38", 37, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(832), "Not sugar", "Coca-cola", new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b56c4355-3b16-4674-bb78-68f045600ec0"), "PC-2-CC-39", 38, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(837), "Not sugar", "Coca-cola", new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ef8b015f-5b17-42f9-8405-73b527ee7e50"), "PC-2-CC-40", 39, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(842), "Not sugar", "Coca-cola", new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("658fc3d6-952d-4b18-9616-e130be7e8301"), "PC-2-CC-41", 40, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(847), "Not sugar", "Coca-cola", new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("7e11ff4b-608a-4d12-b977-e9914b3984c6"), "PC-2-CC-42", 41, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(853), "Not sugar", "Coca-cola", new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e81af116-963a-44c6-8a45-b07822a3e74c"), "PC-2-CC-43", 42, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(858), "Not sugar", "Coca-cola", new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("cbee3a6f-5962-4ae3-a010-c4d0ffbe709e"), "PC-2-CC-44", 43, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(862), "Not sugar", "Coca-cola", new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("8615d554-fb87-45b8-afbb-c59e8e252150"), "PC-2-CC-45", 44, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(876), "Not sugar", "Coca-cola", new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("70df9642-ad01-4e86-b369-ce828c616616"), "PC-2-CC-46", 45, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(881), "Not sugar", "Coca-cola", new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("2a0d619f-f417-4fa5-b604-ad5f391eb600"), "PC-1-F-47", 46, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(886), "Orange", "Fanta", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("5b7fb978-6422-449a-9a19-225d5fd9c69e"), "PC-1-F-48", 47, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(892), "Orange", "Fanta", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4fd61ccd-be31-4442-b695-b0a4a64a92f0"), "PC-1-F-49", 48, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(896), "Orange", "Fanta", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("88c7403f-fb67-45fe-bf1a-b36648511242"), "PC-1-F-50", 49, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(903), "Orange", "Fanta", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("3e912b83-5060-4dc7-a196-8da10eb4d317"), "PC-1-F-51", 50, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(908), "Orange", "Fanta", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("0c3c8f72-f1f8-445a-a1af-0cfabab9b065"), "PC-1-F-52", 51, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(913), "Orange", "Fanta", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("cd35cabb-eac1-4475-9b60-6a82676bf74d"), "PC-1-F-53", 52, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(917), "Orange", "Fanta", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("d1947401-5bc5-4b65-aec7-19ea14ae5e51"), "PC-1-F-54", 53, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(922), "Orange", "Fanta", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("8da505a9-5335-49ca-b53a-63ec72bc5147"), "PC-1-F-55", 54, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(928), "Orange", "Fanta", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("fce5d467-0ea5-434f-86af-57ab33cd1cf1"), "PC-1-F-56", 55, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(937), "Orange", "Fanta", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("d035c4a8-18d9-4753-870d-b54198f67f4a"), "PC-1-F-57", 56, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(942), "Orange", "Fanta", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("dd50cd87-88bd-4af9-9117-9b03ce36e8dc"), "PC-1-F-58", 57, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(949), "Orange", "Fanta", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("2600a765-d3e9-471f-8ca8-1397f580d579"), "PC-1-F-59", 58, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(955), "Orange", "Fanta", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("577fc86e-62c7-4b99-9f16-4b780460d3b6"), "PC-1-F-60", 59, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(960), "Orange", "Fanta", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("13853531-9e34-4bc3-8d0c-fd353a08951b"), "PC-1-F-61", 60, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(965), "Orange", "Fanta", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4b12b102-4e17-4c15-8271-f0719546c7a8"), "PC-1-F-62", 61, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(969), "Orange", "Fanta", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f93c553f-f2d8-4d25-9185-8ef96b2198ba"), "PC-1-F-63", 62, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(974), "Orange", "Fanta", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("372407a2-8cb6-434d-9c1b-e6a4f433ac3c"), "PC-1-F-64", 63, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(980), "Orange", "Fanta", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f22b4c4c-23c7-4433-aed4-21422ce1a9e4"), "PC-2-CC-35", 34, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(819), "Not sugar", "Coca-cola", new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("2ab1d871-92cd-4494-8b28-ae744b7c4ffd"), "PC-2-CC-34", 33, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(813), "Not sugar", "Coca-cola", new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6676e8c7-2619-4095-b0d0-c743c3e6d767"), "PC-2-CC-33", 32, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(806), "Not sugar", "Coca-cola", new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("945882ef-9c56-44fd-928c-edaef3de4333"), "PC-2-CC-32", 31, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(799), "Not sugar", "Coca-cola", new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("553d3b91-2054-4aab-8040-2889d2f3b894"), "PC-1-CC-2", 1, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 813, DateTimeKind.Local).AddTicks(6433), "Sugar", "Coca-cola", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("997a098f-1c1f-459c-bddf-ffbab5c3b4be"), "PC-1-CC-3", 2, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(456), "Sugar", "Coca-cola", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("893caa55-7ab5-4207-b186-4cab88510e36"), "PC-1-CC-4", 3, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(496), "Sugar", "Coca-cola", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f9cc1039-c394-4363-ac57-a933b75c1386"), "PC-1-CC-5", 4, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(504), "Sugar", "Coca-cola", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("410247fc-0738-4867-83b4-53fdf36ff1e3"), "PC-1-CC-6", 5, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(508), "Sugar", "Coca-cola", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c700a9e3-740e-46b1-a2f0-91952ffac788"), "PC-1-CC-7", 6, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(522), "Sugar", "Coca-cola", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6d796298-cff3-47f2-ab8f-6adbe7cc7e87"), "PC-2-CC-8", 7, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(538), "Sugar", "Coca-cola", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("0f8c1613-d310-4ecf-aaaf-f6ec5faa7bb2"), "PC-2-CC-9", 8, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(546), "Sugar", "Coca-cola", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("67e5477f-33d2-4808-9cdb-b9fa6be2cb08"), "PC-2-CC-10", 9, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(564), "Sugar", "Coca-cola", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("dc4dbad8-c326-4d6c-b1a4-6da60aba19f1"), "PC-2-CC-11", 10, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(572), "Sugar", "Coca-cola", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("941c976b-6e0f-48bf-96a0-5520a7ae03c2"), "PC-2-CC-12", 11, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(577), "Sugar", "Coca-cola", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ce311616-6d16-4279-9cab-6584f7f28662"), "PC-2-CC-13", 12, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(581), "Sugar", "Coca-cola", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a542699c-104e-4ce7-a3a9-05a1b05e78fc"), "PC-2-CC-14", 13, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(586), "Sugar", "Coca-cola", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b54a3b0e-b7e6-4442-a08a-852ee8aee128"), "PC-2-CC-15", 14, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(591), "Sugar", "Coca-cola", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("943b828f-b8e0-4c62-98f7-40826b733d46"), "PC-1-F-65", 64, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(985), "Orange", "Fanta", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("2d1fdb4d-95a1-4e42-9671-18fb37db59a1"), "PC-2-CC-16", 15, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(667), "Sugar", "Coca-cola", new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("d146a7b4-4b69-4fb3-be78-3674d55e71e4"), "PC-2-CC-18", 17, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(682), "Not sugar", "Coca-cola", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("888c33bc-8807-402c-abe1-d985b4f041d2"), "PC-2-CC-19", 18, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(689), "Not sugar", "Coca-cola", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4ba539a4-c1c2-4051-97b0-46793fb40cef"), "PC-2-CC-20", 19, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(694), "Not sugar", "Coca-cola", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("3b883936-ae0b-4665-8899-2b0f9accc19b"), "PC-2-CC-21", 20, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(699), "Not sugar", "Coca-cola", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("be996f5d-a467-4162-8c91-8479a8478002"), "PC-2-CC-22", 21, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(704), "Not sugar", "Coca-cola", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("33cf153f-6fd7-472a-aa6e-78f02e90d398"), "PC-2-CC-23", 22, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(709), "Not sugar", "Coca-cola", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("8eba47f5-0d90-45bb-81e4-c4c445e8f31a"), "PC-2-CC-24", 23, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(713), "Not sugar", "Coca-cola", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4ab9c97c-0767-4db7-b3f0-35293157f8eb"), "PC-2-CC-25", 24, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(719), "Not sugar", "Coca-cola", new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6e21f138-7a87-41d5-a7c5-c3bb12386ca1"), "PC-2-CC-26", 25, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(726), "Not sugar", "Coca-cola", new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6d022a9a-69b1-4eb8-8260-74f2f77deb04"), "PC-2-CC-27", 26, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(731), "Not sugar", "Coca-cola", new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("1f2e6e06-b04f-429d-be21-8d001a37e4ff"), "PC-2-CC-28", 27, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(736), "Not sugar", "Coca-cola", new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b19257c2-9e35-46d8-9414-8a954adacb67"), "PC-2-CC-29", 28, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(741), "Not sugar", "Coca-cola", new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("daab65d7-f2b9-43ec-ab08-fed2e998f9ff"), "PC-2-CC-30", 29, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(746), "Not sugar", "Coca-cola", new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("765873eb-e342-4dbd-ba1d-e297fb3ec436"), "PC-2-CC-31", 30, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(759), "Not sugar", "Coca-cola", new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("db1363dd-01d0-4d1d-9a07-13945bb61e2e"), "PC-2-CC-17", 16, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(673), "Not sugar", "Coca-cola", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6575b68c-04ad-44e0-9e8c-c356886b72c2"), "PC-1-F-66", 65, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(993), "Orange", "Fanta", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("70ea333c-19d1-4430-80c5-1bc7a63c63c6"), "PC-1-F-67", 66, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1043), "Orange", "Fanta", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("8bef2957-a499-4a83-b6eb-6a53dfb71b88"), "PC-1-F-68", 67, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1048), "Orange", "Fanta", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("fc899b10-b38a-46e7-ae2b-050604293da6"), "FD-1-L-103", 102, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1219), "Onion", "Layes", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ca5f75b7-8090-4e8f-9a11-72cf9cf63a3f"), "FD-1-L-104", 103, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1223), "Onion", "Layes", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("58ee6a3e-af59-4fc2-8a2d-a238d1ed9b9c"), "FD-1-L-105", 104, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1228), "Onion", "Layes", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("2859993c-2dc3-497e-8937-31e3d86e5009"), "FD-1-L-106", 105, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1235), "Onion", "Layes", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("fa78f5f8-1ee4-4cf0-b8bf-f21bae26008f"), "FD-1-L-107", 106, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1239), "Onion", "Layes", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("05cf4d75-6e56-4315-bd86-1a223409a79a"), "FD-1-L-108", 107, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1244), "Onion", "Layes", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("88f21e20-1d14-4f27-8ba3-c96adb43bb21"), "FD-1-L-109", 108, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1248), "Onion", "Layes", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("20869751-9afb-4783-8749-48591e810795"), "FD-1-L-110", 109, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1253), "Onion", "Layes", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e51ce9a8-e860-4b6d-86a5-572e9e28a0c6"), "FD-1-L-111", 110, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1258), "Onion", "Layes", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("93798504-6759-4b00-a7ba-50d653c4d9e9"), "FD-1-L-112", 111, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1263), "Onion", "Layes", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("cd0eca73-5df0-4aa8-b322-505c0f15f724"), "FD-1-L-113", 112, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1267), "Onion", "Layes", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("2769a28f-d1ce-45e2-9850-dfedc0c9e936"), "FD-1-L-114", 113, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1274), "Onion", "Layes", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("d3c6bc2e-1c39-42cf-8966-e363503b0231"), "FD-1-L-115", 114, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1279), "Onion", "Layes", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("0d9f24e3-2572-49cd-85b0-a74dc474d2d5"), "FD-1-L-116", 115, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1329), "Onion", "Layes", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("993038b6-7e77-4830-9a2e-dbb3828d17c6"), "FD-1-L-102", 101, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1214), "Onion", "Layes", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c8884158-6e99-4cc6-ab0c-4f4e149dba1a"), "FD-1-L-117", 116, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1334), "Onion", "Layes", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4e82ca24-99eb-4871-a003-32142a304d74"), "FD-1-L-119", 118, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1344), "Onion", "Layes", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("cfdd2232-35c9-45db-8077-616a75eefd38"), "FD-1-L-120", 119, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1348), "Onion", "Layes", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b6883820-f735-4011-9648-177e9e6ecf4e"), "FD-1-L-121", 120, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1353), "Onion", "Layes", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("70422957-bdb2-4fb4-b2a7-4f03526dfaf5"), "FD-1-L-122", 121, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1361), "Onion", "Layes", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("3b1cb430-f1d3-4015-a18a-666958c1620c"), "FD-1-L-123", 122, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1365), "Onion", "Layes", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e02cc6a3-2c67-4041-9551-c295f62ea29e"), "FD-1-L-124", 123, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1370), "Onion", "Layes", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("d74eb95f-12b0-4870-8dc2-d5eb97a4932c"), "FD-1-L-125", 124, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1374), "Onion", "Layes", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("5675fd28-c043-40d6-aaa7-f4db65feb7b1"), "FD-1-L-126", 125, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1380), "Onion", "Layes", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e806cf5e-b8e7-4c0a-a32c-a1a34e4a2146"), "FD-1-L-127", 126, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1384), "Onion", "Layes", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("64588e2e-a092-4d97-9cff-a1fbd787523f"), "FD-1-L-128", 127, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1389), "Onion", "Layes", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6dc02a69-7a31-4e45-b35a-11a7b0b5ec1f"), "FD-1-L-129", 128, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1394), "Onion", "Layes", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a01180e9-0087-474b-bea2-deea4ba561c1"), "FD-1-L-130", 129, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1400), "Onion", "Layes", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a77b1322-5e74-4c5a-bd63-f2c9141a8666"), "FD-1-L-131", 130, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1408), "Onion", "Layes", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b1128f63-8344-40a8-9c2f-1bd50fb62f51"), "FD-1-L-132", 131, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1413), "Onion", "Layes", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("7646e09b-d6ee-428c-b669-32a20eb7f955"), "FD-1-L-118", 117, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1340), "Onion", "Layes", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("3a643978-2189-488d-9030-9b01988b5477"), "SD-3-L-267", 266, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2224), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6e4c1699-0794-4fe5-b625-c65f5de471e6"), "FD-1-L-101", 100, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1208), "Onion", "Layes", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Food", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a8d95651-2e2a-4c17-b459-2c42f20d78ff"), "PC-2-F-99", 98, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1200), "Orange", "Fanta", new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b3df67cc-e97a-4201-bb95-6d710ffbf259"), "PC-1-F-69", 68, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1053), "Orange", "Fanta", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("bf223e28-0a46-4599-a9bf-92b97e6b7e2f"), "PC-1-F-70", 69, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1057), "Orange", "Fanta", new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"), 1m, "1 1", "Drink", "1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("fc9f3d94-79e3-485e-96a4-4946120846f6"), "PC-2-F-71", 70, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1062), "Orange", "Fanta", new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("8daed7c7-11e9-4fc1-adb2-87c9c7abf755"), "PC-2-F-72", 71, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1068), "Orange", "Fanta", new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("472e2706-83fd-4826-a4fc-fee3782fb74c"), "PC-2-F-73", 72, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1072), "Orange", "Fanta", new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("8f0bb9cf-456c-4551-a0c9-815162939603"), "PC-2-F-74", 73, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1079), "Orange", "Fanta", new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6543feb8-701b-48fe-a3a4-c71a7977c4e7"), "PC-2-F-75", 74, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1083), "Orange", "Fanta", new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6b2890db-46ab-4c14-a3a7-1df892a8d360"), "PC-2-F-76", 75, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1088), "Orange", "Fanta", new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f89f995c-2133-450c-afc9-d2a4c22da2e6"), "PC-2-F-77", 76, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1092), "Orange", "Fanta", new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f293b6aa-3764-4370-a559-df5d5e2e993e"), "PC-2-F-78", 77, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1097), "Orange", "Fanta", new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("62a7f5d1-f053-4af2-a248-8421f11c500c"), "PC-2-F-79", 78, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1101), "Orange", "Fanta", new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c5dccb06-6134-4443-8d86-3fab987b95c6"), "PC-2-F-80", 79, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1106), "Orange", "Fanta", new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("917d086e-ca72-44b8-a728-c7d3ff9554d2"), "PC-2-F-81", 80, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1110), "Orange", "Fanta", new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("782e55b5-5b27-4978-a409-8b2942af0103"), "PC-2-F-82", 81, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1117), "Orange", "Fanta", new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("3436d45f-e3e9-4dde-bbe7-6f86fe0706b1"), "PC-2-F-100", 99, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1204), "Orange", "Fanta", new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("2e653266-acf3-4874-9781-8516dd4c0722"), "PC-2-F-83", 82, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1121), "Orange", "Fanta", new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("bfe615df-2682-4728-93a2-61af8b53167d"), "PC-2-F-85", 84, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1130), "Orange", "Fanta", new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("33f92d9c-4cc3-4603-b83e-8ba96e1d1c7e"), "PC-2-F-86", 85, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1135), "Orange", "Fanta", new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("07584754-5f57-46de-96be-6cba10bd5dd4"), "PC-2-F-87", 86, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1140), "Orange", "Fanta", new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("41ed2242-1b02-4329-a5a4-50f593881724"), "PC-2-F-88", 87, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1145), "Orange", "Fanta", new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a3d624c5-6c8d-4962-91de-f7cfe46ac740"), "PC-2-F-89", 88, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1149), "Orange", "Fanta", new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("2b36a78c-e2d9-4bc9-bfff-4296cb76c3a9"), "PC-2-F-90", 89, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1156), "Orange", "Fanta", new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6e08cc27-dd3f-435d-8def-edc72e0ad913"), "PC-2-F-91", 90, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1161), "Orange", "Fanta", new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("d3f01f38-f9cb-4442-9767-e19f18e0ffd9"), "PC-2-F-92", 91, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1165), "Orange", "Fanta", new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("fc6686fb-1286-4886-99df-b293ddd47d6c"), "PC-2-F-93", 92, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1170), "Orange", "Fanta", new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("13451294-e96b-4b8c-b3f9-7e55826633fd"), "PC-2-F-94", 93, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1174), "Orange", "Fanta", new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c9a9a2af-6b12-4dfc-bd86-1d96e8517c9d"), "PC-2-F-95", 94, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1179), "Orange", "Fanta", new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("9417eaa7-42ff-4dcc-9163-b0520c3a7a56"), "PC-2-F-96", 95, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1184), "Orange", "Fanta", new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a58af108-328a-49d1-8442-7b5da3630bc0"), "PC-2-F-97", 96, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1188), "Orange", "Fanta", new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("61164703-fd48-4076-aba1-51b8863fb157"), "PC-2-F-98", 97, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1195), "Orange", "Fanta", new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("2d01f721-c1ea-4df8-9f35-b105c358bc39"), "PC-2-F-84", 83, "Yellow", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(1126), "Orange", "Fanta", new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb"), 2m, "2 2", "Drink", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("16a255a6-9e11-45a7-bfef-3a8e96f45faf"), "CHLY-2-L-1073", 1072, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7677), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e1b8ad15-8294-428a-bc8b-53b564bbc722"), "SD-3-L-268", 267, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2231), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("58dd90b8-1f66-40ad-b21e-9e6cb54a2d65"), "SD-3-L-270", 269, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2240), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("817dbea8-fa16-48e1-ba64-36fce16f2b81"), "SD-3-L-440", 439, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3244), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("db3b00b1-a3a6-401b-861e-c977b726a94e"), "SD-3-L-441", 440, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3249), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("1b30aebe-b300-4c06-8efc-44ebc4141459"), "SD-3-L-442", 441, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3257), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("5d9c04e1-37a1-4507-8148-fcd5ee320eba"), "SD-3-L-443", 442, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3261), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b78f2e35-4716-4887-82dc-531fa0923b6a"), "SD-3-L-444", 443, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3266), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("803aeb41-1be7-4e4b-bc3c-c8e7a97cf6ea"), "SD-3-L-445", 444, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3272), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("40278c2a-2849-4f6f-a257-649721e7a8b8"), "SD-3-L-446", 445, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3276), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("58edf455-9c03-443a-85ec-e76e0679e629"), "SD-3-L-447", 446, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3419), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("049dff9e-1cf9-4c39-b866-64225d3f71bb"), "SD-3-L-448", 447, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3424), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ecbec9d4-d27f-4ff7-b651-77baf50f4bac"), "SD-3-L-449", 448, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3428), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("0647d111-ec9a-41a2-9b38-16a8eb45c4f2"), "SD-3-L-450", 449, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3435), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("df5eced4-0adb-4b1d-aada-56ef1483670a"), "SD-3-L-451", 450, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3439), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("efd3c314-7ce6-44c2-8d1f-08d63f280e76"), "SD-3-L-452", 451, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3443), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("5eb637b8-500d-4476-b861-5273291ca24a"), "SD-3-L-453", 452, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3448), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("3b59874c-4d7c-4b04-99db-a90f1c6875a1"), "SD-3-L-454", 453, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3452), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("63bc7337-e5b9-459c-8cc7-1d4fff109b77"), "SD-3-L-455", 454, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3457), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("8947ff48-1197-4f87-b8a2-33d452f0d60c"), "SD-3-L-456", 455, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3461), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6365bf95-cc50-4e79-ac3c-0e1687b74796"), "SD-3-L-457", 456, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3465), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("d0806e51-1226-4bbd-a9b0-8522e36dd742"), "SD-3-L-458", 457, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3471), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("152f9bcd-bb72-4806-b493-3d8222eb4a68"), "SD-3-L-459", 458, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3476), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f1ae3349-3e85-47c4-9204-97576baea220"), "SD-3-L-460", 459, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3481), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("d93b968b-3d08-489e-abbb-437e8fa9b9c4"), "SD-3-L-461", 460, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3485), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("73cf374d-fdfb-4715-b9b1-b0dde27524d5"), "SD-3-L-462", 461, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3489), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ee6c4c37-6155-4073-afe3-2adbe11d5df3"), "SD-3-L-463", 462, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3494), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c54c2bd7-7301-4575-8822-caf29c6ec3c2"), "SD-3-L-464", 463, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3499), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("db3df953-5e18-472d-a744-3618077c8af2"), "SD-3-L-465", 464, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3503), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("372c3f44-279d-489a-a789-a37ffc4fb981"), "SD-3-L-466", 465, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3509), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("31af33d6-fa5d-4d77-b4a4-1e0ed5447bdd"), "SD-3-L-467", 466, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3514), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("36bf9197-e289-4147-939e-0b587645ff91"), "SD-3-L-468", 467, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3521), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("71ff5d96-5616-4636-a0e3-f1fa21366614"), "SD-3-L-439", 438, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3239), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("8f7899d2-64cb-4d96-aa06-a53a32928a12"), "SD-3-L-438", 437, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3235), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("50e1d843-a1de-4883-8bc8-4d6fda970cf8"), "SD-3-L-437", 436, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3231), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4d43ab23-ef4d-427b-b6a7-48236c85fca6"), "SD-3-L-436", 435, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3225), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4887ae57-bd04-48fb-ae35-123301c48718"), "SD-3-L-406", 405, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3033), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("66e05738-ca43-4da7-8c7a-552b91acb2cd"), "SD-3-L-407", 406, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3038), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("64b01e62-45b1-4e7b-98ac-810992ee4d8f"), "SD-3-L-408", 407, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3042), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("dd8b41d3-c98e-469c-b761-f885dd1415b6"), "SD-3-L-409", 408, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3047), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b40f58fd-0354-4744-b0a2-74146cb0c81d"), "SD-3-L-410", 409, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3055), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("05674ac1-dd8e-4f3d-83a3-a40b4dd42ff8"), "SD-3-L-411", 410, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3059), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ddb7ea46-2cdf-429e-beb9-bb76730d6824"), "SD-3-L-412", 411, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3064), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("195caded-8e87-474c-a4ac-0af609a3844d"), "SD-3-L-413", 412, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3111), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("65ff73ba-bc6e-4266-8a50-be5ac6b0b465"), "SD-3-L-414", 413, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3116), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("90044296-f87d-4664-8db5-325ea24c8b96"), "SD-3-L-415", 414, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3121), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("236e273f-5bc6-49c4-bd9d-b94974de57dc"), "SD-3-L-416", 415, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3126), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b06f694d-c67f-4630-b39b-5026e2c2f41b"), "SD-3-L-417", 416, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3131), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("1ee047de-1695-4871-8e67-40c848dcb24c"), "SD-3-L-418", 417, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3138), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("25cada92-1b33-4b1f-85d5-0ce2df324b58"), "SD-3-L-419", 418, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3144), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b8c7b34e-803d-43b5-b779-b211f4454fb4"), "SD-3-L-469", 468, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3525), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("23cd2b9a-87ce-47c6-ab52-3a5996cceb50"), "SD-3-L-420", 419, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3148), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e789c652-e883-457c-a793-8e5b1c7eeba2"), "SD-3-L-422", 421, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3157), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6a25971e-4211-48fe-a9c8-fe2b3ead5819"), "SD-3-L-423", 422, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3162), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("2de75c04-2010-4456-9bde-b8c0ec9740a7"), "SD-3-L-424", 423, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3166), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("21d0b309-b930-4d08-bb70-76be3b3649a4"), "SD-3-L-425", 424, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3171), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("1bd97299-9073-4aba-9c98-e54ff7a3d562"), "SD-3-L-426", 425, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3178), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("fa8091e1-8217-4473-b511-22f09f19b6bd"), "SD-3-L-427", 426, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3183), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4a290b55-1a0a-4763-b640-db023e7c51d9"), "SD-3-L-428", 427, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3188), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("db4a805a-8edb-4b0a-907d-bf22b82ae76b"), "SD-3-L-429", 428, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3192), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("858441fa-b2da-4e99-b1c2-005b08284719"), "SD-3-L-430", 429, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3196), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("fc689e1d-acb2-4420-b9a8-c2d24d82a021"), "SD-3-L-431", 430, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3201), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("9f1a1168-9032-4d28-9560-5a7d4227cd85"), "SD-3-L-432", 431, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3205), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("19e8cbd2-c256-49c8-b9af-a9c874b684a0"), "SD-3-L-433", 432, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3210), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e88ed8f6-b5d7-461d-99f4-c41b8713b327"), "SD-3-L-434", 433, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3216), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ad94b047-3cf4-4c1b-bce1-9d5a70c19a60"), "SD-3-L-435", 434, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3221), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("bc22e2ca-3f74-4cb0-af86-0ab4ba81daa1"), "SD-3-L-421", 420, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3153), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b0956748-a690-4d43-b2ec-8e7440102026"), "SD-3-L-405", 404, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3029), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("38bde9be-b830-4bb5-b5fb-fdaa74759c66"), "SD-3-L-470", 469, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3571), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("deb801ea-d62a-44d1-971b-a8a8fdd005da"), "SD-3-L-472", 471, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3580), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("1cd9a533-d13f-4ce9-bdad-22992268b40e"), "SD-3-L-507", 506, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3743), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("24671085-cc3b-4475-84a1-5fed3216fb8b"), "SD-3-L-508", 507, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3748), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6ddd6963-e58c-4e36-9896-9351600a4794"), "SD-3-L-509", 508, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3752), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("de97289f-62b0-417e-9e4f-92ec605ea4e0"), "SD-3-L-510", 509, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3758), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("45b00f12-1393-4ece-b3f1-566f70efd43f"), "SD-3-L-511", 510, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3763), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("31a5c82e-ce98-40da-9c52-2cd2f63f923b"), "SD-3-L-512", 511, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3768), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("d63977a9-4386-49dd-891d-027e9e60eef7"), "SD-3-L-513", 512, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3772), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("0e6674a7-2b0b-4076-bccc-83c194944a14"), "SD-3-L-514", 513, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3779), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a5ac533f-f83f-4c9d-ae9f-6576cb7398fb"), "SD-3-L-515", 514, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3850), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("25dc83e0-9d84-4059-b285-68b502629678"), "SD-3-L-516", 515, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3856), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e321a9de-25f6-4631-b605-6398026b578d"), "SD-3-L-517", 516, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3860), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("5179f6e2-50dc-4d56-aedb-199509f5c2e3"), "SD-3-L-518", 517, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3865), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("5320d71d-6e6d-4302-a2dd-aa7ea3a1406b"), "SD-3-L-519", 518, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3869), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4c45261a-e1b0-4527-a249-50d01d76bfd4"), "SD-3-L-520", 519, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3873), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("2018b97a-6f2c-4305-9477-9670bb9da5c1"), "SD-3-L-521", 520, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3877), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("32fafd88-7816-4a59-88fe-15ab25537397"), "SD-3-L-522", 521, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3884), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("879829ec-38a0-4805-821a-f8679b0ecb3e"), "SD-3-L-523", 522, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3889), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("95e63ac9-a39c-435b-9ce0-5ec27eb7d1b9"), "SD-3-L-524", 523, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3893), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a2c182fa-0d90-4fc1-8179-557c27778d95"), "SD-3-L-525", 524, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3897), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("3fb00355-1d1a-4c2c-b3cf-d206068b22c8"), "SD-3-L-526", 525, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3902), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("35157adc-3615-48c9-938a-7ba4350a54e3"), "SD-3-L-527", 526, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3948), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("228c5f83-37b6-4861-82d0-6eb4283bbe1e"), "SD-3-L-528", 527, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3953), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c1e9b5b5-c748-494e-85b9-be82b06d5bf8"), "SD-3-L-529", 528, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3958), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("94b33c9a-de5c-4321-87d7-c30ae122f3a7"), "SD-3-L-530", 529, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3964), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("8a442c4d-09b1-4b65-9e4a-aab777650100"), "SD-3-L-531", 530, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3970), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("2abcd691-0382-4c72-b750-f4760799682c"), "SD-3-L-532", 531, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3974), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ba636696-2e06-468a-af3c-6c0d2066d5a4"), "SD-3-L-533", 532, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3978), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("844dce8f-081f-42e2-9f64-0dba4a8501ea"), "SD-3-L-534", 533, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3982), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("61fa2d94-21ea-4234-9c47-89365fc29d81"), "SD-3-L-535", 534, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3987), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 6m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("d7a5a89d-cf10-485b-8543-3375330fb317"), "SD-3-L-506", 505, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3738), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("989f162a-5a4b-43d7-8074-42d21a67ea5b"), "SD-3-L-505", 504, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3731), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ff12156a-424a-4243-b37d-749926b9c7f3"), "SD-3-L-504", 503, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3727), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6d277852-9ad2-4ec9-8da1-38e775bbea1c"), "SD-3-L-503", 502, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3723), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e97949c2-829d-484c-b739-1d7dfeb52146"), "SD-3-L-473", 472, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3585), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("01fca188-f353-4964-821b-8dee3ed9a590"), "SD-3-L-474", 473, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3592), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("8d0c0b7d-bd6a-4ebc-9572-5742ef1ab048"), "SD-3-L-475", 474, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3596), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("44a09f1d-15e9-4edb-99ce-181daa87b4a2"), "SD-3-L-476", 475, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3601), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("96a84957-081d-4ef8-a10b-9ba9ec2bd0ea"), "SD-3-L-477", 476, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3606), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f07266c5-a332-4a0a-9350-5713aa8725b2"), "SD-3-L-478", 477, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3610), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("81d58d54-2bea-428c-85b2-682ad28aad69"), "SD-3-L-479", 478, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3614), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("9ee8d7d0-08f8-401a-85fb-fc8c30fb6032"), "SD-3-L-480", 479, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3618), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("bbbfd476-b736-410a-8804-44dafb96b03e"), "SD-3-L-481", 480, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3622), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("efa2ca29-bb5e-4297-b23f-40df03e8ad93"), "SD-3-L-482", 481, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3629), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("8ea9f930-4121-4c02-9a0b-23e537c7719b"), "SD-3-L-483", 482, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3633), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("9d1c5a4c-3179-4e4e-9464-054db5443f95"), "SD-3-L-484", 483, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3638), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6250d3d7-a4b8-49a8-ab98-80c166da1910"), "SD-3-L-485", 484, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3642), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("66d0ad42-7d98-4fb0-8fcb-cd13ce430cb5"), "SD-3-L-486", 485, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3646), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b15bb65d-bacb-4ed6-a929-e81a05c226e5"), "SD-3-L-471", 470, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3576), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f4ac9eea-3b8c-471b-a5c3-360d27964f2b"), "SD-3-L-487", 486, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3650), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("29820f05-e491-4c57-ac5a-10f18ff3384b"), "SD-3-L-489", 488, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3658), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("d32f6163-c6ef-44cf-886c-4816f1db448c"), "SD-3-L-490", 489, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3665), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("696b5e51-d93d-4e90-ab46-ad30f53c3c55"), "SD-3-L-491", 490, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3669), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("72e81e98-7ac6-4c23-a1ca-285fa96e331e"), "SD-3-L-492", 491, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3674), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("1b771472-8a81-4535-8f94-01f5ccfa10a9"), "SD-3-L-493", 492, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3678), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4a7a3d66-9a00-428e-8a5f-563b92a27077"), "SD-3-L-494", 493, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3682), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ae3882d5-71c4-4acb-baab-725265a9d597"), "SD-3-L-495", 494, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3686), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("1dde4c2b-a415-456e-a5b3-4c7a38478ea1"), "SD-3-L-496", 495, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3690), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("bb2d0206-53fe-4f2a-8a81-ef9de8445f32"), "SD-3-L-497", 496, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3694), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("03b2aefc-d490-4bfc-96f1-2888d45ee0a9"), "SD-3-L-498", 497, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3701), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("39b4c863-a499-4956-94bf-04325dc9b983"), "SD-3-L-499", 498, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3705), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("de71b85e-8496-4804-be3e-c0af3cb28ed3"), "SD-3-L-500", 499, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3710), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6a338c9c-30d3-44cb-b6dd-9459e232c410"), "SD-3-L-501", 500, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3714), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("8e0360b6-e6e1-45f2-a78a-95d3d5f02f07"), "SD-3-L-502", 501, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3718), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a69cbbb7-8486-4f76-b477-a335e02de397"), "SD-3-L-488", 487, "Blue", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3654), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("9d51660b-21d8-4876-9ca1-a0e02a754674"), "SD-3-L-404", 403, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3022), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("682e1286-cdd2-4c81-b348-6cf15d6a5bdd"), "SD-3-L-403", 402, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3018), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4aaf1e41-590d-4e68-9b8f-7b5feff0c3c4"), "SD-3-L-402", 401, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3014), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("280542b3-654a-443d-be09-c08d49df9ce9"), "SD-3-L-305", 304, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2492), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("327bba68-3fd6-41bf-baa1-152879628493"), "SD-3-L-306", 305, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2499), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("952b2154-15c2-4564-a162-7f361128c33f"), "SD-3-L-307", 306, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2504), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("759ae541-84cd-4067-a6e0-cfe329ebc5b9"), "SD-3-L-308", 307, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2508), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b5c433cc-b9db-43ad-937e-9c1f56c40be6"), "SD-3-L-309", 308, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2514), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c33244a9-ad9f-4087-866d-1664737dbc85"), "SD-3-L-310", 309, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2518), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b841eaf8-ce42-48a8-9201-0bf0735bfa83"), "SD-3-L-311", 310, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2522), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("30ca9552-02cf-4c66-a39d-8af63b2ea3dd"), "SD-3-L-312", 311, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2528), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("27f9349a-29c2-488c-ac9e-0248dd5a2ca1"), "SD-3-L-313", 312, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2534), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("143f4203-dfb3-4ee4-8602-19d42209eeae"), "SD-3-L-314", 313, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2542), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("0e06db5a-0ea4-4049-ad8f-ee3bc83e203f"), "SD-3-L-315", 314, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2546), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e01d774f-87bb-4620-aba8-ec2806876be9"), "SD-3-L-316", 315, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2551), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e382ed88-39ed-43cd-b644-4fe09d46c28a"), "SD-3-L-317", 316, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2555), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a92b1c5d-c16c-498f-88b9-073aa51f3ec6"), "SD-3-L-318", 317, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2560), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("2a0b3923-0e3d-4200-8b01-440acaaf0d78"), "SD-3-L-319", 318, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2565), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("467eb27e-9727-4529-88b1-9155c343ab83"), "SD-3-L-320", 319, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2570), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("2db7bba7-14e0-4ecf-a752-658d11d0e6e7"), "SD-3-L-321", 320, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2574), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("69591411-43ee-4349-a49d-f84335e1236c"), "SD-3-L-322", 321, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2581), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b639396a-ef64-42f4-a3d0-0626802a5a95"), "SD-3-L-323", 322, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2585), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e7e28e74-754d-469b-bd87-8ba6d470df98"), "SD-3-L-324", 323, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2590), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b574047e-3176-429e-bdf9-3efe813dd6b0"), "SD-3-L-325", 324, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2594), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("7829f0ac-3d7b-4b9e-a242-ddb264c09950"), "SD-3-L-326", 325, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2599), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("61f12477-125a-410f-8425-0e455a75d741"), "SD-3-L-327", 326, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2604), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("75f7cd08-754f-462d-97e1-0f844153dc33"), "SD-3-L-328", 327, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2608), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("06d49fa0-8459-4bd8-9999-6c60d82783b4"), "SD-3-L-329", 328, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2613), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("48cb8cf9-d618-4a20-b43a-cd7a1272fcfd"), "SD-3-L-330", 329, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2619), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("445fc7b2-ed17-4736-bd8d-6750e1e45d61"), "SD-3-L-331", 330, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2624), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a8dd92e4-1b6a-4082-b7ff-1385b2d76140"), "SD-3-L-332", 331, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2629), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c7403fb5-0abf-47a8-a332-b87448603cbe"), "SD-3-L-333", 332, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2633), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f6cd448e-71ba-4a60-bfed-4f8e614cc8f2"), "SD-3-L-304", 303, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2488), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6b3f73e5-b2fd-43b5-a781-294d08ccaba0"), "SD-3-L-303", 302, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2483), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6bec5a6a-5323-47fe-938d-9bb17c044214"), "SD-3-L-302", 301, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2479), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("2f7db169-a2be-4077-8c59-bea280409f00"), "SD-3-L-301", 300, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2472), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("9f2d4fe1-dd26-404d-bb1e-c5727e48847c"), "SD-3-L-271", 270, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2245), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b6648d85-6af1-4262-b209-a10f11523359"), "SD-3-L-272", 271, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2249), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("9d9f80eb-1309-450a-a0e4-8263505695d8"), "SD-3-L-273", 272, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2254), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("8b103062-1db1-401a-b9e6-627ed43bbbf9"), "SD-3-L-274", 273, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2261), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6cad4062-3938-4f5d-b4c9-a80b747ffc53"), "SD-3-L-275", 274, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2266), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("8d804bf5-a505-488c-99db-53ac91525d22"), "SD-3-L-276", 275, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2270), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("18564fc5-b4a5-4f9a-a29c-1b3cb701ad8a"), "SD-3-L-277", 276, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2275), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("02d1d88b-a644-4434-b8e2-394cb5696070"), "SD-3-L-278", 277, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2279), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("7b14e67b-cf18-40c4-981b-5f2bdf9017de"), "SD-3-L-279", 278, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2283), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a57ece04-647b-40e2-ba5a-c41cb42ec023"), "SD-3-L-280", 279, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2288), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e8c51555-4f04-495e-bd1c-5442be56eea0"), "SD-3-L-281", 280, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2293), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("9daa7478-d8ef-4655-ad9d-ecf70d63b682"), "SD-3-L-282", 281, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2299), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6a4fabc3-b403-4d9c-bc41-9c8ff6404228"), "SD-3-L-283", 282, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2304), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f6de2b74-5480-43a9-8113-f5a1374a0625"), "SD-3-L-284", 283, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2309), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("150fffb7-d4a4-44a5-8c12-02f80c176c65"), "SD-3-L-334", 333, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2638), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("66ef502c-ac87-4874-929e-8d8d13733b7a"), "SD-3-L-285", 284, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2313), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("d92eb038-fa49-432b-b770-4cc71abbd6b3"), "SD-3-L-287", 286, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2323), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c793e7ca-499d-4650-b280-c8025b6ebbc4"), "SD-3-L-288", 287, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2328), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b09f9123-ed2f-4ba9-ae6d-9229d6ed0815"), "SD-3-L-289", 288, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2333), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4979bc0f-a45b-4c84-bf69-f02effc48508"), "SD-3-L-290", 289, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2339), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("1c583fbf-bfc5-4325-b8a2-d8d4a3f45a2f"), "SD-3-L-291", 290, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2344), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("acde3077-3cd1-41d4-8776-8999500a8d6c"), "SD-3-L-292", 291, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2349), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("9a17a185-444e-4515-a8f8-df4cc007a082"), "SD-3-L-293", 292, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2353), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("29343e3a-633a-492e-b737-4ce59904e445"), "SD-3-L-294", 293, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2357), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("0b39eff4-822a-41c5-af75-45885b5ed8b9"), "SD-3-L-295", 294, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2362), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("699eeff1-5b33-4ea1-8b70-37c6b5343b80"), "SD-3-L-296", 295, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2367), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("22bbef70-1452-4c6f-985b-1ab52a08f55d"), "SD-3-L-297", 296, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2372), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("5a609534-da95-4b52-8ea6-2e11d2e4d2b9"), "SD-3-L-298", 297, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2379), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4c5858b6-041c-40ab-9f3d-b7778ff2d101"), "SD-3-L-299", 298, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2385), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f1641166-b55e-46d3-9eeb-05896bb386e2"), "SD-3-L-300", 299, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2465), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e1c3466d-2356-4201-9099-33a99d0ba182"), "SD-3-L-286", 285, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2319), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e121fa94-81a5-41bb-8a5e-f129e218ee0f"), "SD-3-L-335", 334, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2642), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("84b37072-fa26-4a47-9123-b997b16bfd4d"), "SD-3-L-336", 335, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2647), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a737123e-1259-4f91-99a8-01d551c950d4"), "SD-3-L-337", 336, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2651), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("dcd713a6-5a1e-479c-8ecd-6389d9e11148"), "SD-3-L-372", 371, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2870), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("04bd7d8c-6ea7-46bb-ab92-a23ea830fe50"), "SD-3-L-373", 372, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2875), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4b0a9183-0354-435b-ad01-3d68e96c260c"), "SD-3-L-374", 373, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2879), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("294a396f-852a-44a1-84b1-fef87898357b"), "SD-3-L-375", 374, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2883), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("7e61e621-5c01-424c-8867-be6de4f6b7bf"), "SD-3-L-376", 375, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2888), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("cd263ef7-7e59-4b77-a992-58d0447e31cc"), "SD-3-L-377", 376, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2892), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("46aadd52-3dcf-4afb-98a6-48e08bc6f6b5"), "SD-3-L-378", 377, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2898), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a1089855-5111-40ac-9e03-6bb6a13e14a3"), "SD-3-L-379", 378, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2903), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("1b6bfb16-dc77-4629-8c7b-bc52cb70cb75"), "SD-3-L-380", 379, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2907), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c680c6fb-b9bf-474e-8d08-5999d6ae624d"), "SD-3-L-381", 380, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2913), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("9d51a874-b678-4aa5-bf0a-6bc99f5e2a51"), "SD-3-L-382", 381, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2917), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e73610f7-6c79-425a-bf5e-0a68caf72268"), "SD-3-L-383", 382, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2922), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("9c714681-56c8-4be1-a994-7ebe1555692e"), "SD-3-L-384", 383, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2926), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("efddef39-b726-4344-8ee3-66e21adad56a"), "SD-3-L-385", 384, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2930), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ec0434e4-40e5-4e86-a87c-4108d3eda401"), "SD-3-L-371", 370, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2866), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6739570d-27c4-4bf5-a9d7-589dfb89aab4"), "SD-3-L-386", 385, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2937), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b6babea3-2d5f-491f-b000-1e1629f28c3a"), "SD-3-L-388", 387, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2945), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("5b9ea8f4-6017-4a32-8406-7f6251cb5bce"), "SD-3-L-389", 388, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2950), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a87cc4b7-b56b-47a7-92f0-a6821286b74e"), "SD-3-L-390", 389, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2955), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c3cf3052-0dc5-4a7e-a53c-f52891b9cecb"), "SD-3-L-391", 390, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2959), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("0ff23d05-b9f7-4d41-ac5e-d0f9313ae6e1"), "SD-3-L-392", 391, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2964), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("d8c74eef-0d1e-46ac-b955-3b58d0192a35"), "SD-3-L-393", 392, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2968), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("97df2e8d-066f-474c-b1e5-47910a2d8e88"), "SD-3-L-394", 393, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2974), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("268f311e-0234-47e2-90f5-a37a648e864f"), "SD-3-L-395", 394, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2979), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("5c4ec39a-b880-436e-88b9-2bfc0a61e52b"), "SD-3-L-396", 395, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2983), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("9ddca96c-e7c7-4425-980c-a04b7b3ecb78"), "SD-3-L-397", 396, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2990), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c0997b60-d2f9-4288-a320-c1af0a5e56ad"), "SD-3-L-398", 397, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2994), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("46c6df24-c7b8-4dc5-a462-df91262e7a6e"), "SD-3-L-399", 398, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2998), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("edfc730c-c29b-4fdc-8182-63061cf08b13"), "SD-3-L-400", 399, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3003), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("6b036341-9e0d-4f56-bf37-2a1e00c805e2"), "SD-3-L-401", 400, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(3007), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("e0f34066-712a-4694-8f2a-d06741a3c307"), "SD-3-L-387", 386, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2941), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f99414d9-3958-4e64-ac0f-c387aeb387a8"), "SD-3-L-269", 268, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2236), "White Zeuse", "Zeus", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 2m, "1 3", "Decoration", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("eba74022-235f-46f3-9d6f-34957956dda2"), "SD-3-L-370", 369, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2861), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("9e67a647-651c-49e0-b17a-1e2a59a960a5"), "SD-3-L-368", 367, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2850), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ce4df932-fb0a-43f6-913b-bf87d02d4c05"), "SD-3-L-338", 337, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2658), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("a6e212be-0d41-4bef-9019-a8c0608e23fe"), "SD-3-L-339", 338, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2662), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b36cf7fa-f77f-45cd-b46b-147203fb23f0"), "SD-3-L-340", 339, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2667), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("b8e47c20-5014-4517-886c-8844c74561b8"), "SD-3-L-341", 340, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2671), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ef1b16f4-ba75-48e4-bf65-7c55c4f6eed5"), "SD-3-L-342", 341, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2676), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("75570734-dbeb-4876-bfe8-1b6dac83d185"), "SD-3-L-343", 342, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2681), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("4a91fc0f-c6e8-4678-9d3d-0187cd24f8c8"), "SD-3-L-344", 343, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2685), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c76d9475-55e0-4e1a-87fb-8827836cbd3f"), "SD-3-L-345", 344, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2690), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("d8c49522-ded8-4f1c-ac68-b3acf30d3eac"), "SD-3-L-346", 345, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2696), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("fc381950-3e87-43fb-abb0-a5611fbe70eb"), "SD-3-L-347", 346, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2700), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("d86cb651-35c0-4cad-b03f-e46fa1fd5662"), "SD-3-L-348", 347, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2705), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("93f4a90c-bf51-4e6f-acd8-c43890fe6f11"), "SD-3-L-349", 348, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2710), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("14fd27d5-3064-4618-833d-96a33b0b82f6"), "SD-3-L-350", 349, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2715), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("cddd59b9-52d4-4b2e-9a1d-dad2794375d9"), "SD-3-L-351", 350, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2720), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("d245b91f-ff0c-42e8-b230-17f49b4409bc"), "SD-3-L-369", 368, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2854), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("9a608bc6-a7eb-4845-b168-6f656809d11e"), "SD-3-L-352", 351, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2724), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("c5d3eb00-5068-4dc9-b16e-7546f72bbf91"), "SD-3-L-354", 353, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2735), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("d1796de4-8593-4d40-8d7d-43adf850a4f0"), "SD-3-L-355", 354, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2740), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("700a9b56-0a7c-4348-8d46-815a4e30ff21"), "SD-3-L-356", 355, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2745), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("814ab96d-d202-4160-bac1-47c5f22eb96f"), "SD-3-L-357", 356, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2794), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("ac19cb23-680d-460f-8433-963e363ca7c7"), "SD-3-L-358", 357, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2800), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("401bd457-c6ef-41a6-a3f6-6fe6a2c4f678"), "SD-3-L-359", 358, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2804), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("8b868d0b-68bd-4971-9774-859d9ce855d1"), "SD-3-L-360", 359, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2809), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("824d217a-2718-4cef-b630-fe50ec425f31"), "SD-3-L-361", 360, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2813), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("14c23e7c-12b2-42a3-897f-fd501c2b182c"), "SD-3-L-362", 361, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2820), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("eb4ce3c5-f2ba-40d3-9421-d55c37c770d1"), "SD-3-L-363", 362, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2824), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("f4f97d16-018c-4a6f-a4e1-0f461e675646"), "SD-3-L-364", 363, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2829), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("71155381-b2a2-4f8c-8d3c-2c07088c3da3"), "SD-3-L-365", 364, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2837), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("dbdb1e72-66a8-44fa-974e-0cd0d5f0228c"), "SD-3-L-366", 365, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2841), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("44bc56d0-1602-42e7-af60-db2537afa6cc"), "SD-3-L-367", 366, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2846), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 1m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("66ac12b3-67d6-4797-a4a8-daf6e02bd0f8"), "SD-3-L-353", 352, "White", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(2728), "Ballpoint", "Pen", new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"), 4m, "1 3", "Chancellery", "2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("925546ef-7845-48a7-8e55-6eccf6469737"), "CHLY-2-L-1074", 1073, "Red", new DateTime(2022, 3, 21, 13, 24, 41, 815, DateTimeKind.Local).AddTicks(7692), "A", "Rubber", new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"), 6m, "1 3", "Chancellery", "2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "id",
                keyValue: new Guid("f8f744a2-a92a-49d6-975a-ad9f1ef82a65"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("001deaec-44cf-4110-98af-7e799fced7b4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("002a3a83-edb3-44a7-80c3-8b26db257d5d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0064219a-b17d-4d56-9079-a2fa897de73d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00694430-a963-4d72-90cd-f294c9e0abfd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00b0dd0e-310a-4ed1-bdbb-74b8c288eef4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00ec03b8-0493-40cb-94a7-dff96882d127"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0190b6bc-acaf-44d1-9638-98706425b140"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("01fca188-f353-4964-821b-8dee3ed9a590"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("02156e18-45b5-40b1-9f15-c4c3725b538e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("02296f57-603f-4d87-a968-5962110a8384"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("02433a74-a835-4cf4-a518-29c6fbe21cd4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0258f348-6ba0-4f39-8b33-1721425c5ca1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("02d1d88b-a644-4434-b8e2-394cb5696070"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("03a34fcb-2c1d-4f0e-b91c-bd0ea5eefb09"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("03b2aefc-d490-4bfc-96f1-2888d45ee0a9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("04153407-68cf-459f-8d2f-04edbcbe7d64"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("04556e51-3957-4ec0-b081-056dc74b8135"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("049dff9e-1cf9-4c39-b866-64225d3f71bb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("04bd7d8c-6ea7-46bb-ab92-a23ea830fe50"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("04cd20be-9244-45cf-88a8-58e83bc923d8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("05674ac1-dd8e-4f3d-83a3-a40b4dd42ff8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("057aec60-ea96-4ceb-9280-9bd48416bd65"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("05a90edc-f844-4d30-b5fb-fda66fbd000f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("05cf4d75-6e56-4315-bd86-1a223409a79a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0647d111-ec9a-41a2-9b38-16a8eb45c4f2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("069d9744-03be-4684-8463-72bad79a51b6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("069ef79f-66c5-4e2a-ac72-ee42147e7d93"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06d49fa0-8459-4bd8-9999-6c60d82783b4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06e6c17f-3a00-46e2-b692-301cae32e155"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("07584754-5f57-46de-96be-6cba10bd5dd4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0760dbfe-c0aa-4c3e-b5f9-6b728dadf08b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("077f54b4-c60a-4bd0-b796-a4f76197888c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("08564cb2-61de-40e9-899b-a0dff9bfe2ad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0873b37e-cda3-4423-95c6-9216dd5c756b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("08e77e31-8c86-4367-954f-186c92c8e7fd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0944a515-b294-4cfe-bb11-0ec7850e69ef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("096c44e7-a657-4b6f-845b-6037ff12ee8c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0a2b12d9-63b7-4fd6-8712-3943aaae3047"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0adf972a-a7d7-462b-a965-b28e3b5cde60"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b1e5ce6-0374-4c12-b648-8ffcbd861223"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b2abb5d-e3f1-4894-b647-737a94aa2950"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b39eff4-822a-41c5-af75-45885b5ed8b9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0be4eaf1-b7e0-4415-891f-401d3df7a01c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0be6d597-0646-4093-b3ac-eb3ffa45d09c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0c3c8f72-f1f8-445a-a1af-0cfabab9b065"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0c9eeddb-6727-485b-90e6-5f81fc34c227"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0d48610b-2372-4645-ab5f-090b08b60452"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0d516e1d-600d-4a00-9027-10b96aa4f7ab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0d8aa215-6afc-4597-8051-f21ffd11faca"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0d9f24e3-2572-49cd-85b0-a74dc474d2d5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0da4e21a-3a85-4c5d-b1c2-0c72eba11cb6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0e06db5a-0ea4-4049-ad8f-ee3bc83e203f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0e2ca993-506b-4989-b40f-a80934c9df4d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0e5bca9c-d7a7-4802-81b6-86b7edad7641"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0e6674a7-2b0b-4076-bccc-83c194944a14"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0e8eb880-92ab-42aa-8e42-19ca418341be"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ed1678b-98cf-4a8c-a389-0aa2fa433d68"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0f8c1613-d310-4ecf-aaaf-f6ec5faa7bb2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ff23d05-b9f7-4d41-ac5e-d0f9313ae6e1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ffc3efe-a77c-46e3-b0c6-ae86b9a387c1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("112c910d-ee80-43b7-b33e-11b1d531bb4f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("11a60611-8cc8-4e75-8abb-45b89bd8ff7a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1234e77c-aba6-47ce-b0d6-5be7f7d791ce"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("124038ec-3b16-46c8-bbd8-111c25becc8b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12a6408a-e02d-428e-8197-606210f82325"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("13451294-e96b-4b8c-b3f9-7e55826633fd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("137e0172-a236-4072-8294-753d9de0d5bc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("13853531-9e34-4bc3-8d0c-fd353a08951b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("13bc40bd-fec2-4f1b-a4bf-68216866351e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("13bc4847-3d76-44bf-bc59-f644441bb691"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("143f4203-dfb3-4ee4-8602-19d42209eeae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("14a4b043-280e-40d9-86ba-238e3a16c06f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("14c23e7c-12b2-42a3-897f-fd501c2b182c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("14c6611b-cced-485e-be50-791015661d25"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("14fd27d5-3064-4618-833d-96a33b0b82f6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("150fffb7-d4a4-44a5-8c12-02f80c176c65"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("152f9bcd-bb72-4806-b493-3d8222eb4a68"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1594296c-024b-4671-be5a-446f3ae973b9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("164cabc6-dfe8-44b2-9eed-b24a1f42c1c4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("165820d6-297c-4267-8b8e-ddb38e774636"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("167b9074-4207-48e8-9826-5ab952fedac8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("16a255a6-9e11-45a7-bfef-3a8e96f45faf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("16c3a52b-7ee8-47f4-a2eb-732653b85d08"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("171b7307-e5e5-4187-89ae-3c2db22b483a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("177e53ad-494e-48f4-b143-9ef4c0001baa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("18564fc5-b4a5-4f9a-a29c-1b3cb701ad8a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1932c862-513c-4111-8b82-865d381faeb2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("195caded-8e87-474c-a4ac-0af609a3844d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("19e8cbd2-c256-49c8-b9af-a9c874b684a0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1b30aebe-b300-4c06-8efc-44ebc4141459"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1b6bfb16-dc77-4629-8c7b-bc52cb70cb75"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1b771472-8a81-4535-8f94-01f5ccfa10a9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1bd97299-9073-4aba-9c98-e54ff7a3d562"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1c0bd186-6bdd-4c78-8726-a81b6d2dc150"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1c583fbf-bfc5-4325-b8a2-d8d4a3f45a2f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1cb819db-ac8f-4c79-9a13-7d249d5603a5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1cd9a533-d13f-4ce9-bdad-22992268b40e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1d3f14b7-fe08-4072-b875-f5c224ffa0d5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1d46d2f2-0d2c-49d3-ab70-6f7958ff6571"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1d4d3a69-9029-435b-a3e3-e94254acbde7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1dde4c2b-a415-456e-a5b3-4c7a38478ea1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1e616e26-50cc-43af-b8cd-088738d28c76"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1eb4fd94-ffd7-4203-8414-6c8bd9a35163"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1ed625f2-141b-42f5-ba9d-12ce622283f9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1ee047de-1695-4871-8e67-40c848dcb24c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f2261b9-a5ff-4fb0-9b3b-a229ea0da893"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f2e6e06-b04f-429d-be21-8d001a37e4ff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f38118c-00da-4863-9565-6356c9102c65"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2018b97a-6f2c-4305-9477-9670bb9da5c1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2035ac34-63c3-4e89-87b2-128a82a98761"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("20869751-9afb-4783-8749-48591e810795"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("20e797c4-7585-4db4-bf50-8bd515072315"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("213219ab-d51b-4c4e-9999-48b58b4b043b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2142f78e-be17-44f7-bde0-9f440a796329"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("214e5638-e73a-4c29-bcfe-2f144ec24361"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("219615f6-0508-4b90-a602-58e2180e126d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("21d0b309-b930-4d08-bb70-76be3b3649a4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("21d9473a-e057-4908-b785-751718b51132"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("21edc997-78c4-4bfb-a225-b3b8dfbcf4c5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("223e713c-cbf8-4cef-92d3-61521943ac76"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("228c5f83-37b6-4861-82d0-6eb4283bbe1e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("22b9f70b-7953-4b90-b2c3-f646e4a51392"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("22bbef70-1452-4c6f-985b-1ab52a08f55d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("22c38c87-483b-483e-976e-301ab11817c7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("236e273f-5bc6-49c4-bd9d-b94974de57dc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("236e9089-f715-482e-bea7-1021e7cf96c1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("237e1a0b-383f-4198-80e9-e237bc5735f8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("237f6fb3-8686-4e8b-8fed-48d1ad182fe1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("23cd2b9a-87ce-47c6-ab52-3a5996cceb50"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("24671085-cc3b-4475-84a1-5fed3216fb8b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("24ba916f-691d-4b39-94df-52f1d203b188"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2500e589-c95c-493e-805f-bd4ee9cd9f17"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("251ed232-e466-4179-97e8-f769c2c81064"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("25251c02-342e-4d08-856a-ee448a8d3f80"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("25cada92-1b33-4b1f-85d5-0ce2df324b58"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("25dc83e0-9d84-4059-b285-68b502629678"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("25f07af2-82d1-4c37-8338-7f610721cedd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2600a765-d3e9-471f-8ca8-1397f580d579"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("263c6612-6a7a-47f0-8b87-22ea13c56575"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("268f311e-0234-47e2-90f5-a37a648e864f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26d4fa25-627c-4bfb-9d09-ee50aa90e237"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26fc0f29-ac38-4fda-8d7e-ee4c43dfd331"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2769a28f-d1ce-45e2-9850-dfedc0c9e936"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("27d462b3-ed8c-432a-9e67-cf543b93d64f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("27f9349a-29c2-488c-ac9e-0248dd5a2ca1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("280542b3-654a-443d-be09-c08d49df9ce9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("282917aa-3fde-406b-bab1-afc882251c47"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2859993c-2dc3-497e-8937-31e3d86e5009"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("288728cf-02e0-43f7-8d83-3bad6af65dfa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("28a120e9-c5fd-4afe-a93f-73e31a705648"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("29343e3a-633a-492e-b737-4ce59904e445"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("294a396f-852a-44a1-84b1-fef87898357b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("29820f05-e491-4c57-ac5a-10f18ff3384b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2a0b3923-0e3d-4200-8b01-440acaaf0d78"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2a0d619f-f417-4fa5-b604-ad5f391eb600"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2a31394d-e2e5-46d4-a30d-e5860539d7d1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2ab1d871-92cd-4494-8b28-ae744b7c4ffd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2abcd691-0382-4c72-b750-f4760799682c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b36a78c-e2d9-4bc9-bfff-4296cb76c3a9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c12daeb-5970-467e-bd22-b1043027f187"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2cfc2637-a589-4cda-852a-187a7f6a9269"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2d01f721-c1ea-4df8-9f35-b105c358bc39"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2d1fdb4d-95a1-4e42-9671-18fb37db59a1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2d85f871-b0c5-48b9-bc05-8a7f85783250"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2db7bba7-14e0-4ecf-a752-658d11d0e6e7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2de75c04-2010-4456-9bde-b8c0ec9740a7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2decf6b4-e164-44de-86b4-22e9c02259d8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2e4d4984-8fea-4c90-88ca-4643e89e1b68"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2e653266-acf3-4874-9781-8516dd4c0722"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2ec9ba3f-95fc-4500-ab09-6b3951ac66f2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2f24ce9e-f819-4b21-a554-737b113a0460"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2f7db169-a2be-4077-8c59-bea280409f00"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2fb69673-7cf9-41d0-a842-5295df624328"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("30763818-ad6c-4dd1-ba9f-1bbe5e457084"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("30ca9552-02cf-4c66-a39d-8af63b2ea3dd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("310793a8-d015-458e-b0e5-e059ea0999e9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("312bdb8a-37c1-4fcf-ac6a-8f1909f4db23"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("313b5e5f-0773-4a6a-8a7f-b05685bf9f47"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("31706221-ace6-4aad-9ddd-3b0a102a5264"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("31a5c82e-ce98-40da-9c52-2cd2f63f923b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("31af33d6-fa5d-4d77-b4a4-1e0ed5447bdd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("31b34f92-7cbc-4eb3-a2e0-d5470e956106"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("31c3ba03-e3dc-4ddd-b525-2ebe408f9984"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("327bba68-3fd6-41bf-baa1-152879628493"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("32fafd88-7816-4a59-88fe-15ab25537397"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("33cf153f-6fd7-472a-aa6e-78f02e90d398"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("33cf7961-6b40-4814-b09a-ea3bf5bf6f07"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("33f92d9c-4cc3-4603-b83e-8ba96e1d1c7e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("34031312-c042-43f1-b5f3-dac7cb1f9a87"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("340e620e-8f9c-4cfb-a17f-ee178f11f368"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3436d45f-e3e9-4dde-bbe7-6f86fe0706b1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3451ab95-03fd-467a-be95-639a37dc0178"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35157adc-3615-48c9-938a-7ba4350a54e3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("36513507-dc00-446d-a94d-f11b7ca7a0f9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("369d1464-c61f-4d6d-aca1-f0853f7d4c6c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("36aa8a7b-7f63-47c1-8b95-2e1f9161c186"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("36bf9197-e289-4147-939e-0b587645ff91"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("36ecd3e3-e4aa-45d5-8b26-fec3e8db9489"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("372407a2-8cb6-434d-9c1b-e6a4f433ac3c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("372c3f44-279d-489a-a789-a37ffc4fb981"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("376c667a-74b2-4484-a104-0c60cd79f219"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("37ad2aa8-ef93-4f43-96ac-4784a0ca1168"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("38608a1b-eeb5-4806-89cd-10afcf19d792"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("389d219d-426c-440a-ba1d-586b8ef06fd4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("38bde9be-b830-4bb5-b5fb-fdaa74759c66"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("38e4aa2e-22f9-492c-a0aa-fcdd2ca8f47e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("393b05ea-7f58-4a14-9fbc-cd48671f472a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("39599055-7429-4c86-bb79-b8bdad9dfe6e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("39b4c863-a499-4956-94bf-04325dc9b983"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3a169b66-41bf-4944-a5cc-dd3906219199"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3a643978-2189-488d-9030-9b01988b5477"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3a9565fc-422a-4dd9-8beb-07656f6409d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3aa744b5-0744-4489-8b92-45bf9750ee3b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3ab2b947-fca8-4ccd-8522-0b87c20d9927"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3ae0143a-4551-4016-bd4f-4006f36b5e88"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3b0c9f7e-5112-4c76-bd00-2aaff345c5e4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3b1cb430-f1d3-4015-a18a-666958c1620c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3b53d450-eca1-4ab0-a97e-05cdc1452e23"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3b59874c-4d7c-4b04-99db-a90f1c6875a1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3b883936-ae0b-4665-8899-2b0f9accc19b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3ba9e087-8962-4d8c-9667-879f4893045c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3bee798c-c17d-473d-bd51-eb90e7e1ac2c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3c005404-9b20-4fd0-af35-45105aa232d7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3c419bfa-5761-4c9c-b8c6-c9eaf3b9c836"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3cbe67a2-db71-43e5-b18d-b5a579418f17"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3d32fba6-ed76-4fe4-b7d1-872cd1666679"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3d62207e-8fc5-4737-92e7-de2c7d197465"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3db71e31-0ac5-457f-ba4f-57675438c66d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3dcab791-d3c1-4380-bd1c-260ba3d9bea6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3e912b83-5060-4dc7-a196-8da10eb4d317"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3efecc59-d5e4-4293-971b-82c35bace12f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3f0fd6aa-1c48-4b69-9bda-4d8e13307f35"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3f1a1418-fcea-4a7a-8b31-8bf53f923aa3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3fb00355-1d1a-4c2c-b3cf-d206068b22c8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3fee6def-86a6-4c0d-8d53-e375f1486f7d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("401bd457-c6ef-41a6-a3f6-6fe6a2c4f678"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("40278c2a-2849-4f6f-a257-649721e7a8b8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("40e607bb-3e84-4a16-8dc5-1346cb61ee9b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("410247fc-0738-4867-83b4-53fdf36ff1e3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("410fa392-cdf2-47ac-a5f2-519a5d78a5be"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4120737b-2370-42c9-9696-8f1636749a30"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4193c66d-e168-45aa-9a95-e15b42d7dce3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("41ed2242-1b02-4329-a5a4-50f593881724"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4315bf04-9d46-4581-8420-cc2591cd4bcd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("432a7608-c8c5-432f-83f6-6994b86aa518"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("43977ec4-e3fc-44a7-9c91-6add03f2e197"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("44189d96-14af-4360-9cad-bfb3ff9874cc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("441c8e7a-9e17-41a6-8948-2d7c260497d0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("445fc7b2-ed17-4736-bd8d-6750e1e45d61"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("449a578a-f3f2-4fa6-99d2-6c02f7ad8317"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("44a09f1d-15e9-4edb-99ce-181daa87b4a2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("44bc56d0-1602-42e7-af60-db2537afa6cc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("45b00f12-1393-4ece-b3f1-566f70efd43f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("45ba8eb2-6f06-4ef2-9145-6cfd6cba9e12"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("45db7c6b-abf8-49de-aab2-201c4428453a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("467eb27e-9727-4529-88b1-9155c343ab83"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("46aadd52-3dcf-4afb-98a6-48e08bc6f6b5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("46c6df24-c7b8-4dc5-a462-df91262e7a6e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("472e2706-83fd-4826-a4fc-fee3782fb74c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4784f754-8e8d-4e3c-a789-d9c193df6f81"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("47b35807-aebc-41c2-806f-a96d93faea4a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("47dcc4af-5028-4643-bb66-9e01b8c69768"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("487503cc-cf6a-43b6-b577-730ba62ee7a6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4887ae57-bd04-48fb-ae35-123301c48718"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("48cb8cf9-d618-4a20-b43a-cd7a1272fcfd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("48e427b1-b409-4e5a-8c10-4d23d9e99c8a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("48e559f0-5204-41e9-8521-04947700256c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("493610d6-d7f2-4c73-a25a-8a9b036dc7f4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4979bc0f-a45b-4c84-bf69-f02effc48508"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("49df3e75-5311-4e75-9b25-508306d4c3c1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4a290b55-1a0a-4763-b640-db023e7c51d9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4a6eae04-6dbd-471e-82b5-73e5ea40587e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4a7a3d66-9a00-428e-8a5f-563b92a27077"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4a91fc0f-c6e8-4678-9d3d-0187cd24f8c8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4aaf1e41-590d-4e68-9b8f-7b5feff0c3c4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ab9c97c-0767-4db7-b3f0-35293157f8eb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b0a9183-0354-435b-ad01-3d68e96c260c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b12b102-4e17-4c15-8271-f0719546c7a8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b6ea1c4-1e55-461c-9250-63103fc18a9d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b8af1ae-9863-4477-b037-3ddf693e799a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ba539a4-c1c2-4051-97b0-46793fb40cef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4bb5adbc-c665-4ab5-8048-2d6c248bc592"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4c0566a0-85e6-4a08-9ece-353189479af5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4c0e61a3-fa16-49f4-a0ff-50d1b55fc7cf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4c269ecc-d878-43f3-bba3-87b68ed29d97"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4c45261a-e1b0-4527-a249-50d01d76bfd4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4c5858b6-041c-40ab-9f3d-b7778ff2d101"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4cbe9fd0-4dd7-4b18-a607-b32b22efc0fe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d06710f-f807-4776-8228-7b4ebd445b0c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d43ab23-ef4d-427b-b6a7-48236c85fca6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d82cba7-fb04-47fd-bdae-bb7c33e85c5a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d88265d-2364-498e-8f28-52fccf5a48c7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4db3678f-b5ef-4712-b513-5860ed2b803d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4dc0fe53-309f-4d97-91ff-8a102fc01c1c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e052172-e232-46b1-8f2b-82b31a3ff8f1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e15e903-0a04-490e-9e79-a676f31db6c1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e21804c-5594-4ee1-8fd9-2c157ff440ee"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e82ca24-99eb-4871-a003-32142a304d74"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f42340c-449a-4cec-9985-9d2b1f31abd8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f91ef2e-41ef-4830-bb71-9334744d749f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4fd61ccd-be31-4442-b695-b0a4a64a92f0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4fe15030-5a34-4ba7-b4e5-c95601ad5f4d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("50290830-b952-4e6b-a63b-13f0be9ae163"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("50e1d843-a1de-4883-8bc8-4d6fda970cf8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5179f6e2-50dc-4d56-aedb-199509f5c2e3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5199baf5-acfc-4df7-972d-1d883ee4c18c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("52090aba-1684-4579-8ac5-26626e58ee44"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("525cd3e3-f3a0-4a45-921f-b47fab45412e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("530b358d-7d00-494b-af7b-4bb51f1790c4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("53175ae3-1b46-4c03-bcbc-ee460ad8641e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5320d71d-6e6d-4302-a2dd-aa7ea3a1406b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("53613df4-893a-4321-960e-723dae32ea68"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("53b5d9d8-5ed6-4952-a292-40c357a42a9f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("54776031-6f5a-462e-aab2-28600f72101e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("54bc9675-f514-4947-a208-153d697fe298"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("551aa2a2-da64-458f-b6b0-35a75ff66a6f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("553d3b91-2054-4aab-8040-2889d2f3b894"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("55a40f0e-bc66-499d-af22-389b3c8c2ac4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("55bb62cf-f904-47f8-94d2-40cadec21f9c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("55d21efe-55e5-488e-917c-6470ad094583"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5675fd28-c043-40d6-aaa7-f4db65feb7b1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5721bac8-1920-4157-9d71-25e565efba31"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("577fc86e-62c7-4b99-9f16-4b780460d3b6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("57836563-f23c-4814-a46e-0bc933a5ce63"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("57e21092-ce04-4712-b3bf-7dd8a7158d52"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("581c696f-d6a7-40c5-81c3-7b30838f8d54"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("583e95d0-e253-4483-8e89-3e62b01cd731"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5874a386-747e-4149-b8bc-c40c1829f079"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("58817238-6e13-4314-8abe-7cc1b0572578"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5899fb58-9280-469d-a6f9-b345a90df279"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("58dd90b8-1f66-40ad-b21e-9e6cb54a2d65"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("58edf455-9c03-443a-85ec-e76e0679e629"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("58ee6a3e-af59-4fc2-8a2d-a238d1ed9b9c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("58fc4609-5759-48ef-97c5-91c0e7cdcab1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5925eb14-c9d9-4f4d-85b0-1260c6257487"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("596b8841-9f28-40e4-9c32-881e823ae668"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("597d40d9-8b51-4227-95c9-36eadaa97e57"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("59d4ebf8-0746-485d-8ad8-736afa9446f2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("59d8955d-a589-4ade-95e9-1e5a6f7f8f39"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5a1d0c98-b8a0-45e9-84c7-84ecd809c311"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5a609534-da95-4b52-8ea6-2e11d2e4d2b9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5a7d9f40-eb91-4999-bba3-b6f3ab14b270"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5a8295cd-5bdf-4345-b242-80eab6e9dd00"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5b081437-fcd2-4af4-aa87-5a762ba79ffb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5b7fb978-6422-449a-9a19-225d5fd9c69e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5b9ea8f4-6017-4a32-8406-7f6251cb5bce"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5bcd5d6d-0aef-467d-af2f-c7d678b2fb05"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c4ec39a-b880-436e-88b9-2bfc0a61e52b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c60fd8a-1978-45bd-8edd-8b7a3340e44b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c9b4545-29d8-4be3-b85b-2b98acdac1d4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5cf9fe1f-b67e-4c36-a3d3-a24ff6de47df"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5d58bad5-f9f4-41b6-badf-89a43d3520af"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5d5a7616-cfd6-4d17-a2c8-6a1a822cb752"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5d694da7-6063-4f92-aa3a-191a21636344"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5d709fdd-e423-4adb-9315-8c669252e4cf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5d99a1c0-ad26-48e6-9196-4de412b44bab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5d9c04e1-37a1-4507-8148-fcd5ee320eba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5e11a1e9-2522-4a92-b6a6-cc9efc030ad6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5e84edd7-6aec-4b12-a46f-6d38d5e0d223"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5ea4b1f8-e19f-4d2f-af23-179177afbe9e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5eb637b8-500d-4476-b861-5273291ca24a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5edadda7-dad5-4b96-9b09-c32f1d71dff8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5f1cd2ae-28a5-48e8-97fa-f9857957535f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5f3ad2e4-a718-49b7-acba-0583d6ba53e7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5f9d54bb-79b1-4630-aca4-d234875b719a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5fff454e-5b2a-45b0-9bac-732a9dcc64a0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6004d687-988e-4404-bc6f-de70861a0f79"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("60096114-f519-4ce1-ae77-70aed540ee26"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("600e1667-b88c-4427-b464-7d16f4ec8327"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("603c1a9b-4d5f-4071-b4c1-7c80faa2cae2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("607b8c08-f0f1-49c7-8498-6df378ec458c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("60835563-6d4a-4ef8-a8e5-1b4db0d1a4dc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("60c6594f-3036-4b9d-a620-a5afdb1e187f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("60e58d6b-324f-45de-acdb-01c66442f170"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("60e77d5c-8ba2-4962-885a-b816d5fbd45d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("61164703-fd48-4076-aba1-51b8863fb157"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("61f12477-125a-410f-8425-0e455a75d741"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("61fa2d94-21ea-4234-9c47-89365fc29d81"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("620304a5-5e73-4cdd-82a1-69372ee100ec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62491921-1312-4c0c-b03d-49c51ab0bef0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6250d3d7-a4b8-49a8-ab98-80c166da1910"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62604891-e720-4e9f-b49c-7cbe47e9aa93"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62a7f5d1-f053-4af2-a248-8421f11c500c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62ea1143-d869-40d8-8e89-adc767a377a8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62efb331-59be-469a-a9fe-b62525dcfa6c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6365bf95-cc50-4e79-ac3c-0e1687b74796"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6379289f-4dd8-4279-95e5-b0f2dd4e38dc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("639bab1e-341e-4e8c-97ca-17cd1823cda5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("63bc7337-e5b9-459c-8cc7-1d4fff109b77"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6410c170-ff47-442e-ba32-4c20a124ee21"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("641e0432-f8ec-41ae-b625-0846b34adc18"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("64231079-18ae-4128-9f2a-82eacd6a087e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("64588e2e-a092-4d97-9cff-a1fbd787523f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("64b01e62-45b1-4e7b-98ac-810992ee4d8f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("64fa558d-eccd-4563-b7fa-3f4aee5107ea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6536863a-aed5-4fea-a869-05ea4864377a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6543feb8-701b-48fe-a3a4-c71a7977c4e7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("656c7b79-6d1e-48e7-a737-5d493f5106e6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6575b68c-04ad-44e0-9e8c-c356886b72c2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("658fc3d6-952d-4b18-9616-e130be7e8301"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("65ff73ba-bc6e-4266-8a50-be5ac6b0b465"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6676e8c7-2619-4095-b0d0-c743c3e6d767"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("668cbd41-0ff8-406b-af3b-14c0d37f5d22"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("669306ab-d393-4247-b152-a20eac05d17b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("66ac12b3-67d6-4797-a4a8-daf6e02bd0f8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("66d0ad42-7d98-4fb0-8fcb-cd13ce430cb5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("66de500b-c6f0-4fc4-bdf4-343cf2ea3fb6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("66e05738-ca43-4da7-8c7a-552b91acb2cd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("66ef502c-ac87-4874-929e-8d8d13733b7a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6739570d-27c4-4bf5-a9d7-589dfb89aab4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("67e5477f-33d2-4808-9cdb-b9fa6be2cb08"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("682e1286-cdd2-4c81-b348-6cf15d6a5bdd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("68a24940-0097-4c6f-b841-72f359053315"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("68a3ba24-fe86-4905-941b-a2d0c069d1ce"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("68e1414d-2e19-4188-b8f3-deaab11ecb24"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("69579acc-d5da-4090-a597-a7a167955d52"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("69591411-43ee-4349-a49d-f84335e1236c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("696b5e51-d93d-4e90-ab46-ad30f53c3c55"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("699bd468-f6c9-4381-b9db-35f2741f23bc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("699eeff1-5b33-4ea1-8b70-37c6b5343b80"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("69d8be29-32f3-4060-a7e2-22ddd38f65b7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("69dd660b-5001-4696-9861-9db56e22b3ed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6a25971e-4211-48fe-a9c8-fe2b3ead5819"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6a338c9c-30d3-44cb-b6dd-9459e232c410"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6a4fabc3-b403-4d9c-bc41-9c8ff6404228"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6a868189-e142-45ce-97bb-788cda5381d2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6a8cae75-d9df-499e-8057-a74842798b11"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b036341-9e0d-4f56-bf37-2a1e00c805e2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b2890db-46ab-4c14-a3a7-1df892a8d360"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b3f73e5-b2fd-43b5-a781-294d08ccaba0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6bb312d2-2840-449e-957a-5b54a3cf8c01"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6be01fe5-56c2-4ad9-8178-74771c21ed24"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6bec5a6a-5323-47fe-938d-9bb17c044214"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c5feb55-5ae3-4252-a183-d8e592ed48ab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c67588f-3867-4ea4-876a-0e1aecccdda7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c89be8c-78b0-427c-a6d5-913e39010f82"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6cad4062-3938-4f5d-b4c9-a80b747ffc53"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6cd88c5d-2127-4388-bd45-459c82c82d99"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d022a9a-69b1-4eb8-8260-74f2f77deb04"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d1e3505-61b0-4e7f-a7b5-a3041ea25037"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d277852-9ad2-4ec9-8da1-38e775bbea1c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d796298-cff3-47f2-ab8f-6adbe7cc7e87"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6dc02a69-7a31-4e45-b35a-11a7b0b5ec1f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6dc950d0-fb26-4813-b385-ef0034709a2d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6ddd6963-e58c-4e36-9896-9351600a4794"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6e08cc27-dd3f-435d-8def-edc72e0ad913"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6e21f138-7a87-41d5-a7c5-c3bb12386ca1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6e4c1699-0794-4fe5-b625-c65f5de471e6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6e66a94c-b435-4657-a517-bc0c20c7a6e9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6e79a65b-5610-4742-a921-3f9b5a3b4205"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6ee0d954-241a-43e5-86b9-4f92d86e0cc9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6ef4201f-b699-4c73-a181-6646525439d1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f324c8a-1f60-4191-8943-3e516e689e1a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f652f03-2a97-40e9-ad00-0a87d05fe79d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6fe1eb42-b962-4ed7-8100-65728b74734a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("700a9b56-0a7c-4348-8d46-815a4e30ff21"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("70422957-bdb2-4fb4-b2a7-4f03526dfaf5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("709f62c1-8c37-41d1-870d-fc6b41d12287"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("70b8472d-1784-40a9-9b76-52663e53b26c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("70df9642-ad01-4e86-b369-ce828c616616"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("70ea333c-19d1-4430-80c5-1bc7a63c63c6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71059850-ed1e-40dd-acd8-eaed50b995c4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71155381-b2a2-4f8c-8d3c-2c07088c3da3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("711fea52-c107-44c1-be47-4f274606f340"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("716d185f-1387-456b-aa7e-f43a27f387c0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71f56234-e466-42ba-b8f3-f36b6ac1541e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71ff5d96-5616-4636-a0e3-f1fa21366614"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("72e81e98-7ac6-4c23-a1ca-285fa96e331e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("73cf374d-fdfb-4715-b9b1-b0dde27524d5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("73d2dedb-3bc8-4e3a-9cdc-0eb540a0964d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("743e30f6-e7ec-46d8-a5dd-58d7b720ea71"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7496d5f6-5891-48de-81e5-7a0ca65c4e3a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("74d908ff-82d0-4c8d-93fb-c3e38556c8aa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("74e1e19b-6bd4-404d-acc7-94a144bb4d23"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("74e3ef62-3755-4acc-8f3b-f0c7c0b6187a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("75570734-dbeb-4876-bfe8-1b6dac83d185"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("759ae541-84cd-4067-a6e0-cfe329ebc5b9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("75ccdc2d-d0b8-45f0-9036-b0dcdbc69d34"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("75f7cd08-754f-462d-97e1-0f844153dc33"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("762eca00-3087-4a64-bbcf-a8bda526fd63"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("762ef9c5-9c26-4104-80f4-35d1a4e1604f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7646e09b-d6ee-428c-b669-32a20eb7f955"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("765873eb-e342-4dbd-ba1d-e297fb3ec436"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("76b8d726-a359-4887-b5ed-b9e14793d1fc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("77d4a1f4-2526-4021-bd48-7df7e58fdf96"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("77d95f69-5835-45f0-8de9-b7efd7353e37"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7829f0ac-3d7b-4b9e-a242-ddb264c09950"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("782e55b5-5b27-4978-a409-8b2942af0103"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("785edc88-fa0b-422a-a962-76aeabeeee1d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7867659a-4097-4afd-89dd-44dbf825df2d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("78951cf3-60f6-4fc1-a079-09e3b56e4bff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("78a1f480-3543-4ddd-bd56-51f709cc29ea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("794d3e88-5bb0-4bdc-8732-a1b69ab513d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("796577bc-19a2-4f08-a7b5-b0d693cedf5f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("798b6133-03dd-4d86-8cd5-a7c57c776d85"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7a3abfec-1f3f-4ef8-9774-07b730401490"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7aefd5d1-b7a8-48be-a572-063e53f20f1b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7b14e67b-cf18-40c4-981b-5f2bdf9017de"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7b2d13d7-cc97-4efc-b7b7-211cc45ac51a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7b89e71f-e465-44e8-a110-5ab0dd33c4e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7bc5d18c-0cb0-42a8-b13e-11cff56ae901"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7be0c894-5408-416a-9410-7f0fbc0d09bf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7bfbab54-84e9-4500-a5d7-b3eabf6dbca7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7d7f3661-b3b0-46c4-a9b1-b7553fde6827"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7dc61853-5019-459d-9799-28758537f2b8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e11ff4b-608a-4d12-b977-e9914b3984c6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e4136bd-788e-4c9c-8c05-4e3b0986ec42"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e5518f3-5385-440b-b92a-082f5af2664d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e58b54b-46ff-41e0-bfbc-c57fff01b589"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e61e621-5c01-424c-8867-be6de4f6b7bf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e932f6b-b43c-46e8-9323-d5682a10b02d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7ec54e86-c632-493b-98b0-6070102c4caa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7f53270e-4ac7-430a-974f-92d9705a4f3a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7f594974-a007-4d6d-806a-6493a1d453f7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7fab2792-a22a-42b5-8322-6a804a911e86"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7fbd3629-7b77-494e-a6b4-7f0769dde49e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8024a73a-e56f-4c60-a13b-f73eabf912da"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("80377c51-4243-4fb9-b4d0-96b5f7a7a91f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("803aeb41-1be7-4e4b-bc3c-c8e7a97cf6ea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("804d0d6a-dc76-488c-bec9-db866676aff0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("804eb3bb-2d03-4e1a-9ab3-431fc3a62c22"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("805f0658-7188-4d9d-bfa6-d99406e2bf8c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("812bec13-7e08-44a0-a360-9f8b98d1957e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("814ab96d-d202-4160-bac1-47c5f22eb96f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8153874f-d63f-4447-91d8-9da0ddff3d46"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("817dbea8-fa16-48e1-ba64-36fce16f2b81"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("81d58d54-2bea-428c-85b2-682ad28aad69"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8201a765-7f3f-462c-87f3-277ddfcbf28f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("82108a5d-ff04-4efb-8fdd-385d2930dcd6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("824d217a-2718-4cef-b630-fe50ec425f31"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("82624268-dc27-4141-b2c0-a770b660fbbf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("826db9d7-134d-4e83-818b-25577cdeac26"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("82872008-d8c6-46a2-91ff-e39745e0a503"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("82b16e67-1219-4156-a0de-106db75397ec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("82cf2397-3462-43cb-ae47-6d54f526f8bb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("82da3073-b549-480c-a257-cd919c75f256"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("83256631-55de-4883-9c92-a9dacab8bfb0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("83cb5910-e10d-4449-a3ae-ffb48c13d5fb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("83d42258-5fca-47a0-a83c-deb44f814904"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("83f05c97-cd8d-4f2c-86a7-02eeebb190c3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("84127764-671b-4f7d-ac8a-d5c3036b26c7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("844dce8f-081f-42e2-9f64-0dba4a8501ea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("84acf872-b4d7-4279-9959-b83ef8057988"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("84b37072-fa26-4a47-9123-b997b16bfd4d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("857428da-7c99-45fc-8913-fd51b79bbe64"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("858441fa-b2da-4e99-b1c2-005b08284719"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("85f471b6-62e9-4239-8d67-35f0cafcb87e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("85f56ae0-0cb3-470b-900d-326cd4b0aa00"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("85fa1c35-1f13-4aa6-87f3-1b188dc5a2ec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8615d554-fb87-45b8-afbb-c59e8e252150"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8686f09c-060b-49e7-a83a-6dd479f47c57"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("86d32df8-dd2e-4b20-b097-42b204aef208"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8749d19a-1849-453d-a9c4-60a123e90e4e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("879829ec-38a0-4805-821a-f8679b0ecb3e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("882274eb-d26e-4af3-846b-a4d1e0f4a794"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("885231da-a486-4d4a-b594-eb7550d53933"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("888c33bc-8807-402c-abe1-d985b4f041d2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88c7403f-fb67-45fe-bf1a-b36648511242"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88f21e20-1d14-4f27-8ba3-c96adb43bb21"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("89264ef1-a22e-4670-ad9e-380173d9f57a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("892ede7e-c8fa-484c-b62f-6a8fbba136bc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("893caa55-7ab5-4207-b186-4cab88510e36"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8947ff48-1197-4f87-b8a2-33d452f0d60c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("89a080b6-1f27-4063-8dfc-c1bdf73e7747"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("89bbc231-c142-4551-9237-ad1d9beb37e6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a06864f-a23f-4ebf-acff-92643d43b014"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a2f9bff-efb0-44a4-b1a4-62dad8c07318"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a442c4d-09b1-4b65-9e4a-aab777650100"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a8b5f0d-2f40-4d77-9591-13870a42bbbb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8b103062-1db1-401a-b9e6-627ed43bbbf9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8b525c2c-7814-436c-aec7-b5f445d4c398"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8b84587e-fc0f-430b-acb2-29eb74aef60c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8b868d0b-68bd-4971-9774-859d9ce855d1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8bef2957-a499-4a83-b6eb-6a53dfb71b88"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8c700267-ae7e-4bc7-982d-fcf607065466"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ca54009-5881-4c6f-88fa-59233ff54ed7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8d0c0b7d-bd6a-4ebc-9572-5742ef1ab048"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8d332584-2d45-41c5-88ca-62dc7bec40e1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8d804bf5-a505-488c-99db-53ac91525d22"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8da505a9-5335-49ca-b53a-63ec72bc5147"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8daed7c7-11e9-4fc1-adb2-87c9c7abf755"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ddae73b-072a-4557-a783-4512f3606fa9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8deff9e1-5c06-4e28-8410-5651ce77e6b8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8e0360b6-e6e1-45f2-a78a-95d3d5f02f07"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ea9f930-4121-4c02-9a0b-23e537c7719b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8eba47f5-0d90-45bb-81e4-c4c445e8f31a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8f05c58f-e3b7-4758-94b7-b007e803775f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8f0bb9cf-456c-4551-a0c9-815162939603"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8f52a171-d5b3-45e3-a46b-2a5e3a3c1244"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8f7899d2-64cb-4d96-aa06-a53a32928a12"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8fa0baa3-3a5e-4e21-8bfb-4cb9dc5ca5db"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8faa2fb7-af46-44db-a900-af24d90347a9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("90044296-f87d-4664-8db5-325ea24c8b96"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("907661d9-f219-482d-aac5-a2a230f83065"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("90ebdcd7-7c5a-49ca-9d44-7dc4723a66d3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("90f1af82-939e-42d6-951b-bd28a6c904d0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("910558ee-11d1-4d1e-93b8-9d9d739e4f0c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("913767c4-be17-4c59-aecf-19e3553cfd3d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91431e71-2897-42de-b8d8-1a1afac692bf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9170baf5-dc40-4c62-9619-c47991629b28"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("917d086e-ca72-44b8-a728-c7d3ff9554d2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91eeed61-610f-4dd5-ac55-f8a9f5511de3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("925546ef-7845-48a7-8e55-6eccf6469737"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("92d57f5f-113d-4748-b1e5-be2beab8dc87"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9351db28-6c29-4aa9-8147-d9a0f5c9534d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("936578e6-f70f-4e69-bf58-25ca118ceee9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93798504-6759-4b00-a7ba-50d653c4d9e9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93f4a90c-bf51-4e6f-acd8-c43890fe6f11"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9417eaa7-42ff-4dcc-9163-b0520c3a7a56"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("941c976b-6e0f-48bf-96a0-5520a7ae03c2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("943b828f-b8e0-4c62-98f7-40826b733d46"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("945882ef-9c56-44fd-928c-edaef3de4333"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("94b33c9a-de5c-4321-87d7-c30ae122f3a7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("952b2154-15c2-4564-a162-7f361128c33f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("955c3d83-83bc-493a-a4f2-97f848933456"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("957a94c1-d024-4155-931b-51721323a470"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("95952007-aec8-48fb-9fdb-a21d6b5a2ff2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("95a14b65-2fe5-4eb1-ab78-9e0c59c7ca31"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("95c35f24-219e-4b00-b363-c61fc15aedfe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("95c903b1-83f5-4c77-8b60-fcc9b674db9c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("95d8e89a-eea0-4602-8cf8-92e11fee62fd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("95e63ac9-a39c-435b-9ce0-5ec27eb7d1b9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("95f20196-85eb-431e-bd2e-83516daf2340"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("960a9268-3e65-4f73-9fca-7e2f7023dd1c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("96a84957-081d-4ef8-a10b-9ba9ec2bd0ea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("96cc5edf-f516-4f86-979e-483d0eb3a89d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("96ddfc4d-af7b-4caa-a37a-55c29f717add"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9702605d-88dc-4966-8069-755ebd3a8df8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9715a5cd-b1ad-49f5-b819-c8a22924846e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("97390d89-d4ba-4e66-a9f0-e1c48198d647"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("97512776-9347-4159-be71-35e7b58cd035"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9764f853-ab73-404c-94a4-acb43261c235"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("97df2e8d-066f-474c-b1e5-47910a2d8e88"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("98138ceb-ce7f-4c91-8503-a295948adcba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("985947a5-78e0-4dee-ab97-99ebbd94227b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("989f162a-5a4b-43d7-8074-42d21a67ea5b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("993038b6-7e77-4830-9a2e-dbb3828d17c6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("996b8b09-a74d-4092-915c-5a1dcfa5dae3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("997a098f-1c1f-459c-bddf-ffbab5c3b4be"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9986d2ca-80e3-4a04-b159-4dfcd8fcce4b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99dff0c4-c709-4989-aee5-35e9963b2bd1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a17a185-444e-4515-a8f8-df4cc007a082"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a51ab49-ed78-42fc-8f86-4525f3157935"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a53131e-d7ff-4786-b3a5-498c91f436c2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a608bc6-a7eb-4845-b168-6f656809d11e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9afa1afc-5b28-4532-b7b5-7355d5f90f6d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9bcc618b-8a17-4842-96d7-3e15d41a324c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9bceb273-5413-49ba-8e88-3b1632c9b2c1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9bd49cee-10ec-462a-8866-d3993c5290ab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9beeb5be-1283-4646-84a9-12a21c726c2c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9c434aeb-0865-431a-a847-06410cc88296"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9c714681-56c8-4be1-a994-7ebe1555692e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d1c5a4c-3179-4e4e-9464-054db5443f95"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d51660b-21d8-4876-9ca1-a0e02a754674"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d51a874-b678-4aa5-bf0a-6bc99f5e2a51"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d5c6395-c912-4fe8-be30-19f47cbf4e96"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d762867-8d51-4383-887b-5bf4cf09e7ac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d9f80eb-1309-450a-a0e4-8263505695d8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9daa7478-d8ef-4655-ad9d-ecf70d63b682"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9ddca96c-e7c7-4425-980c-a04b7b3ecb78"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9ddcf0aa-d2e8-4b84-9216-7f426433d151"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9e67a647-651c-49e0-b17a-1e2a59a960a5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9ebe87a5-8965-4735-82ee-6c77346a610e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9ee8d7d0-08f8-401a-85fb-fc8c30fb6032"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9f13d3c0-aff0-4408-b7de-3b86bbc5a40c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9f1a1168-9032-4d28-9560-5a7d4227cd85"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9f2d4fe1-dd26-404d-bb1e-c5727e48847c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a01180e9-0087-474b-bea2-deea4ba561c1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0505402-506f-40f8-b80a-5506fb2bde10"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0c224cb-5559-467d-b28c-31e4f60ec502"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1040912-a044-4918-b4c5-f4ce0a0a82f3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1089855-5111-40ac-9e03-6bb6a13e14a3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1662723-acf5-462f-91f0-a706280c276e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a246faf2-84a2-439f-8275-2866f1d1265f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a251c76d-528b-4322-bfee-90194e65923f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a2529c49-3246-4f87-94c0-d4fcd9855928"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a2c182fa-0d90-4fc1-8179-557c27778d95"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a2c879fe-e511-4c1c-87b2-e3206d48a6ac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a315a241-cc25-4d23-a893-a201c82873b1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a32dc191-c37c-4dfe-b86b-28f3bdef5cac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a3b3af14-2d32-400c-9815-0d6f83531054"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a3d624c5-6c8d-4962-91de-f7cfe46ac740"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a3ddb193-8200-4da7-b1b3-ae610213cf94"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a3edfbf7-9a41-4f3d-9a72-55fd83994080"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a44d5989-f040-4f4a-b766-0a15cc98f56d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a46f5a83-6e86-43a4-8c4c-0e201b867327"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a4a7709c-db70-44cf-9a2c-57e92cf3fec5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a4ce7d73-ef7d-44e0-b123-cb4f888be45c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a542699c-104e-4ce7-a3a9-05a1b05e78fc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a549412c-43ae-4e00-b688-b9d831a070c3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a5515321-b6fc-4bae-abc3-6075c17daf62"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a57ece04-647b-40e2-ba5a-c41cb42ec023"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a58af108-328a-49d1-8442-7b5da3630bc0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a5ac533f-f83f-4c9d-ae9f-6576cb7398fb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a5bb4cf9-8268-4b2a-8c5e-9d130930466c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a69cbbb7-8486-4f76-b477-a335e02de397"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6c7efe9-5365-438e-a38c-591ae075eef1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6e212be-0d41-4bef-9019-a8c0608e23fe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a737123e-1259-4f91-99a8-01d551c950d4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a77b1322-5e74-4c5a-bd63-f2c9141a8666"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a7ac170a-0094-4337-9ccd-987e8fe817f9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a87cc4b7-b56b-47a7-92f0-a6821286b74e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a8ca0648-cdd8-4450-9451-d4a266deda9f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a8d95651-2e2a-4c17-b459-2c42f20d78ff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a8dd92e4-1b6a-4082-b7ff-1385b2d76140"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a8f01221-89be-4820-b0db-8c736d17d5d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a92b1c5d-c16c-498f-88b9-073aa51f3ec6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a9855871-1092-47d8-8500-a717b63492c3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a9c5fe0f-7510-4f58-bff0-c0df409596d1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aa44a61a-e827-4154-aa2f-85fc8f45f725"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aa916efa-7133-475d-b3b6-afdf9a2f8851"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ac19cb23-680d-460f-8433-963e363ca7c7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ac65602b-eab2-467b-b956-6b42f26c7435"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ac99a761-aecb-4d50-87a9-1fd9900e05c0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("acde3077-3cd1-41d4-8776-8999500a8d6c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ad94b047-3cf4-4c1b-bce1-9d5a70c19a60"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("adf22e07-23cc-4a68-886f-163257ffc5b4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae0b0f87-d6c5-469a-8643-a6dfb91c0345"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae2b00aa-f53c-4ccc-9ea6-718485615062"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae3882d5-71c4-4acb-baab-725265a9d597"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae57ab95-301d-45df-bd73-6024fd813343"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae77f493-80cb-4b8e-a4f4-0702da87d14a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aeaa1847-018d-4c30-be6f-fa63e5cde7dd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aeee8cbe-9fd5-4700-bf31-2c6c42e5152f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("af7abc87-48b0-40dc-9d8d-0f9897059f56"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("afcd2019-39d8-4cd3-938f-7077cba46059"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b06f694d-c67f-4630-b39b-5026e2c2f41b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b0956748-a690-4d43-b2ec-8e7440102026"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b09f9123-ed2f-4ba9-ae6d-9229d6ed0815"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b0d30e98-9eaa-451f-9335-83d7dfb54356"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b0edc212-3c24-4409-ac60-0d388f5afbe8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1128f63-8344-40a8-9c2f-1bd50fb62f51"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b15bb65d-bacb-4ed6-a929-e81a05c226e5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1867cf4-5695-444c-88d6-6f879fa6536b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b19257c2-9e35-46d8-9414-8a954adacb67"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1cecd84-037f-446f-b08b-ab9f21094196"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2359cf6-7bbb-4850-bc1c-4484cb81410c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2581c4d-086a-4643-a9d8-81474b51b216"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2abcdb3-cf6b-4464-a71a-3e1eafeb3756"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b30391ef-005c-4c6c-9637-b073571f9a85"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b313d450-473b-4e0d-b380-2af31d52f21f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b3339ac4-d3d4-41ab-8087-b936cb618591"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b3355be5-8ab3-48a1-864e-11f305be82c7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b36cf7fa-f77f-45cd-b46b-147203fb23f0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b3df67cc-e97a-4201-bb95-6d710ffbf259"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b40f58fd-0354-4744-b0a2-74146cb0c81d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b47f8752-8ad3-4b6a-b5cf-cabe568d40ed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b48500ba-b261-4548-a63e-3d239bed887c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b487f9c4-cf24-4625-98c8-8254f9deee8a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b4b43f9d-cfc4-4d21-92ec-997829af13b4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b4c31aec-3158-41d0-a504-2257ded7c1c0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b54a3b0e-b7e6-4442-a08a-852ee8aee128"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b56c4355-3b16-4674-bb78-68f045600ec0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b574047e-3176-429e-bdf9-3efe813dd6b0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b5c433cc-b9db-43ad-937e-9c1f56c40be6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b5d7842d-3301-44be-9ddf-43b30e84af88"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b639396a-ef64-42f4-a3d0-0626802a5a95"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b6648d85-6af1-4262-b209-a10f11523359"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b6883820-f735-4011-9648-177e9e6ecf4e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b69a4876-74c3-4967-ada2-81001e662056"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b6babea3-2d5f-491f-b000-1e1629f28c3a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b6e61a78-97c9-4e20-8627-8a909abcc16c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b717679a-fc03-47f7-988a-ab131273abc2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b72df52a-a778-48fd-9d48-c5d253b74bea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b78f2e35-4716-4887-82dc-531fa0923b6a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b7b445b5-978d-464f-b49b-5812450da80d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b841eaf8-ce42-48a8-9201-0bf0735bfa83"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8aca821-a884-4b53-a06a-98359b15c14c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8c7b34e-803d-43b5-b779-b211f4454fb4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8d45edb-106d-4017-ba75-20ae31b75038"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8e47c20-5014-4517-886c-8844c74561b8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b9089cba-dcec-4615-9a24-edadef6fc6b4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b93143ac-4aee-4a53-8eb2-1699b1979176"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b95a135b-1d39-40ec-adfa-c58aa4ceacb5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b9e595dd-7f02-4221-89cb-edfde7887e33"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba0f88e4-fd08-4a87-8805-8e81c9858ce6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba5cb5e1-31ec-4e6c-8d21-7f2ec099091e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba636696-2e06-468a-af3c-6c0d2066d5a4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba7788e5-be17-44dd-91e4-5f61160d2a8f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba78bee7-9af9-47bc-bd24-9fd83e1d1e0a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba81c59c-06cf-40d7-a123-a8172c442405"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba82f382-23c6-4582-adf3-2f6b0b0dd4d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bb2d0206-53fe-4f2a-8a81-ef9de8445f32"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bbbfd476-b736-410a-8804-44dafb96b03e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bbebe9fb-68ba-4ed9-9a17-7b9cc54fbd96"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc22e2ca-3f74-4cb0-af86-0ab4ba81daa1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bcc98f08-acc4-403a-8944-51744113ef03"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bd0aec76-2ff5-4e86-8842-e362daf8420d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("be1df106-c947-4370-865a-16c8551957bb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("be3d0251-dfe6-4fbc-b758-f10d56b76e65"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("be7d81f1-05da-49cf-8b2a-9c410641e459"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("be996f5d-a467-4162-8c91-8479a8478002"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bedfca1a-dc0d-475e-8391-0d842e00ac9e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bf223e28-0a46-4599-a9bf-92b97e6b7e2f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bf7dde3c-3e4c-4713-998c-c1022798a741"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bfe615df-2682-4728-93a2-61af8b53167d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0788b13-3d33-48a9-b7f2-261b61c4cad7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c09219fa-af7e-475e-b6c6-63dc9a13bb69"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0997b60-d2f9-4288-a320-c1af0a5e56ad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0d6e6a1-5f95-41a8-9557-5759783a0a18"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0e9f997-f1de-407d-8d9b-0a082fcafef2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c107a1ff-f203-405a-a6c2-87474083c5a9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c148aee0-4266-41c4-93eb-7dea228c4fe8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c16e2dd1-2129-4df9-bbd5-3d64f30e5498"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c1700259-886c-4483-a298-443a14625c3c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c1e9b5b5-c748-494e-85b9-be82b06d5bf8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c3292b05-9912-433b-bbf1-21dd505e6cdf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c32aad36-9f65-4852-8220-69161c48c689"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c33244a9-ad9f-4087-866d-1664737dbc85"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c3365730-6d24-41ef-a891-6d6c70ec45a0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c3aecdfd-fd0c-484b-95c9-79547fc53f68"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c3b2f1ea-1246-4e89-961b-5c79f605bd68"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c3b5fc08-7653-4866-9733-992054973c34"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c3c6e6d9-6fb0-4f19-9fbe-4351f1e08d0d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c3cf3052-0dc5-4a7e-a53c-f52891b9cecb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c54c2bd7-7301-4575-8822-caf29c6ec3c2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c56c1192-9c10-417d-b24a-774a106a6594"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c5a1c119-7a0a-4d27-86d6-1efcb4a3f5ae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c5bcbacf-2707-4f1c-8238-90b2dc0f45b8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c5d3eb00-5068-4dc9-b16e-7546f72bbf91"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c5dccb06-6134-4443-8d86-3fab987b95c6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c5ddb2c1-42c8-4408-b7c2-7d7d99dc4259"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c678a7bd-367a-4a95-9c23-e8a392577817"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c680c6fb-b9bf-474e-8d08-5999d6ae624d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c700a9e3-740e-46b1-a2f0-91952ffac788"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c73b73da-8787-4012-937f-88c9ef1bc57b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c7403fb5-0abf-47a8-a332-b87448603cbe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c765a59f-2e62-498f-99b7-868d6e1897b1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c76d9475-55e0-4e1a-87fb-8827836cbd3f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c793e7ca-499d-4650-b280-c8025b6ebbc4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c7a4e1c0-1fb6-4475-a021-873287f86835"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c7c11d0c-16b2-47f1-b3da-c09a4d0b94c5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c7d3ca07-9c98-469e-8cdd-cd2c9848b2de"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c8287d67-ea3e-4b87-a7a7-66141e98be2e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c8884158-6e99-4cc6-ab0c-4f4e149dba1a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c88dc306-ca3a-4c68-99c1-51bcdbd74562"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c8a9e9a7-197f-4ef3-8f4c-f205949cdb4e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c8b03957-d0ec-4f27-9b69-43c70d5bc003"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c923ad0a-5377-433d-8472-6466d3045a85"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c9a9a2af-6b12-4dfc-bd86-1d96e8517c9d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c9af57d1-833f-4d59-802c-c49f8f945059"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ca36d4f4-4e70-4034-8cff-d0be0d1bb683"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ca54858f-2410-4a4b-b114-8e6474261df2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ca5f75b7-8090-4e8f-9a11-72cf9cf63a3f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ca978604-6ee1-4a19-afa4-7c9bc51a2482"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cac4fbbc-a0e7-42d0-9883-143b74171a62"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cb1f1b2c-5448-4de6-846f-31caafd37151"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cb8811c5-bd17-456e-836c-868e1ec3e01e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cbb20627-c0f7-40d6-b94a-ef239732283f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cbee2a5d-926f-4021-a27d-e2eac2e757aa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cbee3a6f-5962-4ae3-a010-c4d0ffbe709e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cca5ba80-b18d-42af-a6e7-656c1a286d45"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ccb5a8bd-da39-42b6-b329-14949f57b427"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ccc627dc-e610-4ae9-bb7a-31b4e4bd0e92"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cd0eca73-5df0-4aa8-b322-505c0f15f724"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cd263ef7-7e59-4b77-a992-58d0447e31cc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cd35cabb-eac1-4475-9b60-6a82676bf74d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cd50e070-582f-480c-908f-5c40cfa36258"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cddd59b9-52d4-4b2e-9a1d-dad2794375d9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ce311616-6d16-4279-9cab-6584f7f28662"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ce4df932-fb0a-43f6-913b-bf87d02d4c05"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cee8b144-cd04-4150-92a3-48e8ccd02c3c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cfc2b96b-d0b5-4aa8-867e-39ffbc7dfce0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cfdd2232-35c9-45db-8077-616a75eefd38"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d035c4a8-18d9-4753-870d-b54198f67f4a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d0411b32-efb3-416c-b69e-199a46508a6a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d0806e51-1226-4bbd-a9b0-8522e36dd742"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d146a7b4-4b69-4fb3-be78-3674d55e71e4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d15aeb15-4fe7-482a-95af-e91a82bdc00b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d1796de4-8593-4d40-8d7d-43adf850a4f0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d1947401-5bc5-4b65-aec7-19ea14ae5e51"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2065220-75af-4845-9791-32e4be92be91"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d245b91f-ff0c-42e8-b230-17f49b4409bc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2dfc1fd-77fd-44f4-b491-3b5fab8e7d44"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d32540d9-f9f6-433e-9c9d-1fe95554685c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d32f6163-c6ef-44cf-886c-4816f1db448c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d361218d-8a92-4563-afaa-bd6e40b912ad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3c6bc2e-1c39-42cf-8966-e363503b0231"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3cbf915-97e1-46ad-8f67-5c613db507a9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3d0096b-a91a-49aa-a9e5-aa2638259e30"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3df7aaa-4ad5-463b-bfe3-6eb530398c96"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3e0abd1-6726-4416-ad2a-fb10efaf6924"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3f01f38-f9cb-4442-9767-e19f18e0ffd9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d5a2ed18-5141-42b3-9aba-624c53696209"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d5b7c414-05a5-417b-beda-3a8755e642b2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d62d0c01-2474-42ee-b5be-13fc91d483e4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d63977a9-4386-49dd-891d-027e9e60eef7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d64f01dd-e28b-4a06-bdbc-1af7fe3fca31"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6ab13d6-4ceb-4a15-a40d-c263ef4488ea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d74eb95f-12b0-4870-8dc2-d5eb97a4932c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d77d5336-6bbd-47b9-aaac-56613bfb27e2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d7a5a89d-cf10-485b-8543-3375330fb317"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d7b643e8-2920-4b0a-88a9-b8d7382bc1ae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d8204698-885f-4bdd-a92d-fc17321325f7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d86cb651-35c0-4cad-b03f-e46fa1fd5662"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d8c49522-ded8-4f1c-ac68-b3acf30d3eac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d8c74eef-0d1e-46ac-b955-3b58d0192a35"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d90e49a7-ec22-41a2-bf1d-60ac4b0753cc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d92eb038-fa49-432b-b770-4cc71abbd6b3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d93b968b-3d08-489e-abbb-437e8fa9b9c4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("da36c4e7-8ea8-4406-bc61-53ac5841530d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("daab65d7-f2b9-43ec-ab08-fed2e998f9ff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("db1363dd-01d0-4d1d-9a07-13945bb61e2e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("db279430-a7ba-4827-bbc5-921d7c5a3c0a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("db3b00b1-a3a6-401b-861e-c977b726a94e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("db3df953-5e18-472d-a744-3618077c8af2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("db4a805a-8edb-4b0a-907d-bf22b82ae76b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dba9c07d-768e-4176-80ca-127d2b51dbb8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dbdb1e72-66a8-44fa-974e-0cd0d5f0228c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dbf4ecd1-7e07-45d9-88d0-a7175d7d8241"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dc46ed81-1d13-4ffc-981a-f1bddbb22954"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dc4dbad8-c326-4d6c-b1a4-6da60aba19f1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dc6282e9-2733-4d1d-8adb-1c85c89966ea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dca27272-846c-4178-b433-1228be169833"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dcd713a6-5a1e-479c-8ecd-6389d9e11148"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dcebde61-924e-4661-8cbe-7c9f2e1eb751"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dd50cd87-88bd-4af9-9117-9b03ce36e8dc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dd8b41d3-c98e-469c-b761-f885dd1415b6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ddb7ea46-2cdf-429e-beb9-bb76730d6824"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("de71b85e-8496-4804-be3e-c0af3cb28ed3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("de97289f-62b0-417e-9e4f-92ec605ea4e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("deb801ea-d62a-44d1-971b-a8a8fdd005da"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("df5eced4-0adb-4b1d-aada-56ef1483670a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e000a517-5b80-4b38-83ae-d2af9b159fc7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e01d774f-87bb-4620-aba8-ec2806876be9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e02cc6a3-2c67-4041-9551-c295f62ea29e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e06349a8-6448-4202-a9d6-ee9eeef3c071"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e0afe803-9189-44f1-aa60-f43ab733af86"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e0c7dd93-19ba-4958-8eb7-c95e9c0e7bfc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e0c9fd19-d843-4f7b-9f4e-f0a7e6419c98"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e0e9900f-6f5a-4dd5-bfea-6d34a31f3284"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e0f34066-712a-4694-8f2a-d06741a3c307"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e121fa94-81a5-41bb-8a5e-f129e218ee0f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e132431f-6534-4b65-80a9-f5c78e0711ea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e1b7e303-c4cf-4491-8544-2817b901cda2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e1b8ad15-8294-428a-bc8b-53b564bbc722"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e1c3466d-2356-4201-9099-33a99d0ba182"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e2dd8ddb-9f9e-460e-8d2b-9bb28473d5b1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e321a9de-25f6-4631-b605-6398026b578d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e382ed88-39ed-43cd-b644-4fe09d46c28a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e3981273-0a54-48d3-90f4-4090632e4fa6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e457fab4-7cf9-4a67-81a7-60497f7631d2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e4fa113d-02cf-472a-9df9-a79dc86eeb3e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e51ce9a8-e860-4b6d-86a5-572e9e28a0c6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e5876669-665f-42f5-9901-d7730a585553"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e60d1915-b8d5-4b8c-9d7b-9d51e5f0304a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e65f98c1-de84-42a2-9a0e-f0044d84a5c3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e6dd7432-f066-4917-991f-76e3201bbbcd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e6f6c023-d10b-4cc6-a900-42e46b32555a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e7248be3-edfe-485a-b1b4-f7dcb23c99d5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e73610f7-6c79-425a-bf5e-0a68caf72268"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e76e59c2-1067-401a-972d-88aa29b475f3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e789c652-e883-457c-a793-8e5b1c7eeba2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e7dda129-b5b5-4110-b4b9-61a90e347081"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e7e28e74-754d-469b-bd87-8ba6d470df98"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e806cf5e-b8e7-4c0a-a32c-a1a34e4a2146"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e81af116-963a-44c6-8a45-b07822a3e74c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e88ed8f6-b5d7-461d-99f4-c41b8713b327"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e8ad32a7-b7df-4dfa-8521-b4fc06f983dc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e8c51555-4f04-495e-bd1c-5442be56eea0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e94747f3-9d03-4dfe-b29f-748ce37a358e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e97949c2-829d-484c-b739-1d7dfeb52146"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e97b170a-505f-4624-b1e7-c65d8d9ef5a8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e9b3cb73-5adf-4859-bf69-624a9d65d1e8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e9d62447-8395-492a-be56-c14d9c137b77"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ea6ccbbd-c23e-49e4-8bce-f920d9e06eab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eaf0bd38-d017-4808-9a6e-6448a87d8624"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eb0c7d89-3f68-4d32-95c3-318b7214ade5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eb4ce3c5-f2ba-40d3-9421-d55c37c770d1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eba74022-235f-46f3-9d6f-34957956dda2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ec0434e4-40e5-4e86-a87c-4108d3eda401"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ec3c051a-1f55-40a5-b1fa-62f87b2db365"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ec8ebf96-8e99-42fb-bb8e-ef243429690b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ecb2df2e-326a-4cca-bb7a-0dcf99710a7a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ecb71a66-7769-4cc2-953c-36a9a0ae2d28"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ecbec9d4-d27f-4ff7-b651-77baf50f4bac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ecf33fb0-41ab-44e6-9c1b-5ce067d269ad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ed198145-8ed4-4378-ba21-c16406ec3dcf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ed7f655f-b239-4c7f-84da-aab33bb91e1c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("edfc730c-c29b-4fdc-8182-63061cf08b13"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ee29947f-bbe2-453a-ab7d-36a41995308a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ee2ad184-7493-4445-bb19-70de66642728"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ee5a2bba-b1aa-49a8-949d-0eb6af560bfb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ee6c4c37-6155-4073-afe3-2adbe11d5df3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ee9a2a6b-c50c-4ad0-a619-7aab4ee0aebf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eece48fd-ea72-4156-bdb1-8ed6e08966d9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eefda5e2-4ace-45eb-ab93-aa1ea3797c0e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ef05e309-3bf5-4471-9729-7a7c6ce41021"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ef1b16f4-ba75-48e4-bf65-7c55c4f6eed5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ef2969f2-3ba8-4c32-80f0-4b9a54f528c0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ef4084a2-8b45-499b-b627-865ccb8c0ef5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ef8b015f-5b17-42f9-8405-73b527ee7e50"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ef9ed929-6756-4b80-8a5a-a2d9a6c5ba55"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("efa2ca29-bb5e-4297-b23f-40df03e8ad93"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("efb321fd-6e6f-47f5-8ceb-296a5c913513"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("efd3c314-7ce6-44c2-8d1f-08d63f280e76"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("efddef39-b726-4344-8ee3-66e21adad56a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f01e6820-7d87-44d2-a469-21ef0862df6b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f07266c5-a332-4a0a-9350-5713aa8725b2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f0768c1b-bb33-4f71-8611-a82faa23475d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f1641166-b55e-46d3-9eeb-05896bb386e2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f16796d3-5bfd-409e-8eee-ac87747cd3bf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f1a8229f-c217-4ebf-ac01-89c32ff61704"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f1ae3349-3e85-47c4-9204-97576baea220"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f1c253fa-8eaf-4825-849c-98c92affd142"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f226a11c-d8ce-4c9b-b7fa-0f1e59cc7d13"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f22a113f-92af-4aa5-921b-3826d940f550"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f22b4c4c-23c7-4433-aed4-21422ce1a9e4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f293b6aa-3764-4370-a559-df5d5e2e993e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f2bea811-b670-446c-a880-c2eedca62149"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f2cd22ae-b25c-4808-9934-ba7a4d9e9e0d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f31472ab-6267-4560-a1c8-9054d36b3d17"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f319c499-15d1-4cac-9d21-056a99001e2d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f339f129-a875-4f9b-a0d0-13ad85e8337a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f45d7c73-7fd1-4a99-81d1-d7573b153d26"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f4607728-93d7-47ac-98c7-eafad78365e9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f4ac8a50-7539-42d3-a7cd-cac98c2b194a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f4ac9eea-3b8c-471b-a5c3-360d27964f2b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f4e32d5c-a5fa-4599-82d3-5aa335c5389e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f4f97d16-018c-4a6f-a4e1-0f461e675646"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f58cb1ff-e7dd-422d-8fa0-f62bb8088a76"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5dd6b40-8c32-4407-8f01-774b9d35c168"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f663eb97-9e89-46fc-a500-41717c577a8d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f6841af5-9533-44a1-9f39-a471c54b18cc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f6cd448e-71ba-4a60-bfed-4f8e614cc8f2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f6de2b74-5480-43a9-8113-f5a1374a0625"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f6f19356-98a8-4ca4-9fe6-63bf4be419ff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f6ffcb24-bb8f-4adc-817f-190e11890aed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f775b443-a6fa-49ac-be3b-da6eb654b8f4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f7b02d52-5b8d-4ed2-8a04-b9ae871ec507"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f7ee2ef4-d780-4649-97d0-1848df6b61d0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f8499a4c-7f3a-4434-b9c7-864512b7d0b4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f84f635b-2ad3-49c4-b3e8-7332be511397"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f851307c-8561-4c13-a2fc-68f7bcd00f9b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f89f995c-2133-450c-afc9-d2a4c22da2e6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f93c553f-f2d8-4d25-9185-8ef96b2198ba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f9434d46-2c61-4356-a639-bd898f611e2d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f95054be-6269-4481-a02b-12865f7350a0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f967850f-2a82-4d23-a49d-1017854262f9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f99414d9-3958-4e64-ac0f-c387aeb387a8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f9a67a36-29fc-4e80-9ff2-6d550484ff05"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f9b87050-f749-4e18-ae18-c65225b69736"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f9c6da9c-96a0-487b-93c6-d56d58aa1b02"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f9cc1039-c394-4363-ac57-a933b75c1386"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f9ee32d2-ecbf-4d5e-9d42-8fad5ea5410f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fa2b8248-f120-4d63-9ce3-60d5eed3e98e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fa78f5f8-1ee4-4cf0-b8bf-f21bae26008f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fa8091e1-8217-4473-b511-22f09f19b6bd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fb0b113a-127c-4c09-bdff-121dbb59f727"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fb4645e3-450e-4740-bdec-2c16eadba39d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fb894d92-0f13-4a14-9711-d8d55dee2926"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fbc3020b-39ba-4490-8210-00221923ded4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fc0e45b1-755c-4494-88ad-1f06da8842dc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fc381950-3e87-43fb-abb0-a5611fbe70eb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fc3972d8-c5c5-4abe-a3d3-009da69d2487"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fc6686fb-1286-4886-99df-b293ddd47d6c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fc689e1d-acb2-4420-b9a8-c2d24d82a021"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fc899b10-b38a-46e7-ae2b-050604293da6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fc8a80a4-4ec1-4e40-a5c6-e80bb6f8eade"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fc958373-faf9-4c83-adeb-dc87a4773b2a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fc9f3d94-79e3-485e-96a4-4946120846f6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fca7f595-b2f7-4c2c-a77e-7990b66964a9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fcd01285-818d-4ed0-899e-acad02ee2f38"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fce5d467-0ea5-434f-86af-57ab33cd1cf1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fd01f4ca-1c47-452a-96e7-dfdfc6ee51b2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fd0e86b9-ebcb-463e-849b-b61cc2775285"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe008001-ec66-4f4e-9653-e9fe27758cf1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe091a34-333d-4021-85a7-6a828b6d57de"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe4f7376-053c-401a-b4ba-0d7417b42b63"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe83c18a-92cf-4d25-a30a-9ad9b725ebbc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ff089577-6b6c-4400-a41b-33d18bd6b3ab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ff12156a-424a-4243-b37d-749926b9c7f3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ff8903d2-2c3d-46c6-8c2c-ba192acc4749"));

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "id", "ProductPrice" },
                values: new object[] { new Guid("4e9f1871-aacb-4934-a94a-21ad576e11cc"), 12.22m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Code", "Color", "DateChanges", "Model", "Name", "PriceId", "Quantity", "Size", "Sort", "Weight" },
                values: new object[] { new Guid("9a1cb0f8-19c9-4d43-a8d7-5590346ca3f2"), "PC-1-CC", 0, "Red", new DateTime(2022, 3, 21, 13, 24, 8, 517, DateTimeKind.Local).AddTicks(5365), "Sugar", "Coca-cola", new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"), 1m, "1 1", "Drink", "1" });
        }
    }
}
