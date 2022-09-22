using iLearning.SimpleChat.Domain.Entities;

namespace iLearning.SimpleChat.Infrastructure.Persistence.Repositories.Interfaces;

public interface IUsersRepository : IEFRepository<User>
{
    Task<User?> GetUserByNameAsync(string name);
}
