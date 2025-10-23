using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP_system.Data.Migrations
{
    /// <inheritdoc />
    public partial class item : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "amount",
                table: "Proceeds",
                newName: "serveying_amount");

            migrationBuilder.RenameColumn(
                name: "payment_image",
                table: "Payment_order",
                newName: "payment_image_serveying");

            migrationBuilder.RenameColumn(
                name: "amount",
                table: "Payment_order",
                newName: "serveying_amount");

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "Proceeds",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<Guid>(
                name: "facilitiesID",
                table: "Proceeds",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<decimal>(
                name: "facilities_amount",
                table: "Proceeds",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<Guid>(
                name: "levelID",
                table: "Proceeds",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<decimal>(
                name: "level_amount",
                table: "Proceeds",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "payment_image_facilities",
                table: "Proceeds",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "payment_image_level",
                table: "Proceeds",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "payment_image_serveying",
                table: "Proceeds",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "serveyingID",
                table: "Proceeds",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "Payment_order",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<Guid>(
                name: "facilitiesID",
                table: "Payment_order",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<decimal>(
                name: "facilities_amount",
                table: "Payment_order",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<Guid>(
                name: "levelID",
                table: "Payment_order",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<decimal>(
                name: "level_amount",
                table: "Payment_order",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "payment_image_facilities",
                table: "Payment_order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "payment_image_level",
                table: "Payment_order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "serveyingID",
                table: "Payment_order",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Proceeds_facilitiesID",
                table: "Proceeds",
                column: "facilitiesID");

            migrationBuilder.CreateIndex(
                name: "IX_Proceeds_levelID",
                table: "Proceeds",
                column: "levelID");

            migrationBuilder.CreateIndex(
                name: "IX_Proceeds_serveyingID",
                table: "Proceeds",
                column: "serveyingID");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_order_facilitiesID",
                table: "Payment_order",
                column: "facilitiesID");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_order_levelID",
                table: "Payment_order",
                column: "levelID");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_order_serveyingID",
                table: "Payment_order",
                column: "serveyingID");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_order_Items_facilitiesID",
                table: "Payment_order",
                column: "facilitiesID",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_order_Items_levelID",
                table: "Payment_order",
                column: "levelID",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_order_Items_serveyingID",
                table: "Payment_order",
                column: "serveyingID",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Proceeds_Items_facilitiesID",
                table: "Proceeds",
                column: "facilitiesID",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Proceeds_Items_levelID",
                table: "Proceeds",
                column: "levelID",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Proceeds_Items_serveyingID",
                table: "Proceeds",
                column: "serveyingID",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_order_Items_facilitiesID",
                table: "Payment_order");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_order_Items_levelID",
                table: "Payment_order");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_order_Items_serveyingID",
                table: "Payment_order");

            migrationBuilder.DropForeignKey(
                name: "FK_Proceeds_Items_facilitiesID",
                table: "Proceeds");

            migrationBuilder.DropForeignKey(
                name: "FK_Proceeds_Items_levelID",
                table: "Proceeds");

            migrationBuilder.DropForeignKey(
                name: "FK_Proceeds_Items_serveyingID",
                table: "Proceeds");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Proceeds_facilitiesID",
                table: "Proceeds");

            migrationBuilder.DropIndex(
                name: "IX_Proceeds_levelID",
                table: "Proceeds");

            migrationBuilder.DropIndex(
                name: "IX_Proceeds_serveyingID",
                table: "Proceeds");

            migrationBuilder.DropIndex(
                name: "IX_Payment_order_facilitiesID",
                table: "Payment_order");

            migrationBuilder.DropIndex(
                name: "IX_Payment_order_levelID",
                table: "Payment_order");

            migrationBuilder.DropIndex(
                name: "IX_Payment_order_serveyingID",
                table: "Payment_order");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "Proceeds");

            migrationBuilder.DropColumn(
                name: "facilitiesID",
                table: "Proceeds");

            migrationBuilder.DropColumn(
                name: "facilities_amount",
                table: "Proceeds");

            migrationBuilder.DropColumn(
                name: "levelID",
                table: "Proceeds");

            migrationBuilder.DropColumn(
                name: "level_amount",
                table: "Proceeds");

            migrationBuilder.DropColumn(
                name: "payment_image_facilities",
                table: "Proceeds");

            migrationBuilder.DropColumn(
                name: "payment_image_level",
                table: "Proceeds");

            migrationBuilder.DropColumn(
                name: "payment_image_serveying",
                table: "Proceeds");

            migrationBuilder.DropColumn(
                name: "serveyingID",
                table: "Proceeds");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "Payment_order");

            migrationBuilder.DropColumn(
                name: "facilitiesID",
                table: "Payment_order");

            migrationBuilder.DropColumn(
                name: "facilities_amount",
                table: "Payment_order");

            migrationBuilder.DropColumn(
                name: "levelID",
                table: "Payment_order");

            migrationBuilder.DropColumn(
                name: "level_amount",
                table: "Payment_order");

            migrationBuilder.DropColumn(
                name: "payment_image_facilities",
                table: "Payment_order");

            migrationBuilder.DropColumn(
                name: "payment_image_level",
                table: "Payment_order");

            migrationBuilder.DropColumn(
                name: "serveyingID",
                table: "Payment_order");

            migrationBuilder.RenameColumn(
                name: "serveying_amount",
                table: "Proceeds",
                newName: "amount");

            migrationBuilder.RenameColumn(
                name: "serveying_amount",
                table: "Payment_order",
                newName: "amount");

            migrationBuilder.RenameColumn(
                name: "payment_image_serveying",
                table: "Payment_order",
                newName: "payment_image");
        }
    }
}
