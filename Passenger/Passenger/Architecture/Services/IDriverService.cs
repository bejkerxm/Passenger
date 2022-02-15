using Infrastructure.DTO;

namespace Infrastructure.Services
{
    public interface IDriverService
    {
        DriverDTO Get(Guid userId);
    }
}