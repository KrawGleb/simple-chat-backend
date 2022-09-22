using iLearning.SimpleChat.Application.Messages.Commands;
using iLearning.SimpleChat.Infrastructure.Persistence.Repositories.Interfaces;
using MediatR;

namespace iLearning.SimpleChat.Application.Messages.Handlers;

public class SendMessageCommandHandler : IRequestHandler<SendMessageCommand>
{
    private readonly IMessagesRepository _messagesRepository;
    private readonly IUsersRepository _usersRepository;

    public SendMessageCommandHandler(
        IMessagesRepository messagesRepository,
        IUsersRepository usersRepository)
    {
        _messagesRepository = messagesRepository;
        _usersRepository = usersRepository;
    }

    public async Task<Unit> Handle(SendMessageCommand request, CancellationToken cancellationToken)
    {
        var from = await _usersRepository.GetUserByNameAsync(request.Message.From.Name);
        var to = await _usersRepository.GetUserByNameAsync(request.Message.To.Name);

        if (from is null || to is null)
        {
            // ToDo: Custom exception
            throw new InvalidOperationException();
        }

        request.Message.From = from;
        request.Message.To = to;

        await _messagesRepository.CreateAsync(request.Message);

        return Unit.Value;
    }
}
