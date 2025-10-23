using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP_system.Data.Migrations
{
    /// <inheritdoc />
    public partial class edit_budget : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "total",
                table: "Budget",
                newName: "Total");

            migrationBuilder.AddColumn<Guid>(
                name: "facilitiesID",
                table: "Budget",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<decimal>(
                name: "facilities_amount",
                table: "Budget",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<Guid>(
                name: "levelID",
                table: "Budget",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<decimal>(
                name: "level_amount",
                table: "Budget",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<Guid>(
                name: "serveyingID",
                table: "Budget",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<decimal>(
                name: "serveying_amount",
                table: "Budget",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_Budget_facilitiesID",
                table: "Budget",
                column: "facilitiesID");

            migrationBuilder.CreateIndex(
                name: "IX_Budget_levelID",
                table: "Budget",
                column: "levelID");

            migrationBuilder.CreateIndex(
                name: "IX_Budget_serveyingID",
                table: "Budget",
                column: "serveyingID");

            migrationBuilder.AddForeignKey(
                name: "FK_Budget_Items_facilitiesID",
                table: "Budget",
                column: "facilitiesID",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Budget_Items_levelID",
                table: "Budget",
                column: "levelID",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Budget_Items_serveyingID",
                table: "Budget",
                column: "serveyingID",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Budget_Items_facilitiesID",
                table: "Budget");

            migrationBuilder.DropForeignKey(
                name: "FK_Budget_Items_levelID",
                table: "Budget");

            migrationBuilder.DropForeignKey(
                name: "FK_Budget_Items_serveyingID",
                table: "Budget");

            migrationBuilder.DropIndex(
                name: "IX_Budget_facilitiesID",
                table: "Budget");

            migrationBuilder.DropIndex(
                name: "IX_Budget_levelID",
                table: "Budget");

            migrationBuilder.DropIndex(
                name: "IX_Budget_serveyingID",
                table: "Budget");

            migrationBuilder.DropColumn(
                name: "facilitiesID",
                table: "Budget");

            migrationBuilder.DropColumn(
                name: "facilities_amount",
                table: "Budget");

            migrationBuilder.DropColumn(
                name: "levelID",
                table: "Budget");

            migrationBuilder.DropColumn(
                name: "level_amount",
                table: "Budget");

            migrationBuilder.DropColumn(
                name: "serveyingID",
                table: "Budget");

            migrationBuilder.DropColumn(
                name: "serveying_amount",
                table: "Budget");

            migrationBuilder.RenameColumn(
                name: "Total",
                table: "Budget",
                newName: "total");
        }
    }
}
