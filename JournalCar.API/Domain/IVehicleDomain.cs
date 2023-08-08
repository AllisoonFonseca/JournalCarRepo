using JournalCar.API.Model.DTOs;

namespace JournalCar.API.Domain
{
    public interface IVehicleDomain
    {
        Task<List<VehicleDTO>> GetAllDTOAsync(Guid idOwner);
        Task<VehicleDTO?> GetByIdDTOAsync(Guid idVehicle);
        Task<VehicleDTO> CreateDTOAsync(VehicleAddRequestDTO vehicle);
        Task<VehicleDTO?> DeleteDTOAsync(Guid id);
        Task<VehicleDTO?> UpdateDTOAsync(Guid id, VehicleUpdateRequestDTO vehicle);
    }
}
