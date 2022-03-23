using Microsoft.EntityFrameworkCore;
using VendingMachine.Entities;

namespace VendingMachine.Data.Interfaces
{
    public interface IVendingMachineContext
    {
        public DbSet<Location> Locations { get; }
        public DbSet<Machine> Machines { get; }
        public DbSet<Product> Products { get; }
        public DbSet<MachineInventory> MachineInventory { get; }
    }
}
