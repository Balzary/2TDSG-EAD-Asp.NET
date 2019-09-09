using _06_Fiap.Web.AspNet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Fiap.Web.AspNet.Persistence
{
    public class AllCorridaContext : DbContext
    {
        public DbSet<Corrida> Corridas { get; set; }
        //construtor ctor tab tab
        public AllCorridaContext(DbContextOptions op) : base(op)
        {

        }
    }
}
