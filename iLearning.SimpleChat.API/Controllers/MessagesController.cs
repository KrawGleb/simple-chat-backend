using iLearning.SimpleChat.API.Hubs;
using iLearning.SimpleChat.Application.Messages.Commands;
using iLearning.SimpleChat.Application.Messages.Queries;
using iLearning.SimpleChat.Application.Users.Queries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace iLearning.SimpleChat.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MessagesController : ApiBaseController
{
    private readonly IHubContext<AppHub> _hub;

    public MessagesController(IHubContext<AppHub> hub)
    {
        _hub = hub;
    }

    [HttpGet("{userName}")]
    public async Task<IActionResult> GetAllUserMessages([FromRoute] string userName)
    {
        return Ok(await Mediator.Send(new GetAllUserMessagesQuery { UserName = userName }));
    }

    [HttpPost]
    public async Task<IActionResult> SendMessage([FromBody] SendMessageCommand command)
    {
        await Mediator.Send(command);
        await _hub.Clients.All.SendAsync("NewMessage", command.Message.To.Name);

        return Ok();
    }
}
