using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BatteryCapacity",
                table: "Products",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasSuspension",
                table: "Products",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaxRange",
                table: "Products",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaxSpeed",
                table: "Products",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TireSize",
                table: "Products",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "Products",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "BatteryCapacity", "HasSuspension", "MaxRange", "MaxSpeed", "TireSize", "Weight" },
                values: new object[] { null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "BatteryCapacity", "HasSuspension", "MaxRange", "MaxSpeed", "TireSize", "Weight" },
                values: new object[] { null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "BatteryCapacity", "HasSuspension", "MaxRange", "MaxSpeed", "TireSize", "Weight" },
                values: new object[] { null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "BatteryCapacity", "HasSuspension", "MaxRange", "MaxSpeed", "TireSize", "Weight" },
                values: new object[] { null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "BatteryCapacity", "HasSuspension", "MaxRange", "MaxSpeed", "TireSize", "Weight" },
                values: new object[] { null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "BatteryCapacity", "HasSuspension", "MaxRange", "MaxSpeed", "TireSize", "Weight" },
                values: new object[] { null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "BatteryCapacity", "HasSuspension", "MaxRange", "MaxSpeed", "TireSize", "Weight" },
                values: new object[] { null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "BatteryCapacity", "HasSuspension", "MaxRange", "MaxSpeed", "TireSize", "Weight" },
                values: new object[] { null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "BatteryCapacity", "HasSuspension", "MaxRange", "MaxSpeed", "TireSize", "Weight" },
                values: new object[] { null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "BatteryCapacity", "HasSuspension", "MaxRange", "MaxSpeed", "TireSize", "Weight" },
                values: new object[] { null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "BatteryCapacity", "HasSuspension", "MaxRange", "MaxSpeed", "TireSize", "Weight" },
                values: new object[] { null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "BatteryCapacity", "HasSuspension", "MaxRange", "MaxSpeed", "TireSize", "Weight" },
                values: new object[] { null, null, null, null, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BatteryCapacity",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "HasSuspension",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "MaxRange",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "MaxSpeed",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TireSize",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Products");
        }
    }
}
