﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GTERP.Migrations.GTRDB
{
    public partial class AddCatShiftColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DinnerAllowTime",
                table: "Cat_Shift",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FridayAllowTime",
                table: "Cat_Shift",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NightAllowTime",
                table: "Cat_Shift",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DinnerAllowTime",
                table: "Cat_Shift");

            migrationBuilder.DropColumn(
                name: "FridayAllowTime",
                table: "Cat_Shift");

            migrationBuilder.DropColumn(
                name: "NightAllowTime",
                table: "Cat_Shift");
        }
    }
}
