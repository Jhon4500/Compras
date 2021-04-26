using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehiculosSanJoaquinMVC.Models.Entities;

namespace VehiculosSanJoaquinMVC.Models.Abstract
{
    public interface IListasBusiness 
    {
        // para mostrar las listas creadas en la base de datos
        Task<IEnumerable<Listas>> ObtenerListas();

        // para crear una nueva lista 
        Task CrearListas(Listas listas);
    }
}
