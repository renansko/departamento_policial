using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Departament;
using Microsoft.EntityFrameworkCore;
namespace Models.Departament
{
    public partial class User
    {

        [Key()]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public List<CriminalCode> CriminalCodes { get; } = new();
        public void Salvar()
        {
            var db = new DepartmentContext();
            db.Users.Add(this);
            db.SaveChanges();
        }

        public static List<User> Todos()
        {
            var db = new DepartmentContext();
            return db.Users.ToList();
        }
    }


}
