using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestApis.Migrations
{
    public partial class RestApisModelsEmployeeContextSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DOB", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 1L, new DateTime(1980, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "jhonpablo@gmail.com", "Jhon", "Pablo", "0331223343" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DOB", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 2L, new DateTime(1990, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "adamsalah@gmail.com", "Adam", "Salah", "0311223334" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2L);
        }
    }
}
