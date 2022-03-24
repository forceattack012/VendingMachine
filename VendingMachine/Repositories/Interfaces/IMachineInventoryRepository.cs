using VendingMachine.Entities;

namespace VendingMachine.Repositories.Interfaces
{
    public interface IMachineInventoryRepository
    {
        Task<IEnumerable<MachineInventory>> GetMachineInventoriesAsync();
        Task<IEnumerable<MachineInventory>> GetMachineInventoriesByMachineIdAsync(string machineId);
        Task<MachineInventory> GetProductByMachineInventoryIdAndProductId(string machineId, string productId);
        Task<bool> Update(MachineInventory machineInventory);
    }
}
