using Core.Domain;

namespace Core.Repositories
{
    /// <summary>
    /// Interfejs pobierania uzytkownika - CQS
    /// </summary>
    public interface IUserRepository
    {
        User Get(Guid Id);

        User Get(string email);

        IEnumerable<User> GetAll();

        void Add(User user);

        void Remove(Guid id);

        void Update(User user);
    }
}