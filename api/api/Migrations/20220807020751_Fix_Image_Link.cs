using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    public partial class Fix_Image_Link : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("82c819c6-c692-4b25-9e72-7738923fdbd7"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("a34710eb-d845-4a4a-952e-61b7221517d4"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("e838a336-7c52-4bda-bb2e-530b9970fcdc"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("f9eabae4-bd05-4244-8fb8-8e62b089e471"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("a0ee1368-ce5f-4fca-808d-4ec4d734dc50"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("aea1e362-3574-4476-8b2a-8040889ce8ef"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("b41afb9d-6975-4597-86ee-ba22c42b4eae"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("0d6c4474-b2e1-48d4-867b-ced346c70734"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("61742284-c67f-4eaf-8504-7e405be41218"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("74d034db-106e-476b-9d27-c8fe563456b3"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("752dcf3f-b3ca-4ea2-8236-bc11777b2688"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("7a8db558-9993-4b68-b879-0c355cb64db3"));

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Discriminator", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("3e3ba95d-cc2a-4ef3-9d58-46570b156ab3"), "Beverage", "http://localhost:4200/assets/beverage2.jpg", "柳橙汁", 25 },
                    { new Guid("4248c77e-1972-4993-b62a-452951194e5d"), "Beverage", "http://localhost:4200/assets/beverage4.jpg", "可口可樂", 30 },
                    { new Guid("5ce06a82-1884-451c-aa83-7cf767536675"), "Beverage", "http://localhost:4200/assets/beverage3.jpg", "雪碧", 30 },
                    { new Guid("9ab6afc7-9bf1-4166-88b1-4bbfdfd0bfaf"), "Beverage", "http://localhost:4200/assets/beverage1.jpg", "蘋果汁", 25 },
                    { new Guid("415be981-1220-4740-a060-13898b1cbe14"), "Dessert", "http://localhost:4200/assets/dessert3.jpg", "巧克力冰淇淋", 30 },
                    { new Guid("49c1f5cd-4732-42eb-a8f2-0fadd19047ca"), "Dessert", "http://localhost:4200/assets/dessert2.jpg", "蛋塔", 25 },
                    { new Guid("f7e6f462-23a7-4511-9aac-d76d356abeee"), "Dessert", "http://localhost:4200/assets/dessert1.jpg", "巧克力蛋糕", 30 },
                    { new Guid("007e5e80-699f-4891-8566-0750b9eabbf6"), "MainDish", "http://localhost:4200/assets/main3.jpg", "火腿蛋漢堡", 70 },
                    { new Guid("1f8d8e1e-237c-43e8-9ea7-b65aa0a2b32a"), "MainDish", "http://localhost:4200/assets/main5.jpg", "美式炸雞", 85 },
                    { new Guid("59ac7a0e-b9fe-41be-a6be-24b0a1e1cbac"), "MainDish", "http://localhost:4200/assets/main2.jpg", "海洋珍珠堡", 75 },
                    { new Guid("5d4fbf50-e36d-4631-8d51-e2f9fa7c8143"), "MainDish", "http://localhost:4200/assets/main1.jpg", "鱈魚堡", 65 },
                    { new Guid("c7af707d-0e4b-4b71-806d-2da4aa8f2cf3"), "MainDish", "http://localhost:4200/assets/main4.jpg", "燒肉堡", 80 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("3e3ba95d-cc2a-4ef3-9d58-46570b156ab3"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("4248c77e-1972-4993-b62a-452951194e5d"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("5ce06a82-1884-451c-aa83-7cf767536675"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("9ab6afc7-9bf1-4166-88b1-4bbfdfd0bfaf"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("415be981-1220-4740-a060-13898b1cbe14"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("49c1f5cd-4732-42eb-a8f2-0fadd19047ca"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("f7e6f462-23a7-4511-9aac-d76d356abeee"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("007e5e80-699f-4891-8566-0750b9eabbf6"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("1f8d8e1e-237c-43e8-9ea7-b65aa0a2b32a"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("59ac7a0e-b9fe-41be-a6be-24b0a1e1cbac"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("5d4fbf50-e36d-4631-8d51-e2f9fa7c8143"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("c7af707d-0e4b-4b71-806d-2da4aa8f2cf3"));

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Discriminator", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("82c819c6-c692-4b25-9e72-7738923fdbd7"), "Beverage", "/assets/beverage4.jpg", "可口可樂", 30 },
                    { new Guid("a34710eb-d845-4a4a-952e-61b7221517d4"), "Beverage", "/assets/beverage2.jpg", "柳橙汁", 25 },
                    { new Guid("e838a336-7c52-4bda-bb2e-530b9970fcdc"), "Beverage", "/assets/beverage3.jpg", "雪碧", 30 },
                    { new Guid("f9eabae4-bd05-4244-8fb8-8e62b089e471"), "Beverage", "/assets/beverage1.jpg", "蘋果汁", 25 },
                    { new Guid("a0ee1368-ce5f-4fca-808d-4ec4d734dc50"), "Dessert", "/assets/dessert1.jpg", "巧克力蛋糕", 30 },
                    { new Guid("aea1e362-3574-4476-8b2a-8040889ce8ef"), "Dessert", "/assets/dessert2.jpg", "蛋塔", 25 },
                    { new Guid("b41afb9d-6975-4597-86ee-ba22c42b4eae"), "Dessert", "/assets/dessert3.jpg", "巧克力冰淇淋", 30 },
                    { new Guid("0d6c4474-b2e1-48d4-867b-ced346c70734"), "MainDish", "/assets/main4.jpg", "燒肉堡", 80 },
                    { new Guid("61742284-c67f-4eaf-8504-7e405be41218"), "MainDish", "/assets/main3.jpg", "火腿蛋漢堡", 70 },
                    { new Guid("74d034db-106e-476b-9d27-c8fe563456b3"), "MainDish", "/assets/main5.jpg", "美式炸雞", 85 },
                    { new Guid("752dcf3f-b3ca-4ea2-8236-bc11777b2688"), "MainDish", "/assets/main2.jpg", "海洋珍珠堡", 75 },
                    { new Guid("7a8db558-9993-4b68-b879-0c355cb64db3"), "MainDish", "/assets/main1.jpg", "鱈魚堡", 65 }
                });
        }
    }
}
