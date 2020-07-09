using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pizzeria.Pages.Ordenar
{
    public class FinalizarOrdenModel : PageModel
    {
        public string MontoFinal { get; set; }
        public void OnGet(string MontoActual, string PrecioOrden)
        {
            MontoFinal = PrecioOrden;
        }

        public IActionResult OnPostFinalizar()
        {
            string direccion = Request.Form["direccion"];

            return RedirectToPage("../Index", new { retroalimentacion = "Su orden se ha registrado y será enviada a: "+ direccion });
        }

        public IActionResult OnPostCancelar() {
            return RedirectToPage("../Index", new {retroalimentacion = "Su orden ha sido cancelada con éxito"});
        }
    }
}