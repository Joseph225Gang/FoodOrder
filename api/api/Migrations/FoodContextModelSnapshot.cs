﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api.Context;

#nullable disable

namespace api.Migrations
{
    [DbContext(typeof(FoodContext))]
    partial class FoodContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("api.Model.Food", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Foods");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Food");
                });

            modelBuilder.Entity("api.Model.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleName")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("api.Model.Beverage", b =>
                {
                    b.HasBaseType("api.Model.Food");

                    b.HasDiscriminator().HasValue("Beverage");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4248c77e-1972-4993-b62a-452951194e5d"),
                            ImageUrl = "http://localhost:4200/assets/beverage4.jpg",
                            Name = "可口可樂",
                            Price = 30
                        },
                        new
                        {
                            Id = new Guid("5ce06a82-1884-451c-aa83-7cf767536675"),
                            ImageUrl = "http://localhost:4200/assets/beverage3.jpg",
                            Name = "雪碧",
                            Price = 30
                        },
                        new
                        {
                            Id = new Guid("9ab6afc7-9bf1-4166-88b1-4bbfdfd0bfaf"),
                            ImageUrl = "http://localhost:4200/assets/beverage1.jpg",
                            Name = "蘋果汁",
                            Price = 25
                        },
                        new
                        {
                            Id = new Guid("3e3ba95d-cc2a-4ef3-9d58-46570b156ab3"),
                            ImageUrl = "http://localhost:4200/assets/beverage2.jpg",
                            Name = "柳橙汁",
                            Price = 25
                        });
                });

            modelBuilder.Entity("api.Model.Dessert", b =>
                {
                    b.HasBaseType("api.Model.Food");

                    b.HasDiscriminator().HasValue("Dessert");

                    b.HasData(
                        new
                        {
                            Id = new Guid("415be981-1220-4740-a060-13898b1cbe14"),
                            ImageUrl = "http://localhost:4200/assets/dessert3.jpg",
                            Name = "巧克力冰淇淋",
                            Price = 30
                        },
                        new
                        {
                            Id = new Guid("f7e6f462-23a7-4511-9aac-d76d356abeee"),
                            ImageUrl = "http://localhost:4200/assets/dessert1.jpg",
                            Name = "巧克力蛋糕",
                            Price = 30
                        },
                        new
                        {
                            Id = new Guid("49c1f5cd-4732-42eb-a8f2-0fadd19047ca"),
                            ImageUrl = "http://localhost:4200/assets/dessert2.jpg",
                            Name = "蛋塔",
                            Price = 25
                        });
                });

            modelBuilder.Entity("api.Model.MainDish", b =>
                {
                    b.HasBaseType("api.Model.Food");

                    b.HasDiscriminator().HasValue("MainDish");

                    b.HasData(
                        new
                        {
                            Id = new Guid("007e5e80-699f-4891-8566-0750b9eabbf6"),
                            ImageUrl = "http://localhost:4200/assets/main3.jpg",
                            Name = "火腿蛋漢堡",
                            Price = 70
                        },
                        new
                        {
                            Id = new Guid("5d4fbf50-e36d-4631-8d51-e2f9fa7c8143"),
                            ImageUrl = "http://localhost:4200/assets/main1.jpg",
                            Name = "鱈魚堡",
                            Price = 65
                        },
                        new
                        {
                            Id = new Guid("59ac7a0e-b9fe-41be-a6be-24b0a1e1cbac"),
                            ImageUrl = "http://localhost:4200/assets/main2.jpg",
                            Name = "海洋珍珠堡",
                            Price = 75
                        },
                        new
                        {
                            Id = new Guid("c7af707d-0e4b-4b71-806d-2da4aa8f2cf3"),
                            ImageUrl = "http://localhost:4200/assets/main4.jpg",
                            Name = "燒肉堡",
                            Price = 80
                        },
                        new
                        {
                            Id = new Guid("1f8d8e1e-237c-43e8-9ea7-b65aa0a2b32a"),
                            ImageUrl = "http://localhost:4200/assets/main5.jpg",
                            Name = "美式炸雞",
                            Price = 85
                        });
                });
#pragma warning restore 612, 618
        }
    }
}