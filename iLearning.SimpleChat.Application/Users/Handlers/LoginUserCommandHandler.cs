using iLearning.SimpleChat.Application.Users.Commands;
using iLearning.SimpleChat.Domain.Entities;
using iLearning.SimpleChat.Infrastructure.Persistence.Repositories.Interfaces;
using MediatR;
using System.Runtime.InteropServices;

namespace iLearning.SimpleChat.Application.Users.Handlers;

public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, User>
{
    private readonly IUsersRepository _repository;

    public LoginUserCommandHandler(IUsersRepository repository)
    {
        _repository = repository;
    }

    public async Task<User> Handle(LoginUserCommand request, CancellationToken cancellationToken)
    {
        var existringUser = await _repository.GetUserByNameAsync(request.Name);

        if (existringUser is not null)
        {
            return existringUser;
        }

        var user = new User
        {
            Name = request.Name
        };

        await _repository.CreateAsync(user);

        return user;
    }
}
