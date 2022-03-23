﻿using VendingMachine.Entities;

namespace VendingMachine.Repositories.Interfaces
{
    public interface IMachineInventoryRepository
    {
        Task<IEnumerable<MachineInventory>> GetMachineInventoriesAsync();
        Task<IEnumerable<MachineInventory>> GetMachineInventoriesByMachineIdAsync(string machineId);
    }
}
