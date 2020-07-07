using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria.Helpers
{
    interface IPizza
    {
        void EstablecerTamaño(string tamaño);
        void AgregarCobertura(string cobertura, int precio);
        void EstablecerCoberturas(string[] coberturas);
        int ObtenerPrecioTamaño(string tamaño);
        int ObtenerPrecioCobertura(string cobertura);
        double CalcularTotal();
    }
}
