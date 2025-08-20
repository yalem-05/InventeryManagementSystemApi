using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class withrelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "items",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_items_UserId",
                table: "items",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_items_users_UserId",
                table: "items",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_items_users_UserId",
                table: "items");

            migrationBuilder.DropIndex(
                name: "IX_items_UserId",
                table: "items");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "items");
        }
    }
}
