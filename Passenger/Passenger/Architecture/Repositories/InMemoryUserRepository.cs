using Core.Domain;
using Core.Repositories;

namespace Infrastructure.Repositories
{
    public class InMemoryUserRepository : IUserRepository
    {
        private static ISet<User> _users = new HashSet<User>()
        {
            new User("user1@gmail.com", "Karol", "secret","salt"),
            new User("user2@gmail.com", "Karol2", "secret","salt"),
            new User("user2@gmail.com", "Karol3", "secret","salt"),
        };

        public void Add(User user)
        {
            _users.Add(user);
        }

        public User Get(Guid Id)

            => _users.Single(x => x.Id == Id);

        public User Get(string email)

            => _users.Single(x => x.Email == email.ToLowerInvariant());

        public IEnumerable<User> GetAll()

           => _users;

        public void Remove(Guid id)
        {
            var user = Get(id);
            _users.Remove(user);
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}