using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pizzeria.Pages.Ordenar
{
    public class FinalizarOrdenModel : PageModel
    {
        public string MontoFinal { get; set; }
        public void OnGet(string PrecioOrden)
        {
            MontoFinal = PrecioOrden;
        }
    }
}