using Microsoft.EntityFrameworkCore;
using VendingMachine.Data;
using VendingMachine.Entities;
using VendingMachine.Repositories.Interfaces;

namespace VendingMachine.Repositories
{
    public class MachineRepository : IMachineRepository
    {
        private readonly VendingMachineContext _vendingMachineContext;

        public MachineRepository(VendingMachineContext vendingMachineContext)
        {
            _vendingMachineContext = vendingMachineContext;
        }

        public async Task<IEnumerable<Machine>> FindMachineInLocationId(string locationId)
        {
            return await _vendingMachineContext.Machines.Where(r => r.LocationId == locationId)
                    .Include(r => r.Location).ToListAsync();
        }

        public async Task<IEnumerable<Machine>> GetMachinesAsync()
        {
            return await _vendingMachineContext.Machines
                    .Include(r => r.Location)
                    .ToListAsync();
        }
    }
}
