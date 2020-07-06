using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pizzeria.Models;

namespace Pizzeria.Controllers
{
    public class OrdenController : Controller
    {
        OrdenModel Orden = new OrdenModel();
        public IActionResult Index()
        {
            return View();
        }

        public double CalcularOrden()
        {
            return Orden.CalcularTotal();
        }
    }
}