using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetdocker
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:noyaxsrv.database.windows.net,1433;Database=noyaxdb;User ID=elronsa;Password=@lr0nsa!;Encrypt=true;Connection Timeout=30;");
        }

        public DbSet<Messages> Messages { get; set; }
    }
}
