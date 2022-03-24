using Departament.src.Commands.Requests;
using Departament.src.Commands.Responses;

namespace Departament.src.commands.handlers
{
    public interface ICreateUserHandler
    {
        public CreateUserResponse Handle(CreateUserRequest request);
    }
}