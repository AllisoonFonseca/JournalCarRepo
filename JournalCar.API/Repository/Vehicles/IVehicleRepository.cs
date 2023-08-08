using JournalCar.API.Model.Domain;

namespace JournalCar.API.Repository.Vehicles
{
    public interface IVehicleRepository
    {
        Task<List<Vehicle>> GetAllAsync(Guid idOwner);
        Task<Vehicle?> GetSingleAsync(Guid id);
        Task<Vehicle> CreateAsync(Vehicle vehicle);
        Task<Vehicle?> UpdateAsync(Guid id, Vehicle vehicle);
        Task<Vehicle?> DeleteAsync(Guid id);
    }
}
