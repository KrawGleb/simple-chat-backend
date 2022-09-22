using iLearning.SimpleChat.Domain.Entities;
using MediatR;

namespace iLearning.SimpleChat.Application.Users.Commands;

public class LoginUserCommand : IRequest<User>
{
    public string? Name { get; set; }
}
