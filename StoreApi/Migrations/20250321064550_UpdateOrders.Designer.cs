﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoreApi.Data;

#nullable disable

namespace StoreApi.Migrations
{
    [DbContext(typeof(SqliteDbContext))]
    [Migration("20250321064550_UpdateOrders")]
    partial class UpdateOrders
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.3");

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.Property<int>("CategoriesCategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductsProductId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CategoriesCategoryId", "ProductsProductId");

                    b.HasIndex("ProductsProductId");

                    b.ToTable("CategoryProduct");
                });

            modelBuilder.Entity("StoreApi.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Kingsong",
                            Description = "Kingsong"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "LeaperKim",
                            Description = "LeaperKim"
                        });
                });

            modelBuilder.Entity("StoreApi.Entities.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CustomerAddress1")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerAddress2")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            CustomerAddress1 = "HowardStreet",
                            CustomerAddress2 = "233 44 NEW YORK",
                            CustomerName = "Peter Parker",
                            Email = "peter@howard.com"
                        },
                        new
                        {
                            CustomerId = 2,
                            CustomerAddress1 = "AiStreet",
                            CustomerAddress2 = "111 44 NEW YORK",
                            CustomerName = "RoboCop",
                            Email = "RoboCop@howard.com"
                        },
                        new
                        {
                            CustomerId = 3,
                            CustomerAddress1 = "Saxbergen",
                            CustomerAddress2 = "121 44 SWEDEN",
                            CustomerName = "John Saxberg",
                            Email = "John@Saxberg.com"
                        });
                });

            modelBuilder.Entity("StoreApi.Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address1")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address2")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("TotalAmount")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("TEXT");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("StoreApi.Entities.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("StoreApi.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BatteryCapacity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Brand")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("HasSuspension")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<int?>("MaxRange")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MaxSpeed")
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("StockQuantity")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TireSize")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Weight")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Brand = "Kingsong",
                            Description = "Kingsong 16X is the flagship model thanks to its powerful motor and high capacity battery. 45km/h top speed is achievable due to a 2kW motor and 1554Wh battery. Large battery gives a maximum range of 150km in ideal conditions – in practice, a rider weighing 80kg and going at moderate/high speed will get around 100+km of range. Its 16-inch wheel also houses a wider tire for extra stability while riding at high speeds which makes it one of the easiest electric unicycles to ride on. A 16-inch wheel is easy to maneuver but also absorbs bumps in the road for a smooth ride. The 16X has an extendable handle for easy transport when not in use. It connects to the KS app over Bluetooth, allowing the user to adjust ride softness, LED lights, and warning signals. Additionally, it is equipped with Bluetooth speakers for music.",
                            ProductName = "16X"
                        },
                        new
                        {
                            ProductId = 2,
                            Brand = "Kingsong",
                            Description = "The Kingsong 16S is designed for riders who need a practical and comfortable wheel for city commuting or light off-road riding. With a top speed of 35km/h, it is ideal for riders who prefer a balance between speed and control. The 75km range makes it a reliable companion for daily activities, though actual distance depends on rider weight and riding style. The 16-inch wheel provides a smooth and stable ride, making it more comfortable than smaller models. The 16S connects to the Kingsong app via Bluetooth for ride adjustments, LED customization, and warning signals. It also features built-in Bluetooth speakers.",
                            ProductName = "16S"
                        },
                        new
                        {
                            ProductId = 3,
                            Brand = "Kingsong",
                            Description = "Kingsong 14M and 14S share the same design, differing mainly in battery size and motor power. The 14M is the lightest option, while the 14S offers a longer range. Their lightweight construction makes them easy to carry, ideal for those who frequently navigate stairs or need a portable solution. The 14-inch wheel is maneuverable and suitable for smaller riders. Both models are available in white and black colors.",
                            ProductName = "14M and 14S"
                        },
                        new
                        {
                            ProductId = 4,
                            Brand = "Kingsong",
                            Description = "The Kingsong S22 Eagle is a 20\" suspension wheel with significant upgrades. It features a 20\" wheel with a 3\" tire, a range up to 200km, a peak motor of 7500W, a 2220Wh battery, fast charging, and advanced suspension. It's designed for various terrains with adjustable compression and damping.",
                            ProductName = "S22 Eagle"
                        },
                        new
                        {
                            ProductId = 5,
                            Brand = "Kingsong",
                            Description = "The Kingsong S18 is an 18\" unicycle with a visible shock absorber. It features a 200 x 57 mm shock, a handle for easy carrying, automatic front light, softening pads, rear turn and brake lights, 21700 battery cells, and app connectivity for ride customization. It's designed for both city and off-road riding.",
                            ProductName = "S18"
                        },
                        new
                        {
                            ProductId = 6,
                            Brand = "Kingsong",
                            Description = "The Kingsong 18L is a reliable 18\" unicycle with a maximum speed of 50 km/h and a range of approximately 105km. It features an 18\" wheel, app connectivity for ride control and system data, and a built-in handle for easy transport.",
                            ProductName = "18L"
                        },
                        new
                        {
                            ProductId = 7,
                            Brand = "Kingsong",
                            Description = "The Kingsong 18XL is a reliable 18\" unicycle with a maximum speed of 50 km/h and a range of approximately 150km. It features an 18\" wheel, app connectivity for ride control and system data, and a built-in handle for easy transport.",
                            ProductName = "18XL"
                        },
                        new
                        {
                            ProductId = 8,
                            Brand = "LeaperKim",
                            Description = "An agile and responsive top-of-the-line 20\" off-road suspension wheel. Available in 3 versions: 70LBS, 66LBS, 62 LBS. Battery: 2700W (Samsung 21700 50S), Motor: 3200W (8000W peak), Weight: 40kg, 20\" knobby tubeless tire, Fast charging up to 15A (1.5h), Progressive suspension.",
                            ProductName = "Veteran Lynx"
                        },
                        new
                        {
                            ProductId = 9,
                            Brand = "LeaperKim",
                            Description = "A powerful and agile 16\" (realistically 18\") off-road wheel. Built tough for off-roading. 3000W motor (7000W peak), 16\" knobby tubeless tire, 2,220Wh Samsung 50E or 50S battery, Fastace fork suspension with 80mm travel, Weight: 39kg.",
                            ProductName = "Veteran Patton"
                        },
                        new
                        {
                            ProductId = 10,
                            Brand = "LeaperKim",
                            Description = "Veteran’s first suspension wheel with a massive 3,600Wh battery pack, 3,000W high-torque motor (7KW peak), New generation controller (24x MOSFETs, 680A peak load), Adjustable suspension with up to 90mm travel, 20\" knobby tire, Integrated seat & fender.",
                            ProductName = "Veteran Sherman-S"
                        },
                        new
                        {
                            ProductId = 11,
                            Brand = "LeaperKim",
                            Description = "Performance-focused wheel with a new 3600Wh battery, 2800W motor with 20% more torque, Thicker motor phase wires, Re-designed pedal bracket. No Bluetooth speakers, but 230km of range.",
                            ProductName = "Veteran Sherman Max"
                        },
                        new
                        {
                            ProductId = 12,
                            Brand = "LeaperKim",
                            Description = "A long-range cruising wheel with a 3500W motor, 22\" knobby tubeless tire, 2,700Wh Samsung 21700 50E battery, IP65 water resistance. Originally designed for seated riding and long-range trips.",
                            ProductName = "Veteran Abrams"
                        });
                });

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.HasOne("StoreApi.Entities.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StoreApi.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StoreApi.Entities.OrderDetail", b =>
                {
                    b.HasOne("StoreApi.Entities.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StoreApi.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("StoreApi.Entities.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
