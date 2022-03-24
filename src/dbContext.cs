using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; // funcionalidades para textos
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models.Departament;

namespace Departament
{

    public class DepartmentContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Stats> Status { get; set; }
        public DbSet<CriminalCode> CriminalCodes { get; set; }

        public string DbPath { get; }

        public DepartmentContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "Department.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }

}