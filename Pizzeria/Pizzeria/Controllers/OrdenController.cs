using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pizzeria.Helpers;
using Pizzeria.Models;

namespace Pizzeria.Controllers
{
    public class OrdenController : Controller
    {
        OrdenModel Orden = new OrdenModel();

        public void EstablecerTamaño(string tamaño)
        {
            Orden.EstablecerTamaño(tamaño);
        }

        public void EstablecerCoberturas(string[] coberturas)
        {
            Orden.EstablecerCoberturas(coberturas);
        }

        public List<Cobertura> RetornarPizza()
        {
            return Orden.RetornarPizza();
        }

        public double CalcularOrden()
        {
            return Orden.CalcularTotal();
        }
    }
}