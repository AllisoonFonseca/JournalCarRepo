using JournalCar.API.Data;
using JournalCar.API.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace JournalCar.API.Repository.Vehicles
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly JournalCarDbContext dbContext;

        public VehicleRepository(JournalCarDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Vehicle?> DeleteAsync(Guid id)
        {
            var existingVehicle = await dbContext.Vehicle.FirstOrDefaultAsync(x => x.Id == id);
            if (existingVehicle  == null) { return null; }
            dbContext.Vehicle.Remove(existingVehicle);
            await dbContext.SaveChangesAsync();
            return existingVehicle;
        }

        public async Task<List<Vehicle>> GetAllAsync(Guid idOwner)
        {

            var result = await dbContext.Vehicle.Where(x => x.UserId == idOwner).ToListAsync();
            
            return result;
        }

        public Task<Vehicle?> GetSingleAsync(Guid id)
        {
            return dbContext.Vehicle.FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task<Vehicle> CreateAsync(Vehicle vehicle)
        {
            await dbContext.Vehicle.AddAsync(vehicle);
            await dbContext.SaveChangesAsync();
            return vehicle;
        }

        public Task<Vehicle?> UpdateAsync(Guid id, Vehicle vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
