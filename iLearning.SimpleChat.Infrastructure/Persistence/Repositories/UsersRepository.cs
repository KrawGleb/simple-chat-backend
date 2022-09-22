using iLearning.SimpleChat.Domain.Entities;
using iLearning.SimpleChat.Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace iLearning.SimpleChat.Infrastructure.Persistence.Repositories;

public class UsersRepository : EFRepository<User>, IUsersRepository
{
    public UsersRepository(ApplicationDbContext context) : base(context)
    { }

    public async Task<User?> GetUserByNameAsync(string name)
    {
        return await _table.FirstOrDefaultAsync(u => u.Name.ToLower() == name.ToLower());
    }
}
