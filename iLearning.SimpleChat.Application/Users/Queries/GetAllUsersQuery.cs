using iLearning.SimpleChat.Domain.Entities;
using MediatR;

namespace iLearning.SimpleChat.Application.Users.Queries;

public class GetAllUsersQuery : IRequest<IEnumerable<User>>
{ }
