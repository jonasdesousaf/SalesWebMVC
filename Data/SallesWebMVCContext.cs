using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Models;

    public class SallesWebMVCContext : DbContext
    {
        public SallesWebMVCContext (DbContextOptions<SallesWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMVC.Models.Departament> Departament { get; set; }
    }
