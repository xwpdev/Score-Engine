using Microsoft.EntityFrameworkCore;
using ScoreEngine.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoreEngine.API.Data
{
    public class ScoreEngineContext : DbContext
    {
        public DbSet<Result> Results { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // _ = optionsBuilder.UseSqlServer("Data Source=DESKTOP-91ERRPG\\SQLEXPRESS;Initial Catalog=ScoreEngineDb;Integrated Security=SSPI;");
            _ = optionsBuilder.UseSqlServer("Data Source=den1.mssql7.gear.host;Initial Catalog=scoreenginedb;User Id=scoreenginedb;Password=Aw587w?-1R3J");
        }
    }
}
