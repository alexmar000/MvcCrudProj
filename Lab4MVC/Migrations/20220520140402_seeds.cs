using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab4MVC.Migrations
{
    public partial class seeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CustomerBorrowings",
                keyColumn: "Id",
                keyValue: 1,
                column: "BorrowDate",
                value: new DateTime(2021, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CustomerBorrowings",
                keyColumn: "Id",
                keyValue: 2,
                column: "BorrowDate",
                value: new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CustomerBorrowings",
                keyColumn: "Id",
                keyValue: 3,
                column: "BorrowDate",
                value: new DateTime(2021, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CustomerBorrowings",
                keyColumn: "Id",
                keyValue: 4,
                column: "BorrowDate",
                value: new DateTime(2020, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CustomerBorrowings",
                keyColumn: "Id",
                keyValue: 5,
                column: "BorrowDate",
                value: new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CustomerBorrowings",
                keyColumn: "Id",
                keyValue: 1,
                column: "BorrowDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1985));

            migrationBuilder.UpdateData(
                table: "CustomerBorrowings",
                keyColumn: "Id",
                keyValue: 2,
                column: "BorrowDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "CustomerBorrowings",
                keyColumn: "Id",
                keyValue: 3,
                column: "BorrowDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "CustomerBorrowings",
                keyColumn: "Id",
                keyValue: 4,
                column: "BorrowDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1998));

            migrationBuilder.UpdateData(
                table: "CustomerBorrowings",
                keyColumn: "Id",
                keyValue: 5,
                column: "BorrowDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2007));
        }
    }
}
