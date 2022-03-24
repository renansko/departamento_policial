using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; // funcionalidades para textos
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Departament;

namespace Models.Departament
{
    public partial class CriminalCode
    {
        [Key()]
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Penalty { get; set; }
        public int PrisonTime { get; set; }
        [ForeignKey("Status")]
        public int StatusId { get; set; }
        public DateTime created_at { get { return DateTime.Now; } }
        public DateTime updated_at { get; set; }

        [ForeignKey("Users")]
        public int CreateUserId { get; set; }

        [ForeignKey("Users")]
        public int UpdateUserId { get; set; }
        public virtual Stats Status { get; set; }
        public virtual User User { get; set; }

        public void Add(CriminalCode criminalCode)
        {
            var db = new DepartmentContext();
            db.CriminalCodes.Add(this);
            db.SaveChanges();
        }
        public List<CriminalCode> GetCriminalCodeById(int id)
        {
            var db = new DepartmentContext();
            List<CriminalCode> criminalCodes = db.CriminalCodes.Where(c => c.id.Equals(id)).ToList();
            return criminalCodes;
        }
        public void Updated(CriminalCode criminalCode)
        {
            var db = new DepartmentContext();
            var dbUser = new User(); // usar o usuario logado e autentificado aqui

            var CriminalObj = db.CriminalCodes.Where(c => c.id == criminalCode.id).FirstOrDefault();
            CriminalObj.updated_at = DateTime.Now;
            CriminalObj.UpdateUserId = dbUser.Id;
            db.SaveChanges();
        }
        public void Deleted(CriminalCode criminalCode)
        {
            var db = new DepartmentContext();

            var deletedCriminalCode = db.CriminalCodes.Where(c => c.id == id).FirstOrDefault();
            db.CriminalCodes.Remove(deletedCriminalCode);
            db.SaveChanges();
        }

    }

}