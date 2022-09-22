using iLearning.SimpleChat.Application.Messages.Queries;
using iLearning.SimpleChat.Domain.Entities;
using iLearning.SimpleChat.Infrastructure.Persistence.Repositories.Interfaces;
using MediatR;

namespace iLearning.SimpleChat.Application.Messages.Handlers;

public class GetAllUserMessagesQueryHandler : IRequestHandler<GetAllUserMessagesQuery, IEnumerable<Message>>
{
    private readonly IMessagesRepository _repository;

    public GetAllUserMessagesQueryHandler(IMessagesRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Message>> Handle(GetAllUserMessagesQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetUserMessagesAsync(request.UserName);
    }
}
