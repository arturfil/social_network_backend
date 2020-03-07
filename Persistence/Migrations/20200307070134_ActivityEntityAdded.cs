﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class ActivityEntityAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    Venue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Values",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Value 101 From API");

            migrationBuilder.UpdateData(
                table: "Values",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Value 102 From API");

            migrationBuilder.UpdateData(
                table: "Values",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Value 103 From API");

            migrationBuilder.UpdateData(
                table: "Values",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Value 104 From API");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.UpdateData(
                table: "Values",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Value 101");

            migrationBuilder.UpdateData(
                table: "Values",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Value 102");

            migrationBuilder.UpdateData(
                table: "Values",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Value 103");

            migrationBuilder.UpdateData(
                table: "Values",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Value 104");
        }
    }
}
