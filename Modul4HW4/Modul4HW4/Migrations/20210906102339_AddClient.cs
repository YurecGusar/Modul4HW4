using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Modul4HW4.Migrations
{
    public partial class AddClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SecondName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DataOfBirth = table.Column<DateTime>(type: "date", nullable: true),
                    DateOfRegistration = table.Column<DateTime>(type: "datetime2", maxLength: 7, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "DataOfBirth", "DateOfRegistration", "FirstName", "SecondName" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2021, 9, 6, 13, 23, 38, 905, DateTimeKind.Local).AddTicks(9737), "Ivan", "Budko" },
                    { 2, null, new DateTime(2021, 9, 6, 13, 23, 38, 908, DateTimeKind.Local).AddTicks(4537), "Dmitro", "Burunko" },
                    { 3, new DateTime(2001, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 6, 13, 23, 38, 908, DateTimeKind.Local).AddTicks(5271), "Yurii", "Leonov" },
                    { 4, new DateTime(2000, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 6, 13, 23, 38, 908, DateTimeKind.Local).AddTicks(5288), "Andry", "Kust" },
                    { 5, new DateTime(2014, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 6, 13, 23, 38, 908, DateTimeKind.Local).AddTicks(5291), "Misha", "Krutoy" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
