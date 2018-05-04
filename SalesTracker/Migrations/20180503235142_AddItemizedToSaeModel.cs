using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesTracker.Migrations
{
    public partial class AddItemizedToSaeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Sales_SaleId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_SaleId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "SaleId",
                table: "Items");

            migrationBuilder.AddColumn<string>(
                name: "Itemized",
                table: "Sales",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Itemized",
                table: "Sales");

            migrationBuilder.AddColumn<int>(
                name: "SaleId",
                table: "Items",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_SaleId",
                table: "Items",
                column: "SaleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Sales_SaleId",
                table: "Items",
                column: "SaleId",
                principalTable: "Sales",
                principalColumn: "SaleId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
