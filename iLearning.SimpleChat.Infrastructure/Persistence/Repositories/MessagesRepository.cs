using iLearning.SimpleChat.Domain.Entities;
using iLearning.SimpleChat.Infrastructure.Persistence.Repositories.Interfaces;

namespace iLearning.SimpleChat.Infrastructure.Persistence.Repositories;

public class MessagesRepository : EFRepository<Message>, IMessagesRepository
{
    public MessagesRepository(ApplicationDbContext context) : base(context)
    { }
}
