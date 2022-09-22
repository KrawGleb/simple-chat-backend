using iLearning.SimpleChat.Domain.Entities;

namespace iLearning.SimpleChat.Infrastructure.Persistence.Repositories.Interfaces;

public interface IMessagesRepository : IEFRepository<Message>
{
    Task<IEnumerable<Message>> GetUserMessagesAsync(string toUser);
}
