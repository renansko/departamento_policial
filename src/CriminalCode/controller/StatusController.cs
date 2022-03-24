using Microsoft.AspNetCore.Mvc;
using Departament.src.CriminalCode.handlers;
using Departament.src.CriminalCode.Responses;
using Departament.src.CriminalCode.Requests;

namespace Departament.scr.CriminalCode.Controller
{
    [ApiController]
    [Route("departament/CriminalCode")]
    public class CriminalCodeController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public CreateCriminalCodeResponse Add(
            [FromServices] ICriminalCodeHandler handler,
            [FromBody] CreateCriminalCodeRequest command)
        {
            return handler.Handle(command);
        }

        public CriminalCodeComplete Updated(
            [FromServices] ICriminalCodeHandler handler,
            [FromBody] EditCriminalCodeRequest command)
        {
            return handler.Handle(command);
        }

        public DeleteCriminalCodeResponse Deleted(
            [FromServices] ICriminalCodeHandler handler,
            [FromBody] DeleteCriminalCodeRequest command)
        {
            return handler.Handle(command);
        }

        public CriminalCodeComplete GetCriminalCodeById(
        [FromServices] ICriminalCodeHandler handler,
        [FromBody] ViewCriminalCodeWithIdRequest command)
        {
            return handler.Handle(command);
        }

    }
}