using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class FinderDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=DESKTOP-65LNMFM\\SQLEXPRESS01; database=FinderDb; integrated security=true; TrustServerCertificate=True");
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Home> Homes { get; set; }
    }
}
