using Core.Domain;
using Core.Repositories;

namespace Infrastructure.Repositories
{
    public class InMemoryDriverRepositry : IDriverRepository
    {
        private static ISet<Driver> _drivers = new HashSet<Driver>();

        public void Add(Driver driver)
        {
            _drivers.Add(driver);
        }

        public Driver Get(Guid userId)

            => _drivers.Single(x => x.UserId == userId);

        public IEnumerable<Driver> GetAll()

            => _drivers;

        public void Update(Driver driver)
        {
            throw new NotImplementedException();
        }
    }
}