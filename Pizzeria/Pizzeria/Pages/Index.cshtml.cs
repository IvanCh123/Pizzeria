using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pizzeria.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            Response.Redirect("/Ordenar/Ordenar");
        }
    }
}
