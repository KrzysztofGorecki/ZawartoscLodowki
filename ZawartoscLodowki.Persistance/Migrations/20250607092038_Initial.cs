using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZawartoscLodowki.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssortmentKinds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssortmentKinds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeasureUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeasureUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Assortments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssortmentKindId = table.Column<int>(type: "int", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    MeasureUnitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assortments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assortments_AssortmentKinds_AssortmentKindId",
                        column: x => x.AssortmentKindId,
                        principalTable: "AssortmentKinds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Assortments_MeasureUnits_MeasureUnitId",
                        column: x => x.MeasureUnitId,
                        principalTable: "MeasureUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AssortmentKinds",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Nabiał" },
                    { 2, "Szynka" },
                    { 3, "Pieczywo" },
                    { 4, "Sok" },
                    { 5, "Warzywa" },
                    { 6, "Owoce" }
                });

            migrationBuilder.InsertData(
                table: "MeasureUnits",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Szt" },
                    { 2, "L" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assortments_AssortmentKindId",
                table: "Assortments",
                column: "AssortmentKindId");

            migrationBuilder.CreateIndex(
                name: "IX_Assortments_MeasureUnitId",
                table: "Assortments",
                column: "MeasureUnitId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assortments");

            migrationBuilder.DropTable(
                name: "AssortmentKinds");

            migrationBuilder.DropTable(
                name: "MeasureUnits");
        }
    }
}
