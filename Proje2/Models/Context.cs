using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje2.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-5PH0MPI\\SQLEXPRESS; database=satproje2; integrated security=true;");
        }

        public DbSet<Birim> Birims { get; set; }
        public DbSet<personel> Personels { get; set; }

        public DbSet<Admin> Admins { get; set; }
    }
}
