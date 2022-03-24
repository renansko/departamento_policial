using Departament.src.Commands.Responses;
using Microsoft.AspNetCore.Mvc;
using Departament.src.Commands.Requests;
using Departament.src.commands.handlers;

namespace Departament.scr.Commands.Controller
{
    [ApiController]
    [Route("departament/User")]
    public class userController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public CreateUserResponse Create(
            [FromServices] ICreateUserHandler handler,
            [FromBody] CreateUserRequest command)
        {
            return handler.Handle(command);
        }
    }
}