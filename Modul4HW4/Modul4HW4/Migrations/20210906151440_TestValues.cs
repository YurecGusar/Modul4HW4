using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Modul4HW4.Migrations
{
    public partial class TestValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Projects",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 1,
                column: "DateOfRegistration",
                value: new DateTime(2021, 9, 6, 18, 14, 40, 465, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 2,
                column: "DateOfRegistration",
                value: new DateTime(2021, 9, 6, 18, 14, 40, 465, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 3,
                column: "DateOfRegistration",
                value: new DateTime(2021, 9, 6, 18, 14, 40, 465, DateTimeKind.Local).AddTicks(7589));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 4,
                column: "DateOfRegistration",
                value: new DateTime(2021, 9, 6, 18, 14, 40, 465, DateTimeKind.Local).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 5,
                column: "DateOfRegistration",
                value: new DateTime(2021, 9, 6, 18, 14, 40, 465, DateTimeKind.Local).AddTicks(7606));

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "OfficeId", "Location", "Title" },
                values: new object[,]
                {
                    { 1, "asfafasf", "asaaaswd" },
                    { 5, "hgfgr", "vcbcvb" },
                    { 4, "ggg", "sddfg" },
                    { 3, "sss", "aaa" },
                    { 2, "qwert", "lkgfd" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "Budget", "ClientId", "Name", "StartedTime" },
                values: new object[,]
                {
                    { 2, 12345m, 2, "Second", new DateTime(2001, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 12345m, 3, "qqq", new DateTime(2001, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 12345m, 4, "ddd", new DateTime(2001, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 12345m, 1, "First", new DateTime(2001, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 12345m, 5, "dssfs", new DateTime(2021, 9, 6, 18, 14, 40, 460, DateTimeKind.Local).AddTicks(9851) }
                });

            migrationBuilder.InsertData(
                table: "Titles",
                columns: new[] { "TitleId", "Name" },
                values: new object[,]
                {
                    { 1, "qwerty" },
                    { 2, "fdsgrs" },
                    { 3, "fdgkjjgf" },
                    { 4, "asdfg" },
                    { 5, "zxcvbn" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DataOfBirth", "FirstName", "HiredData", "LastName", "OfficeId", "TitleId" },
                values: new object[,]
                {
                    { 1, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tatur", new DateTime(2019, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), " ", 1, 1 },
                    { 2, new DateTime(1999, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vlad", new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vladov", 2, 2 },
                    { 3, new DateTime(1990, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivan", new DateTime(2020, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stepanov", 3, 3 },
                    { 4, new DateTime(1954, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mark", new DateTime(2000, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fedorov", 4, 4 },
                    { 5, new DateTime(1968, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tom", new DateTime(2010, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Black", 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "EmployeeProjects",
                columns: new[] { "EmployeeProjectId", "EmployeeId", "ProjectId", "Rate", "StartedDate" },
                values: new object[,]
                {
                    { 1, 1, 1, 557m, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, 2, 557m, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, 3, 100m, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, 4, 100m, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 5, 5, 557m, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EmployeeProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EmployeeProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EmployeeProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EmployeeProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "OfficeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "OfficeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "OfficeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "OfficeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "OfficeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "TitleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "TitleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "TitleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "TitleId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "TitleId",
                keyValue: 5);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Projects",
                type: "nvarchar",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

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
        }
    }
}
