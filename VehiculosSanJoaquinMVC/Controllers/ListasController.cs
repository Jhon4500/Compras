using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehiculosSanJoaquinMVC.Models.Abstract;
using VehiculosSanJoaquinMVC.Models.Entities;

namespace VehiculosSanJoaquinMVC.Controllers
{
    public class ListasController : Controller
    {
        // llamar la clase 

        private readonly IListasBusiness _listaBusiness;

        public ListasController(IListasBusiness listasBusiness)
        {
            _listaBusiness = listasBusiness;
        }
        public async Task <IActionResult> Index()
        {

            // llamar el metodo de la lista 

            var lista = await _listaBusiness.ObtenerListas();


            return View(lista);
        }

        public IActionResult CrearListas()
        {
            return View();
        }


       [HttpPost]
        public async Task<IActionResult> CrearListas(Listas listas )
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _listaBusiness.CrearListas(listas);
                    return Json(new { data = "Datos Correctos" });
                }
                catch (Exception) 
                {
                    return Json(new { data = "Error Datos" });
                }
            }
           return Json(new { data = "Error Datos" });
        }
    }
}
