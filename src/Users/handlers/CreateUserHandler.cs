using Departament.src.Commands.Requests;
using Departament.src.Commands.Responses;
using MediatR;

namespace Departament.src.commands.handlers
{
    public class CreateUserHandler :
    IRequestHandler<CreateUserRequest, CreateUserResponse>
    {
        public Task<CreateUserResponse> Handle(CreateUserRequest request, CancellationToken cancellationToken)
        {
            string name = request.Name;
            string password = request.Password;

            // Verificar se o cliente já está cadastrado
            // hash da senha
            // validar os dados
            // inserir o User

            var result = new CreateUserResponse
            {
                id = Guid.NewGuid(),
                Name = name,
                Password = password
            };

            return Task.FromResult(result);

            //  throw new NotImplementedException();
        }
    }
}