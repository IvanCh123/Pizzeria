using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzeria.Controllers;
using Pizzeria.Helpers;
using System.Web;
using System;
using System.Collections.Generic;

namespace Pizzeria.Pages.Ordenar
{
    public class OrdenarModel : PageModel
    {
        OrdenController Orden = new OrdenController();

        public double MontoTotal { get; set; }
        public List<Cobertura> Pizza { get; set; }


        public void OnGet(){}

        public IActionResult OnPostOrden()
        {
            //fetch los datos de la vista

            string tamaño = Request.Form["tamaño"];
            string[] coberturas = Request.Form["cobertura"].ToString().Split(',');

            Orden.EstablecerTamaño(tamaño);
            Orden.EstablecerCoberturas(coberturas);



            Pizza = Orden.RetornarPizza();
            MontoTotal = Orden.CalcularOrden();

            return Page();
        }
    }
}