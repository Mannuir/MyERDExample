using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeFirstN2idis.DataModels
{
   public class Context: DbContext

    {
        DbSet<Employee> Employeess { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(@"Server=(localdb)\\MSSQLLocalDB;Database=EFEasyExample;Trusted_Connection=True;");
          
        }
        
    }
}
