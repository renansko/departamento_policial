namespace Departament.src.CriminalCode.Responses
{
    public class CreateCriminalCodeResponse
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Penalty { get; set; }
        public int PrisonTime { get; set; }
        public int StatusId { get; set; }
        public int CreateUserId { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime created_at { get; set; }
    }

    public class CriminalCodeComplete
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Penalty { get; set; }
        public int PrisonTime { get; set; }
        public int StatusId { get; set; }
        public int CreatedUserId { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

    }

    public class DeleteCriminalCodeResponse
    {
        public Guid id { get; set; }
        public string Name { get; set; }
    }
}