using Departament.src.CriminalCode.Requests;
using Departament.src.CriminalCode.Responses;
using MediatR;
using Models.Departament;

namespace Departament.src.CriminalCode.handlers
{
    public class CreateStatusHandler :
    IRequestHandler<CreateCriminalCodeRequest, CreateCriminalCodeResponse>
    {
        public Task<CreateCriminalCodeResponse> Handle(CreateCriminalCodeRequest request, CancellationToken cancellationToken)
        {
            string name = request.Name;
            string description = request.Description;
            decimal Penalty = request.Penalty;
            int prisonTime = request.PrisonTime;
            int statusId = request.StatusId;

            // Verificar se o já existe o CriminalCode Se o usuario é autentificado
            // validar os dados
            // inserir o Status

            var result = new CreateCriminalCodeResponse
            {
                id = Guid.NewGuid(),
                Name = name,
            };

            return Task.FromResult(result);

        }
    }
}