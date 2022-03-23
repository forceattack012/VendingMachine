using VendingMachine.Entities;

namespace VendingMachine.Repositories.Interfaces
{
    public interface IMachineRepository
    {
        Task<IEnumerable<Machine>> FindMachineInLocationId(string locationId);
    }
}
