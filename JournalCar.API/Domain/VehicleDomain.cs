using JournalCar.API.Model.DTOs;

namespace JournalCar.API.Domain
{
    public class VehicleDomain : IVehicleDomain
    {
        public Task<VehicleDTO> CreateDTOAsync(VehicleAddRequestDTO vehicle)
        {
            throw new NotImplementedException();
        }

        public Task<VehicleDTO?> DeleteDTOAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<VehicleDTO>> GetAllDTOAsync(Guid idOwner)
        {
            throw new NotImplementedException();
        }

        public Task<VehicleDTO?> GetByIdDTOAsync(Guid idVehicle)
        {
            throw new NotImplementedException();
        }

        public Task<VehicleDTO?> UpdateDTOAsync(Guid id, VehicleUpdateRequestDTO vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
