using Microsoft.EntityFrameworkCore;
using VendingMachine.Entities;

namespace VendingMachine.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>().HasData(
                new Location
                {
                    Id = "1",
                    Address = "กรุงเทพ"
                },
                new Location
                {
                    Id = "2",
                    Address = "ปทุมธานี"
                },
                new Location
                {
                    Id = "3",
                    Address = "พระรามสาม"
                }
            );
            modelBuilder.Entity<Machine>().HasData(
                new Machine()
                {
                    Id = "1",
                    Name = "M1",
                    LocationId = "1"
                },
                new Machine()
                {
                    Id = "2",
                    Name = "M2",
                    LocationId = "1"
                },
                new Machine()
                {
                    Id = "3",
                    Name = "C1",
                    LocationId = "2"
                },
                new Machine()
                {
                    Id = "4",
                    Name = "C2",
                    LocationId = "3"
                },
                new Machine()
                {
                    Id = "5",
                    Name = "C2",
                    LocationId = "3"
                }
            );
            modelBuilder.Entity<MachineInventory>().HasData(
                new MachineInventory()
                {
                    Id = Guid.NewGuid().ToString(),
                    MachineId = "1",
                    ProductId = "P1",
                    Quality = 12
                },
                new MachineInventory()
                {
                    Id = Guid.NewGuid().ToString(),
                    MachineId = "1",
                    ProductId = "P2",
                    Quality = 10
                },
                new MachineInventory()
                {
                    Id = Guid.NewGuid().ToString(),
                    MachineId = "1",
                    ProductId = "C1",
                    Quality = 20
                },
                new MachineInventory()
                {
                    Id = Guid.NewGuid().ToString(),
                    MachineId = "1",
                    ProductId = "C2",
                    Quality = 14
                },
                new MachineInventory()
                {
                    Id = Guid.NewGuid().ToString(),
                    MachineId = "2",
                    ProductId = "C2",
                    Quality = 11
                },
                new MachineInventory()
                {
                    Id = Guid.NewGuid().ToString(),
                    MachineId = "3",
                    ProductId = "C1",
                    Quality = 11
                },
                new MachineInventory()
                {
                    Id = Guid.NewGuid().ToString(),
                    MachineId = "3",
                    ProductId = "P1",
                    Quality = 10
                },
                new MachineInventory()
                {
                    Id = Guid.NewGuid().ToString(),
                    MachineId = "4",
                    ProductId = "P1",
                    Quality = 12
                }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = "P1",
                    Name = "Coke",
                    Price = 20
                },
                new Product()
                {
                    Id = "P2",
                    Name = "Pepsi",
                    Price = 10,
                },
                new Product()
                {
                    Id = "C1",
                    Name = "Coffee",
                    Price = 60,
                },
                new Product()
                {
                    Id = "C2",
                    Name = "Beer",
                    Price = 100
                }
            );
        }
    }
}
