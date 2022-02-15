namespace Core.Domain
{
    /// <summary>
    /// Agregate root - posiada w sobie modele i samo w sobie stanowi wartosc - reprezentuje rzeczywisty byt
    /// </summary>
    public class Driver
    {
        public Guid UserId { get; protected set; }
        public Vehicle Vehicle { get; protected set; }
        public IEnumerable<Route> Routes { get; protected set; }
        public IEnumerable<DailyRoute> DailyRoutes { get; protected set; }

        protected Driver()
        {
        }

        public Driver(Guid userId)
        {
            UserId = userId;
        }
    }
}