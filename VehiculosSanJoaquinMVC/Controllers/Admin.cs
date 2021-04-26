using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehiculosSanJoaquinMVC.Controllers
{
    public class Admin : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
