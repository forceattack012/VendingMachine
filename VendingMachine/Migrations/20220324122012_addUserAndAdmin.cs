using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace VendingMachine.Migrations
{
    public partial class addUserAndAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<string>(type: "text", nullable: true),
                    Describetion = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MachineInventory",
                columns: new[] { "Id", "MachineId", "ProductId", "Quality" },
                values: new object[,]
                {
                    { "05c8be66-7848-4918-816b-d2776b567b76", "1", "C2", 14 },
                    { "2d68460a-d121-462e-b489-3e124f60a538", "4", "P1", 12 },
                    { "4ad1bfcc-e5bd-4137-99df-cc7506e5fdd7", "1", "C1", 20 },
                    { "5ccc8325-8781-4d66-99e5-27a5670fe6bb", "1", "P1", 12 },
                    { "bf468db4-4787-4656-bc58-4a03a1edf428", "3", "C1", 11 },
                    { "c75209c6-8209-4169-8e5e-a3e54a680ec5", "3", "P1", 10 },
                    { "d01a6271-59a0-4300-9c40-5d3c41e19795", "1", "P2", 10 },
                    { "f9fe51d9-6b0e-413a-ba51-f432e723297f", "2", "C2", 11 }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Describetion", "Type" },
                values: new object[,]
                {
                    { 1, "Customer", "User" },
                    { 2, "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreationTime", "Password", "RoleId", "UserName" },
                values: new object[,]
                {
                    { "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1234", 1, "abcd1234@gmail.com" },
                    { "2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1234", 1, "user@gmail.com" },
                    { "3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin1", 2, "admin1@gmail.com" },
                    { "4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin2", 2, "admin2@gmail.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleId",
                table: "User",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DeleteData(
                table: "MachineInventory",
                keyColumn: "Id",
                keyValue: "05c8be66-7848-4918-816b-d2776b567b76");

            migrationBuilder.DeleteData(
                table: "MachineInventory",
                keyColumn: "Id",
                keyValue: "2d68460a-d121-462e-b489-3e124f60a538");

            migrationBuilder.DeleteData(
                table: "MachineInventory",
                keyColumn: "Id",
                keyValue: "4ad1bfcc-e5bd-4137-99df-cc7506e5fdd7");

            migrationBuilder.DeleteData(
                table: "MachineInventory",
                keyColumn: "Id",
                keyValue: "5ccc8325-8781-4d66-99e5-27a5670fe6bb");

            migrationBuilder.DeleteData(
                table: "MachineInventory",
                keyColumn: "Id",
                keyValue: "bf468db4-4787-4656-bc58-4a03a1edf428");

            migrationBuilder.DeleteData(
                table: "MachineInventory",
                keyColumn: "Id",
                keyValue: "c75209c6-8209-4169-8e5e-a3e54a680ec5");

            migrationBuilder.DeleteData(
                table: "MachineInventory",
                keyColumn: "Id",
                keyValue: "d01a6271-59a0-4300-9c40-5d3c41e19795");

            migrationBuilder.DeleteData(
                table: "MachineInventory",
                keyColumn: "Id",
                keyValue: "f9fe51d9-6b0e-413a-ba51-f432e723297f");

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
        }
    }
}
