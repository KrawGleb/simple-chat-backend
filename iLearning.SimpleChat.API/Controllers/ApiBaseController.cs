﻿using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace iLearning.SimpleChat.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ApiBaseController : ControllerBase
{
    private ISender? _mediator;

    protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();
}
