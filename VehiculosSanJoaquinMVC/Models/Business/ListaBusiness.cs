using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehiculosSanJoaquinMVC.Models.Abstract;
using VehiculosSanJoaquinMVC.Models.DAL;
using VehiculosSanJoaquinMVC.Models.Entities;

namespace VehiculosSanJoaquinMVC.Models.Services
{
    public class ListaBusiness : IListasBusiness
    {
        // clase se conecta con el ontexto DBContext

        private readonly DbContextVehiculoSanJoaquin _context;

        public ListaBusiness(DbContextVehiculoSanJoaquin context)
        {
            //inyeccion 
            _context = context;
        }
        // Crear metodo para listar 

        public async Task<IEnumerable<Listas>> ObtenerListas()
        {
            return await _context.Listas.ToListAsync();


        }

        //Crear la lista 
       public async Task CrearListas(Listas listas)
        {
          _context.Add(listas);
            await _context.SaveChangesAsync();
        }
        



    }
}
