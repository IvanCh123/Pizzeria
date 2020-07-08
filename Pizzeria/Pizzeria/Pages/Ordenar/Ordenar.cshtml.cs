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

        public void OnGet(){}

        public IActionResult OnPostOrdenar()
        {
            string tamaño = Request.Form["tamaño"];
            string[] coberturas = Request.Form["cobertura"].ToString().Split(',');

            Orden.EstablecerTamaño(tamaño);
            Orden.EstablecerCoberturas(coberturas);

            double MontoTotal = Orden.CalcularOrden();

            return RedirectToPage("FinalizarOrden", new { PrecioOrden = MontoTotal.ToString() });
        }
    }
}