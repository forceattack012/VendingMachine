using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VendingMachine.Migrations
{
    public partial class UpdateMachine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26c116d7-f6c1-4cda-8253-0616fd4af167"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3ebf064d-cdcc-4d4a-a9c9-db1aa55e8fad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7a0f7a59-975b-4317-86a4-619975e46f9e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e6972dc-5b82-47f9-aa2f-1d270e563bc9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8851b0de-76c1-43b7-82d9-477b800f31ef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("961b02db-9e2b-49d1-8bca-e327ad1a4fd7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c5d16e7a-749c-4f74-b883-5b40f751db45"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cf3bc0b8-9f1c-4f71-9f16-75727e5e71be"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d41d8ca6-c1cb-4882-b71e-162ffd0d90e9"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "MachineId", "Name", "Price", "Quality" },
                values: new object[,]
                {
                    { new Guid("1b68033d-f3af-4145-b009-d17f8045dfcc"), "1", "Coffee", 60.0, 20 },
                    { new Guid("3507d65a-64d8-432b-8125-4be340ae5c2d"), "5", "Coffee", 60.0, 10 },
                    { new Guid("36fbe764-f9b9-4c4c-9dad-3fe09a7b9bdc"), "2", "Coke", 0.0, 20 },
                    { new Guid("5705ffcb-45e5-4a40-9f4e-1ce3d955df5d"), "3", "Pepsi", 10.0, 30 },
                    { new Guid("7e01b329-7daa-46cd-a1ff-debfcae43933"), "2", "Pepsi", 10.0, 20 },
                    { new Guid("8b710d38-cf74-47a3-885d-3d8227091a54"), "1", "Coke", 20.0, 20 },
                    { new Guid("92ee1004-76f2-4784-8fdf-b90b091a175c"), "1", "Pepsi", 10.0, 20 },
                    { new Guid("fb7b0e24-d6c5-488d-8b32-49bfc6caacf0"), "4", "Coffee", 60.0, 12 },
                    { new Guid("fb85263f-a207-4e0f-be80-284df72f1f5d"), "4", "Pepsi", 10.0, 11 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1b68033d-f3af-4145-b009-d17f8045dfcc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3507d65a-64d8-432b-8125-4be340ae5c2d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("36fbe764-f9b9-4c4c-9dad-3fe09a7b9bdc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5705ffcb-45e5-4a40-9f4e-1ce3d955df5d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e01b329-7daa-46cd-a1ff-debfcae43933"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8b710d38-cf74-47a3-885d-3d8227091a54"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("92ee1004-76f2-4784-8fdf-b90b091a175c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fb7b0e24-d6c5-488d-8b32-49bfc6caacf0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fb85263f-a207-4e0f-be80-284df72f1f5d"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "MachineId", "Name", "Price", "Quality" },
                values: new object[,]
                {
                    { new Guid("26c116d7-f6c1-4cda-8253-0616fd4af167"), "4", "Coffee", 60.0, 12 },
                    { new Guid("3ebf064d-cdcc-4d4a-a9c9-db1aa55e8fad"), "4", "Pepsi", 10.0, 11 },
                    { new Guid("7a0f7a59-975b-4317-86a4-619975e46f9e"), "3", "Pepsi", 10.0, 30 },
                    { new Guid("7e6972dc-5b82-47f9-aa2f-1d270e563bc9"), "1", "Coke", 20.0, 20 },
                    { new Guid("8851b0de-76c1-43b7-82d9-477b800f31ef"), "5", "Coffee", 60.0, 10 },
                    { new Guid("961b02db-9e2b-49d1-8bca-e327ad1a4fd7"), "1", "Coffee", 60.0, 20 },
                    { new Guid("c5d16e7a-749c-4f74-b883-5b40f751db45"), "1", "Pepsi", 10.0, 20 },
                    { new Guid("cf3bc0b8-9f1c-4f71-9f16-75727e5e71be"), "2", "Coke", 0.0, 20 },
                    { new Guid("d41d8ca6-c1cb-4882-b71e-162ffd0d90e9"), "2", "Pepsi", 10.0, 20 }
                });
        }
    }
}
