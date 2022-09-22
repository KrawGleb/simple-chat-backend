using iLearning.SimpleChat.Domain.Entities;
using MediatR;

namespace iLearning.SimpleChat.Application.Messages.Commands;

public class SendMessageCommand : IRequest
{
    public Message Message { get; set; }
}
