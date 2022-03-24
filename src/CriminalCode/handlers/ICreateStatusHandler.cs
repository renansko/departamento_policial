using Departament.src.CriminalCode.Requests;
using Departament.src.CriminalCode.Responses;
using Departament;

namespace Departament.src.CriminalCode.handlers
{
    public interface ICriminalCodeHandler
    {
        public CreateCriminalCodeResponse Handle(CreateCriminalCodeRequest request);
        public CriminalCodeComplete Handle(EditCriminalCodeRequest request);
        public DeleteCriminalCodeResponse Handle(DeleteCriminalCodeRequest request);
        public CriminalCodeComplete Handle(ViewCriminalCodeWithIdRequest request);

    }
}