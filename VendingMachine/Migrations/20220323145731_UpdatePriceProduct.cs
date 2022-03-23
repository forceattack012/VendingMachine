using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VendingMachine.Migrations
{
    public partial class UpdatePriceProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("64986310-8a27-4fa0-96d2-4d1d2f239b4b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("875014d3-afe7-46c8-bb92-4f95d21d907d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aab9af01-9641-4237-8e8d-3fb0e7515d94"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b0de6bf6-c09c-453d-857c-94092cafc177"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b3988913-67cd-44e4-a81f-8f36cb997ae8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b5bbe0b3-2549-4d86-928c-ffd5ad0b21fd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c69ecebb-0654-4203-a4c8-76f1f8b9da41"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dc71fef5-2bc2-4887-8fa9-fdaef8f4a583"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fc226d13-a1e7-40a9-ba26-931295a3d6e4"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("64986310-8a27-4fa0-96d2-4d1d2f239b4b"), "1", "Coke", 0.0, 20 },
                    { new Guid("875014d3-afe7-46c8-bb92-4f95d21d907d"), "4", "Coffee", 0.0, 12 },
                    { new Guid("aab9af01-9641-4237-8e8d-3fb0e7515d94"), "2", "Coke", 0.0, 20 },
                    { new Guid("b0de6bf6-c09c-453d-857c-94092cafc177"), "5", "Coffee", 0.0, 10 },
                    { new Guid("b3988913-67cd-44e4-a81f-8f36cb997ae8"), "1", "Coffee", 0.0, 20 },
                    { new Guid("b5bbe0b3-2549-4d86-928c-ffd5ad0b21fd"), "1", "Pepsi", 0.0, 20 },
                    { new Guid("c69ecebb-0654-4203-a4c8-76f1f8b9da41"), "2", "Pepsi", 0.0, 20 },
                    { new Guid("dc71fef5-2bc2-4887-8fa9-fdaef8f4a583"), "3", "Pepsi", 0.0, 30 },
                    { new Guid("fc226d13-a1e7-40a9-ba26-931295a3d6e4"), "4", "Pepsi", 0.0, 11 }
                });
        }
    }
}
