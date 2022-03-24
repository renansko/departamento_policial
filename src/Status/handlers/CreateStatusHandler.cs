using Departament.src.Status.Requests;
using Departament.src.Status.Responses;
using MediatR;

namespace Departament.src.Status.handlers
{
    public class CreateStatusHandler :
    IRequestHandler<CreateStatusRequest, CreateStatusResponse>
    {
        public Task<CreateStatusResponse> Handle(CreateStatusRequest request, CancellationToken cancellationToken)
        {
            string name = request.Name;

            // Verificar se o já existe o status
            // validar os dados
            // inserir o Status

            var result = new CreateStatusResponse
            {
                id = Guid.NewGuid(),
                Name = name,
            };

            return Task.FromResult(result);

        }
    }
}