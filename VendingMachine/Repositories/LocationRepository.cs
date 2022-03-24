using Microsoft.EntityFrameworkCore;
using VendingMachine.Data;
using VendingMachine.Entities;
using VendingMachine.Repositories.Interfaces;

namespace VendingMachine.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private readonly VendingMachineContext _vendingMachineContext;

        public LocationRepository(VendingMachineContext vendingMachineContext)
        {
            _vendingMachineContext = vendingMachineContext;
        }

        public async Task<Location> GetLocationById(string id)
        {
            return await _vendingMachineContext.Locations.Where(location => location.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Location>> GetLocationsAsync()
        {
            return await _vendingMachineContext.Locations.ToListAsync();
        }

        public async Task<IEnumerable<Location>> GetLocationWithMachine()
        {
            return await _vendingMachineContext.Locations.Include(location => location.Machines).ToListAsync();
        }
    }
}
