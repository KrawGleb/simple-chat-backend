using iLearning.SimpleChat.Domain.Entities;
using iLearning.SimpleChat.Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace iLearning.SimpleChat.Infrastructure.Persistence.Repositories;

public class MessagesRepository : EFRepository<Message>, IMessagesRepository
{
    public MessagesRepository(ApplicationDbContext context) : base(context)
    { }

    public async Task<IEnumerable<Message>> GetUserMessagesAsync(string toUser)
    {
        return await _table
            .Include(m => m.From)
            .Include(m => m.To)
            .Where(m => m.To.Name == toUser)
            .ToListAsync();
    }
}
