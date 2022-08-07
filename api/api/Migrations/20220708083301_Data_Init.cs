using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    public partial class Data_Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleName = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
