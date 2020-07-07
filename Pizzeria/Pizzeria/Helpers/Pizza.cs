using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria.Helpers
{
    public class Cobertura
    {
        public string Tipo { get; set; }
        public double Precio { get; set; }
    }
    public class Pizza
    {
        public string Tamaño { get; set; }
        public List<Cobertura> Coberturas { get; set; }


        public void EstablecerTamaño(string tamaño)
        {
            Tamaño = tamaño;
        }

        public void AgregarCobertura(string cobertura, int precio)
        {
            Cobertura tipoCobertura = new Cobertura { Tipo = cobertura, Precio = precio };

            Coberturas.Add(tipoCobertura);
        }
    }
}
