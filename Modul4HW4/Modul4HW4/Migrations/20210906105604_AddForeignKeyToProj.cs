using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Modul4HW4.Migrations
{
    public partial class AddForeignKeyToProj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 1,
                column: "DateOfRegistration",
                value: new DateTime(2021, 9, 6, 13, 56, 4, 123, DateTimeKind.Local).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 2,
                column: "DateOfRegistration",
                value: new DateTime(2021, 9, 6, 13, 56, 4, 126, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 3,
                column: "DateOfRegistration",
                value: new DateTime(2021, 9, 6, 13, 56, 4, 126, DateTimeKind.Local).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 4,
                column: "DateOfRegistration",
                value: new DateTime(2021, 9, 6, 13, 56, 4, 126, DateTimeKind.Local).AddTicks(1462));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 5,
                column: "DateOfRegistration",
                value: new DateTime(2021, 9, 6, 13, 56, 4, 126, DateTimeKind.Local).AddTicks(1466));

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ClientId",
                table: "Projects",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Clients_ClientId",
                table: "Projects",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Clients_ClientId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_ClientId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Projects");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 1,
                column: "DateOfRegistration",
                value: new DateTime(2021, 9, 6, 13, 23, 38, 905, DateTimeKind.Local).AddTicks(9737));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 2,
                column: "DateOfRegistration",
                value: new DateTime(2021, 9, 6, 13, 23, 38, 908, DateTimeKind.Local).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 3,
                column: "DateOfRegistration",
                value: new DateTime(2021, 9, 6, 13, 23, 38, 908, DateTimeKind.Local).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 4,
                column: "DateOfRegistration",
                value: new DateTime(2021, 9, 6, 13, 23, 38, 908, DateTimeKind.Local).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 5,
                column: "DateOfRegistration",
                value: new DateTime(2021, 9, 6, 13, 23, 38, 908, DateTimeKind.Local).AddTicks(5291));
        }
    }
}
