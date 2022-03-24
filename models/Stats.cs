using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; // funcionalidades para textos
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Departament;

namespace Models.Departament
{
    public class Stats
    {
        [Key()]
        public int id { get; set; }
        public string Name { get; set; }
        public List<CriminalCode> CriminalCodes { get; } = new();
        public void Salvar()
        {
            var db = new DepartmentContext();
            db.Status.Add(this);
            db.SaveChanges();
        }
        public static List<Stats> Todos()
        {
            var db = new DepartmentContext();
            return db.Status.ToList();
        }
    }
}