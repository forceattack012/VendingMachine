using Microsoft.EntityFrameworkCore;
using System.Linq;
using VendingMachine.Data;
using VendingMachine.Data.Interfaces;
using VendingMachine.Entities;
using VendingMachine.Models;
using VendingMachine.Repositories.Interfaces;

namespace VendingMachine.Repositories
{
    public class MachineInventoryRepository : IMachineInventoryRepository
    {
        private readonly VendingMachineContext _vendingMachineContext;

        public MachineInventoryRepository(VendingMachineContext vendingMachineContext)
        {
            _vendingMachineContext = vendingMachineContext;
        }

        public async Task<IEnumerable<MachineInventory>> GetMachineInventoriesAsync()
        {
            return await _vendingMachineContext.MachineInventory
                    .Include(r => r.Machine)
                    .Include(r => r.Product)
                    .OrderBy(r => r.MachineId)
                    .ToListAsync();
        }

        public async Task<IEnumerable<MachineInventory>> GetMachineInventoriesByMachineIdAsync(string machineId)
        {
            return await _vendingMachineContext.MachineInventory
                        .Where(r => r.MachineId == machineId)
                        .Include(r => r.Machine)
                        .Include(r => r.Product)
                        .OrderBy(r => r.MachineId)
                        .ToListAsync();
        }

        public async Task<MachineInventory> GetProductByMachineInventoryIdAndProductId(string ventoryId, string productId)
        {
            return await _vendingMachineContext.MachineInventory
                        .Where(r => r.Id == ventoryId && r.ProductId == productId)
                        .Include(r => r.Product)
                        .FirstOrDefaultAsync();
        }

        public async Task<bool> Update(MachineInventory machineInventory)
        {
            _vendingMachineContext.MachineInventory.Update(machineInventory);
            await _vendingMachineContext.SaveChangesAsync();

            return true;
        }
    }
}
