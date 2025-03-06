using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StoreApi.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    CustomerAddress1 = table.Column<string>(type: "TEXT", nullable: true),
                    CustomerAddress2 = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CustomerName = table.Column<string>(type: "TEXT", nullable: false),
                    CustomerEmail = table.Column<string>(type: "TEXT", nullable: true),
                    CustomerAddress1 = table.Column<string>(type: "TEXT", nullable: true),
                    CustomerAddress2 = table.Column<string>(type: "TEXT", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductName = table.Column<string>(type: "TEXT", nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    StockQuantity = table.Column<int>(type: "INTEGER", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    CategoriesCategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductsProductId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => new { x.CategoriesCategoryId, x.ProductsProductId });
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Categories_CategoriesCategoryId",
                        column: x => x.CategoriesCategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Products_ProductsProductId",
                        column: x => x.ProductsProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Kingsong", "Kingsong" },
                    { 2, "LeaperKim", "LeaperKim" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "CustomerAddress1", "CustomerAddress2", "CustomerName", "Email" },
                values: new object[,]
                {
                    { 1, "HowardStreet", "233 44 NEW YORK", "Peter Parker", "peter@howard.com" },
                    { 2, "AiStreet", "111 44 NEW YORK", "RoboCop", "RoboCop@howard.com" },
                    { 3, "Saxbergen", "121 44 SWEDEN", "John Saxberg", "John@Saxberg.com" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Brand", "Description", "ImageUrl", "Price", "ProductName", "StockQuantity" },
                values: new object[,]
                {
                    { 1, "Kingsong", "Kingsong 16X is the flagship model thanks to its powerful motor and high capacity battery. 45km/h top speed is achievable due to a 2kW motor and 1554Wh battery. Large battery gives a maximum range of 150km in ideal conditions – in practice, a rider weighing 80kg and going at moderate/high speed will get around 100+km of range. Its 16-inch wheel also houses a wider tire for extra stability while riding at high speeds which makes it one of the easiest electric unicycles to ride on. A 16-inch wheel is easy to maneuver but also absorbs bumps in the road for a smooth ride. The 16X has an extendable handle for easy transport when not in use. It connects to the KS app over Bluetooth, allowing the user to adjust ride softness, LED lights, and warning signals. Additionally, it is equipped with Bluetooth speakers for music.", null, null, "16X", null },
                    { 2, "Kingsong", "The Kingsong 16S is designed for riders who need a practical and comfortable wheel for city commuting or light off-road riding. With a top speed of 35km/h, it is ideal for riders who prefer a balance between speed and control. The 75km range makes it a reliable companion for daily activities, though actual distance depends on rider weight and riding style. The 16-inch wheel provides a smooth and stable ride, making it more comfortable than smaller models. The 16S connects to the Kingsong app via Bluetooth for ride adjustments, LED customization, and warning signals. It also features built-in Bluetooth speakers.", null, null, "16S", null },
                    { 3, "Kingsong", "Kingsong 14M and 14S share the same design, differing mainly in battery size and motor power. The 14M is the lightest option, while the 14S offers a longer range. Their lightweight construction makes them easy to carry, ideal for those who frequently navigate stairs or need a portable solution. The 14-inch wheel is maneuverable and suitable for smaller riders. Both models are available in white and black colors.", null, null, "14M and 14S", null },
                    { 4, "Kingsong", "The Kingsong S22 Eagle is a 20\" suspension wheel with significant upgrades. It features a 20\" wheel with a 3\" tire, a range up to 200km, a peak motor of 7500W, a 2220Wh battery, fast charging, and advanced suspension. It's designed for various terrains with adjustable compression and damping.", null, null, "S22 Eagle", null },
                    { 5, "Kingsong", "The Kingsong S18 is an 18\" unicycle with a visible shock absorber. It features a 200 x 57 mm shock, a handle for easy carrying, automatic front light, softening pads, rear turn and brake lights, 21700 battery cells, and app connectivity for ride customization. It's designed for both city and off-road riding.", null, null, "S18", null },
                    { 6, "Kingsong", "The Kingsong 18L is a reliable 18\" unicycle with a maximum speed of 50 km/h and a range of approximately 105km. It features an 18\" wheel, app connectivity for ride control and system data, and a built-in handle for easy transport.", null, null, "18L", null },
                    { 7, "Kingsong", "The Kingsong 18XL is a reliable 18\" unicycle with a maximum speed of 50 km/h and a range of approximately 150km. It features an 18\" wheel, app connectivity for ride control and system data, and a built-in handle for easy transport.", null, null, "18XL", null },
                    { 8, "LeaperKim", "An agile and responsive top-of-the-line 20\" off-road suspension wheel. Available in 3 versions: 70LBS, 66LBS, 62 LBS. Battery: 2700W (Samsung 21700 50S), Motor: 3200W (8000W peak), Weight: 40kg, 20\" knobby tubeless tire, Fast charging up to 15A (1.5h), Progressive suspension.", null, null, "Veteran Lynx", null },
                    { 9, "LeaperKim", "A powerful and agile 16\" (realistically 18\") off-road wheel. Built tough for off-roading. 3000W motor (7000W peak), 16\" knobby tubeless tire, 2,220Wh Samsung 50E or 50S battery, Fastace fork suspension with 80mm travel, Weight: 39kg.", null, null, "Veteran Patton", null },
                    { 10, "LeaperKim", "Veteran’s first suspension wheel with a massive 3,600Wh battery pack, 3,000W high-torque motor (7KW peak), New generation controller (24x MOSFETs, 680A peak load), Adjustable suspension with up to 90mm travel, 20\" knobby tire, Integrated seat & fender.", null, null, "Veteran Sherman-S", null },
                    { 11, "LeaperKim", "Performance-focused wheel with a new 3600Wh battery, 2800W motor with 20% more torque, Thicker motor phase wires, Re-designed pedal bracket. No Bluetooth speakers, but 230km of range.", null, null, "Veteran Sherman Max", null },
                    { 12, "LeaperKim", "A long-range cruising wheel with a 3500W motor, 22\" knobby tubeless tire, 2,700Wh Samsung 21700 50E battery, IP65 water resistance. Originally designed for seated riding and long-range trips.", null, null, "Veteran Abrams", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_ProductsProductId",
                table: "CategoryProduct",
                column: "ProductsProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
