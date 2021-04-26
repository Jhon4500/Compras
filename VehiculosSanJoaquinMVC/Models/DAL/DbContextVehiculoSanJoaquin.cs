using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehiculosSanJoaquinMVC.Models.Entities;

namespace VehiculosSanJoaquinMVC.Models.DAL
{
    public class DbContextVehiculoSanJoaquin : DbContext
    {
        public DbContextVehiculoSanJoaquin(DbContextOptions<DbContextVehiculoSanJoaquin> options) : base(options)
        {

        }

        // llamo la clase para crear las tablas en la base de datos 
        public DbSet<ListasDetalle> ListasDetalle { get; set; }

        public DbSet<Listas> Listas { get; set; }


        // public DbSet<Terceros> Terceros  { get; set; }

        //public DbSet<Vehiculos> Vehiculos { get; set; }

        // public DbSet<TercerosDirecciones> tercerosDirecciones { get; set; }


        public DbSet<Cliente> cliente { get; set; }
    }
}
