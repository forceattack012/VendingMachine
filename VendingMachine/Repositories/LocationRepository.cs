using Microsoft.EntityFrameworkCore;
using VendingMachine.Data.Interfaces;
using VendingMachine.Entities;
using VendingMachine.Repositories.Interfaces;

namespace VendingMachine.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private readonly IVendingMachineContext _vendingMachineContext;

        public LocationRepository(IVendingMachineContext vendingMachineContext)
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
