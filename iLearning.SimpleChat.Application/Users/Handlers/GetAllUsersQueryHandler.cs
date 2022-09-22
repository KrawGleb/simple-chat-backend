using iLearning.SimpleChat.Application.Users.Queries;
using iLearning.SimpleChat.Domain.Entities;
using iLearning.SimpleChat.Infrastructure.Persistence.Repositories.Interfaces;
using MediatR;

namespace iLearning.SimpleChat.Application.Users.Handlers;

public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, IEnumerable<User>>
{
    private readonly IUsersRepository _repository;

    public GetAllUsersQueryHandler(IUsersRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<User>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetAllAsync();
    }
}
