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
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Coke",
                    Price = 20,
                    MachineId = "1",
                    Quality = 20
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Pepsi",
                    Price = 10,
                    MachineId = "1",
                    Quality = 20
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Coffee",
                    Price = 60,
                    MachineId = "1",
                    Quality = 20
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Coke",
                    MachineId = "2",
                    Quality = 20
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Price = 10,
                    Name = "Pepsi",
                    MachineId = "2",
                    Quality = 20
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Price = 10,
                    Name = "Pepsi",
                    MachineId = "3",
                    Quality = 30
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Pepsi",
                    Price = 10,
                    MachineId = "4",
                    Quality = 11
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Coffee",
                    Price = 60,
                    MachineId = "4",
                    Quality = 12
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Price = 60,
                    Name = "Coffee",
                    MachineId = "5",
                    Quality = 10
                }
            );
        }
    }
}
