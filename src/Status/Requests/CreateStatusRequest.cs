using MediatR;
using Departament.src.Status.Responses;

namespace Departament.src.Status.Requests
{
    public class CreateStatusRequest : IRequest<CreateStatusResponse>
    {
        public string Name { get; set; }
    }
}