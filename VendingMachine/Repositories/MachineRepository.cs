using Microsoft.EntityFrameworkCore;
using VendingMachine.Data.Interfaces;
using VendingMachine.Entities;
using VendingMachine.Repositories.Interfaces;

namespace VendingMachine.Repositories
{
    public class MachineRepository : IMachineRepository
    {
        private readonly IVendingMachineContext _vendingMachineContext;

        public MachineRepository(IVendingMachineContext vendingMachineContext)
        {
            _vendingMachineContext = vendingMachineContext;
        }

        public async Task<IEnumerable<Machine>> FindMachineInLocationId(string locationId)
        {
            return await _vendingMachineContext.Machines.Where(r => r.LocationId == locationId)
                    .Include(r => r.Location).ToListAsync();
        }
    }
}
