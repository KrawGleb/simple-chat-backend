using iLearning.SimpleChat.Domain.Entities;
using MediatR;

namespace iLearning.SimpleChat.Application.Messages.Queries;

public class GetAllUserMessagesQuery : IRequest<IEnumerable<Message>>
{
    public string UserName { get; set; }
}
