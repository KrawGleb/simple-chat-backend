using iLearning.SimpleChat.Application.Messages.Commands;
using iLearning.SimpleChat.Application.Messages.Queries;
using iLearning.SimpleChat.Application.Users.Queries;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace iLearning.SimpleChat.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MessagesController : ApiBaseController
{
    [HttpGet("{userName}")]
    public async Task<IActionResult> GetAllUserMessages([FromRoute] string userName)
    {
        return Ok(await Mediator.Send(new GetAllUserMessagesQuery { UserName = userName }));
    }

    [HttpPost]
    public async Task<IActionResult> SendMessage([FromBody] SendMessageCommand command)
    {
        return Ok(await Mediator.Send(command));
    }
}
