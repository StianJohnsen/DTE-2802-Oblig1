using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LabOppgave1.Migrations
{
    /// <inheritdoc />
    public partial class Initialconfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Manufacturer",
                columns: table => new
                {
                    ManufacturerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturer", x => x.ManufacturerId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ManufacturerId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<decimal>(type: "decimal(8,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Manufacturer_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturer",
                        principalColumn: "ManufacturerId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Elektronikk er en samlebetegnelse for alle produkter som er basert på elektriske komponenter", "Elektronikk" },
                    { 2, "Kjøretøy er et fremkomstmiddel som kan transportere mennesker eller gods", "Kjøretøy" },
                    { 3, "Hvitevarer er en fellesbetegnelse på elektriske husholdningsapparater", "Hvitevarer" }
                });

            migrationBuilder.InsertData(
                table: "Manufacturer",
                columns: new[] { "ManufacturerId", "Address", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "20863 Stevens Creek Blvd., (Building 3, Suite C) in Cupertino, California", "Apple er en stor produsent av elektronikk", "Apple" },
                    { 2, "Petuelring 130, 80809 München, Tyskland", "BMW er en stor produsent av biler", "BMW" },
                    { 3, "Werner-von-Siemens-Straße 1, 80333 München, Tyskland", "Siemens er en stor produsent av hvitevarer", "Siemens" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "CategoryId", "Description", "ManufacturerId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "iPhone 12 er en smarttelefon utviklet av Apple", 1, "iPhone 12", 9999.99m },
                    { 2, 1, "iPhone 12 Pro er en smarttelefon utviklet av Apple", 1, "iPhone 12 Pro", 12999.99m },
                    { 3, 1, "iPhone 12 Pro Max er en smarttelefon utviklet av Apple", 1, "iPhone 12 Pro Max", 14999.99m },
                    { 4, 1, "iPhone 12 Mini er en smarttelefon utviklet av Apple", 1, "iPhone 12 Mini", null },
                    { 5, 1, null, 1, "iPhone SE", 4999.99m },
                    { 6, 2, "BMW 1-serie er en bil utviklet av BMW", 2, "BMW 1-serie", 300000m },
                    { 7, 2, "BMW 2-serie er en bil utviklet av BMW", 2, "BMW 2-serie", null },
                    { 8, 2, null, 2, "BMW 3-serie", 500000m },
                    { 9, 2, "BMW 4-serie er en bil utviklet av BMW", 2, "BMW 4-serie", null },
                    { 10, 2, "BMW 5-serie er en bil utviklet av BMW", 2, "BMW 5-serie", 700000m },
                    { 11, 3, "Siemens EQ.9 plus connect er en kaffemaskin utviklet av Siemens", 3, "Siemens EQ.9 plus connect", null },
                    { 12, 3, "Siemens EQ.6 plus s700 er en kaffemaskin utviklet av Siemens", 3, "Siemens EQ.6 plus s700", 15000m },
                    { 13, 3, "Siemens EQ.500 integral er en kaffemaskin utviklet av Siemens", 3, "Siemens EQ.500 integral", null },
                    { 14, 3, null, 3, "Siemens EQ.300", 5000m },
                    { 15, 3, "Siemens EQ.200 er en kaffemaskin utviklet av Siemens", 3, "Siemens EQ.200", 3000m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ManufacturerId",
                table: "Product",
                column: "ManufacturerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Manufacturer");
        }
    }
}
