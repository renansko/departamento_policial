using MediatR;
using Departament.src.Commands.Responses;

namespace Departament.src.Commands.Requests
{
    public class CreateUserRequest : IRequest<CreateUserResponse>
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
}