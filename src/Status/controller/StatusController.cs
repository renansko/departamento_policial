using Microsoft.AspNetCore.Mvc;
using Departament.src.Status.handlers;
using Departament.src.Status.Responses;
using Departament.src.Status.Requests;

namespace Departament.scr.Status.Controller
{
    [ApiController]
    [Route("departament/Status")]
    public class statusController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public CreateStatusResponse Create(
            [FromServices] ICreateStatusHandler handler,
            [FromBody] CreateStatusRequest command)
        {
            return handler.Handle(command);
        }
    }
}