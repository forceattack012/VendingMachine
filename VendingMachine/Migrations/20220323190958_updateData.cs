using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VendingMachine.Migrations
{
    public partial class updateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MachineInventory",
                keyColumn: "Id",
                keyValue: "46ce688f-4fd1-4b13-8d63-77ec80f8b133");

            migrationBuilder.DeleteData(
                table: "MachineInventory",
                keyColumn: "Id",
                keyValue: "6bdee265-513f-4b34-8bac-f9c5b0bb5ab0");

            migrationBuilder.DeleteData(
                table: "MachineInventory",
                keyColumn: "Id",
                keyValue: "6f052dc7-e591-4e92-bed5-699df3609389");

            migrationBuilder.DeleteData(
                table: "MachineInventory",
                keyColumn: "Id",
                keyValue: "72139610-0781-4689-8c95-84f7fd4929e3");

            migrationBuilder.DeleteData(
                table: "MachineInventory",
                keyColumn: "Id",
                keyValue: "9eeeee19-d8f5-4450-9496-fe0545e7ec9d");

            migrationBuilder.DeleteData(
                table: "MachineInventory",
                keyColumn: "Id",
                keyValue: "b0dfa2a7-de19-4d22-a523-d77d159c567d");

            migrationBuilder.DeleteData(
                table: "MachineInventory",
                keyColumn: "Id",
                keyValue: "db443e71-f762-4f04-9d76-6e05589a4488");

            migrationBuilder.DeleteData(
                table: "MachineInventory",
                keyColumn: "Id",
                keyValue: "ee1870b3-fbf1-4398-a430-f6a51cc66108");

            migrationBuilder.InsertData(
                table: "MachineInventory",
                columns: new[] { "Id", "MachineId", "ProductId", "Quality" },
                values: new object[,]
                {
                    { "05a9b2b2-aa8c-450f-a673-0d6ff5b25348", "2", "C2", 11 },
                    { "2e77c93d-ff01-45ad-888d-19fff21a0b6f", "1", "C2", 14 },
                    { "4b3c9958-09b7-4ef7-9b09-28f340343f1b", "1", "P2", 10 },
                    { "931ecc20-4981-4ea4-856f-536c5e104a77", "3", "C1", 11 },
                    { "a5ea28d6-2b26-483e-989b-037b5044b2b8", "4", "P1", 12 },
                    { "a9b52ca4-a324-4b34-bf20-0a5188b6e1e5", "3", "P1", 10 },
                    { "aa1dbef8-977d-4e29-a285-d32314185afb", "1", "P1", 12 },
                    { "b7d698db-ab1a-46fe-af66-939ecd33cdad", "1", "C1", 20 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "C2",
                columns: new[] { "Name", "Price" },
                values: new object[] { "Beer", 100.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MachineInventory",
                keyColumn: "Id",
                keyValue: "05a9b2b2-aa8c-450f-a673-0d6ff5b25348");

            migrationBuilder.DeleteData(
                table: "MachineInventory",
                keyColumn: "Id",
                keyValue: "2e77c93d-ff01-45ad-888d-19fff21a0b6f");

            migrationBuilder.DeleteData(
                table: "MachineInventory",
                keyColumn: "Id",
                keyValue: "4b3c9958-09b7-4ef7-9b09-28f340343f1b");

            migrationBuilder.DeleteData(
                table: "MachineInventory",
                keyColumn: "Id",
                keyValue: "931ecc20-4981-4ea4-856f-536c5e104a77");

            migrationBuilder.DeleteData(
                table: "MachineInventory",
                keyColumn: "Id",
                keyValue: "a5ea28d6-2b26-483e-989b-037b5044b2b8");

            migrationBuilder.DeleteData(
                table: "MachineInventory",
                keyColumn: "Id",
                keyValue: "a9b52ca4-a324-4b34-bf20-0a5188b6e1e5");

            migrationBuilder.DeleteData(
                table: "MachineInventory",
                keyColumn: "Id",
                keyValue: "aa1dbef8-977d-4e29-a285-d32314185afb");

            migrationBuilder.DeleteData(
                table: "MachineInventory",
                keyColumn: "Id",
                keyValue: "b7d698db-ab1a-46fe-af66-939ecd33cdad");

            migrationBuilder.InsertData(
                table: "MachineInventory",
                columns: new[] { "Id", "MachineId", "ProductId", "Quality" },
                values: new object[,]
                {
                    { "46ce688f-4fd1-4b13-8d63-77ec80f8b133", "4", "P1", 12 },
                    { "6bdee265-513f-4b34-8bac-f9c5b0bb5ab0", "3", "C1", 11 },
                    { "6f052dc7-e591-4e92-bed5-699df3609389", "3", "P1", 10 },
                    { "72139610-0781-4689-8c95-84f7fd4929e3", "1", "P2", 10 },
                    { "9eeeee19-d8f5-4450-9496-fe0545e7ec9d", "2", "C2", 11 },
                    { "b0dfa2a7-de19-4d22-a523-d77d159c567d", "1", "C2", 14 },
                    { "db443e71-f762-4f04-9d76-6e05589a4488", "1", "P1", 12 },
                    { "ee1870b3-fbf1-4398-a430-f6a51cc66108", "1", "C1", 20 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "C2",
                columns: new[] { "Name", "Price" },
                values: new object[] { "Coke", 0.0 });
        }
    }
}
