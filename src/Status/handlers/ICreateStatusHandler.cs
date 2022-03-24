using Departament.src.Status.Requests;
using Departament.src.Status.Responses;

namespace Departament.src.Status.handlers
{
    public interface ICreateStatusHandler
    {
        public CreateStatusResponse Handle(CreateStatusRequest request);
    }
}