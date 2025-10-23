using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP_system.Data.Migrations
{
    /// <inheritdoc />
    public partial class initiate_someUpdates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Center",
                columns: table => new
                {
                    centerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    centerName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Center", x => x.centerId);
                });

            migrationBuilder.CreateTable(
                name: "Budget",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    year = table.Column<int>(type: "int", nullable: false),
                    total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    centerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Budget", x => x.id);
                    table.ForeignKey(
                        name: "FK_Budget_Center_centerId",
                        column: x => x.centerId,
                        principalTable: "Center",
                        principalColumn: "centerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payment_order",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    centerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    payment_image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment_order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payment_order_Center_centerId",
                        column: x => x.centerId,
                        principalTable: "Center",
                        principalColumn: "centerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Village",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CenterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Village", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Village_Center_CenterId",
                        column: x => x.CenterId,
                        principalTable: "Center",
                        principalColumn: "centerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Proceeds",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    villaged_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateOnly = table.Column<DateOnly>(type: "date", nullable: false),
                    amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proceeds", x => x.id);
                    table.ForeignKey(
                        name: "FK_Proceeds_Village_villaged_id",
                        column: x => x.villaged_id,
                        principalTable: "Village",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Budget_centerId",
                table: "Budget",
                column: "centerId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_order_centerId",
                table: "Payment_order",
                column: "centerId");

            migrationBuilder.CreateIndex(
                name: "IX_Proceeds_villaged_id",
                table: "Proceeds",
                column: "villaged_id");

            migrationBuilder.CreateIndex(
                name: "IX_Village_CenterId",
                table: "Village",
                column: "CenterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Budget");

            migrationBuilder.DropTable(
                name: "Payment_order");

            migrationBuilder.DropTable(
                name: "Proceeds");

            migrationBuilder.DropTable(
                name: "Village");

            migrationBuilder.DropTable(
                name: "Center");
        }
    }
}
