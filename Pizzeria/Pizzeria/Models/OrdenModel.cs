using Pizzeria.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria.Models
{
    public class OrdenModel
    {
        public Pizza Pizza = new Pizza();

        public void EstablecerTamaño(string tamaño) {
            Pizza.EstablecerTamaño(tamaño);
        }

        public void EstablecerCoberturas(string[] coberturas)
        {
            Pizza.EstablecerCoberturas(coberturas);
        }

        public double CalcularTotal()
        {
            return Pizza.CalcularTotal();
        }
    }
}
