using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VendingMachine.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Machines",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    LocationId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Machines_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MachineInventory",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    MachineId = table.Column<string>(type: "text", nullable: true),
                    ProductId = table.Column<string>(type: "text", nullable: true),
                    Quality = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachineInventory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MachineInventory_Machines_MachineId",
                        column: x => x.MachineId,
                        principalTable: "Machines",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MachineInventory_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

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
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { "C1", "Coffee", 60.0 },
                    { "C2", "Coke", 0.0 },
                    { "P1", "Coke", 20.0 },
                    { "P2", "Pepsi", 10.0 }
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

            migrationBuilder.CreateIndex(
                name: "IX_MachineInventory_MachineId",
                table: "MachineInventory",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_MachineInventory_ProductId",
                table: "MachineInventory",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Machines_LocationId",
                table: "Machines",
                column: "LocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MachineInventory");

            migrationBuilder.DropTable(
                name: "Machines");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
