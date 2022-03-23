using Microsoft.EntityFrameworkCore;
using VendingMachine.Data.Interfaces;
using VendingMachine.Entities;

namespace VendingMachine.Data
{
    public class VendingMachineContext : DbContext, IVendingMachineContext
    {
        public VendingMachineContext(DbContextOptions<VendingMachineContext> options) : base(options)
        {
        }

        public DbSet<Location> Locations { get; set; }
        public DbSet<Machine> Machines { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ModelBuilderExtensions.Seed(modelBuilder);
        }
    }
}
