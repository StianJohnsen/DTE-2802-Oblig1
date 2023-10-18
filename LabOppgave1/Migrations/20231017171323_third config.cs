using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LabOppgave1.Migrations
{
    /// <inheritdoc />
    public partial class thirdconfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "Description",
                value: "iPhone 12 er en smarttelefon utviklet av Apple");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "Description",
                value: "iPhone 12 Pro er en smarttelefon utviklet av Apple");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "Description",
                value: "iPhone 12 Pro Max er en smarttelefon utviklet av Apple");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Description", "Price" },
                values: new object[] { "iPhone 12 Mini er en smarttelefon utviklet av Apple", null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "Description",
                value: "BMW 1-serie er en bil utviklet av BMW");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "Description", "Price" },
                values: new object[] { "BMW 2-serie er en bil utviklet av BMW", null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Description", "Price" },
                values: new object[] { "BMW 4-serie er en bil utviklet av BMW", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Description", "Price" },
                values: new object[] { null, 8999.99m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "Description", "Price" },
                values: new object[] { null, 400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Description", "Price" },
                values: new object[] { null, 600000m });
        }
    }
}
