using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzeria.Controllers;

namespace Pizzeria.Pages.Ordenar
{
    public class OrdenarModel : PageModel
    {
        OrdenController Orden = new OrdenController();

        public double MontoTotal { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPostOrden() {
            //fetch los datos de la vista


            MontoTotal = Orden.CalcularOrden();

            return Page();
        }
    }
}