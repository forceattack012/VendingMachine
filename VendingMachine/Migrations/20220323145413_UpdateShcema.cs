using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VendingMachine.Migrations
{
    public partial class UpdateShcema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Machines_Machines_MachineId",
                table: "Machines");

            migrationBuilder.DropIndex(
                name: "IX_Machines_MachineId",
                table: "Machines");

            migrationBuilder.DropColumn(
                name: "MachineId",
                table: "Machines");

            migrationBuilder.AddColumn<string>(
                name: "MachineId",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address" },
                values: new object[,]
                {
                    { "1", "กรุงเทพ" },
                    { "2", "ปทุมธานี" },
                    { "3", "พระรามสาม" }
                });

            migrationBuilder.InsertData(
                table: "Machines",
                columns: new[] { "Id", "LocationId", "Name" },
                values: new object[,]
                {
                    { "1", "1", "M1" },
                    { "2", "1", "M2" },
                    { "3", "2", "C1" },
                    { "4", "3", "C2" },
                    { "5", "3", "C2" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Products_MachineId",
                table: "Products",
                column: "MachineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Machines_MachineId",
                table: "Products",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Machines_MachineId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_MachineId",
                table: "Products");

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

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DropColumn(
                name: "MachineId",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "MachineId",
                table: "Machines",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Machines_MachineId",
                table: "Machines",
                column: "MachineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Machines_Machines_MachineId",
                table: "Machines",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "Id");
        }
    }
}
