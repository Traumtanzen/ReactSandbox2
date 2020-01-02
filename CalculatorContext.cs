using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactSandbox2
{
    public class CalculatorContext : DbContext
    {
        public DbSet<CalculationData> LogFile { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DELL-SERGEY;Database=CalculatorLogs;Integrated Security=True;");
        }
    }
}
