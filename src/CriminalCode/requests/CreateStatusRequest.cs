using MediatR;
using Departament.src.CriminalCode.Responses;

namespace Departament.src.CriminalCode.Requests
{
    public class CreateCriminalCodeRequest : IRequest<CreateCriminalCodeResponse>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Penalty { get; set; }
        public int PrisonTime { get; set; }
        public int StatusId { get; set; }
        public int CreateUserId { get; set; }

    }

    public class DeleteCriminalCodeRequest : IRequest<DeleteCriminalCodeResponse>
    {
        public string id { get; set; }
    }

    public class EditCriminalCodeRequest : IRequest<CriminalCodeComplete>
    {
        public string id { get; set; }
        public string userId { get; set; }
    }

    public class ViewCriminalCodeWithIdRequest : IRequest<CriminalCodeComplete>
    {
        public string id { get; set; }
    }
}