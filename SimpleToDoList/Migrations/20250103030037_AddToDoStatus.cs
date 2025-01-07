﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleToDoList.Migrations
{
    /// <inheritdoc />
    public partial class AddToDoStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "ToDos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "ToDos");
        }
    }
}
