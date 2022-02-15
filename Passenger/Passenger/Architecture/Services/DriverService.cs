using Core.Repositories;
using Infrastructure.DTO;

namespace Infrastructure.Services
{
    public class DriverService : IDriverService
    {
        private IDriverRepository _driverRepository;

        public DriverService(IDriverRepository driverRepository)
        {
            _driverRepository = driverRepository;
        }

        public DriverDTO Get(Guid userId)
        {
            var driver = _driverRepository.Get(userId);
            return new DriverDTO
            {
              //  Id = userId,    
            };
        }
    }
}