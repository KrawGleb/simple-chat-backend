using iLearning.SimpleChat.Domain.Entities;
using iLearning.SimpleChat.Infrastructure.Persistence.Repositories.Interfaces;

namespace iLearning.SimpleChat.Infrastructure.Persistence.Repositories;

public class UsersRepository : EFRepository<User>, IUsersRepository
{
    public UsersRepository(ApplicationDbContext context) : base(context)
    { }
}
