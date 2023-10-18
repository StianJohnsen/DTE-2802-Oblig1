using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LabOppgave1.Migrations
{
    /// <inheritdoc />
    public partial class fourthconfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "Description",
                value: "BMW 5-serie er en bil utviklet av BMW");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Siemens EQ.9 plus connect er en kaffemaskin utviklet av Siemens", null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "Description",
                value: "Siemens EQ.6 plus s700 er en kaffemaskin utviklet av Siemens");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Siemens EQ.500 integral er en kaffemaskin utviklet av Siemens", null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "Description",
                value: "Siemens EQ.200 er en kaffemaskin utviklet av Siemens");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "Description", "Price" },
                values: new object[] { null, 20000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "Description", "Price" },
                values: new object[] { null, 10000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "Description",
                value: null);
        }
    }
}
