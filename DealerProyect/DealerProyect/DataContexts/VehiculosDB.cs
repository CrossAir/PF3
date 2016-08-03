using VehiculosEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DealerProyect.DataContexts
{
    public class VehiculosDB : DbContext
    {
        public VehiculosDB()
            : base("DefaultConnection")
        {
        }
        public DbSet<Vehiculos> Vehiculos { get; set; }
    }
}