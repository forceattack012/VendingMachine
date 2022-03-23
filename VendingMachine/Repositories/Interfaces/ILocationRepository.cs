using VendingMachine.Entities;

namespace VendingMachine.Repositories.Interfaces
{
    public interface ILocationRepository
    {
        public Task<IEnumerable<Location>> GetLocationsAsync();
        public Task<Location> GetLocationById(string id);
        public Task<IEnumerable<Location>> GetLocationWithMachine();
    }
}
