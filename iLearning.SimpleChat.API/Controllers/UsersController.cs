using iLearning.SimpleChat.Application.Users.Commands;
using iLearning.SimpleChat.Application.Users.Queries;
using Microsoft.AspNetCore.Mvc;

namespace iLearning.SimpleChat.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ApiBaseController
{
    [HttpGet]
    public async Task<IActionResult> GetAllUsers()
    {
        return Ok(await Mediator.Send(new GetAllUsersQuery()));
    }

    [HttpPost]
    public async Task<IActionResult> LoginUser([FromBody] LoginUserCommand command)
    {
        return Ok(await Mediator.Send(command));
    }
}
