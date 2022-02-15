using Core.Domain;

namespace Infrastructure.DTO
{
    /// <summary>
    /// Kazdy element tutaj musi miec swojego DTO - nie przekazywac modeli domenowych
    /// </summary>
    public class DriverDTO
    {
        public Guid Id { get; set; }
        public Vehicle Vehicle { get; set; }
        public IEnumerable<Route> Routes { get; set; }
        public IEnumerable<DailyRoute> DailyRoutes { get; set; }
    }
}