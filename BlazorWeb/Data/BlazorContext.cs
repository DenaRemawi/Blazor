using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWeb.Data
{
    public class BlazorContext : DbContext
    {
      
            public DbSet<Contact> Contants { set; get; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("data source=DENA\\MSSQLSERVER01; initial catalog=BlazorWeb; integrated security=true ");
                base.OnConfiguring(optionsBuilder);
            }

       }
    
}

