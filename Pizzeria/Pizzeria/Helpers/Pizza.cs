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
        private const int PrecioHongos = 500;
        private const int PrecioCebolla = 500;
        private const int PrecioChile = 500;
        private const int PrecioSalami = 1000;
        private const int PrecioJamon = 1000;
        private const int PrecioPepperoni = 1000;
        private const int PrecioPiña = 1500;
        private const int PrecioQuesoExtra = 1500;

        private const int PrecioEnvio = 2000;

        public string Tamaño { get; set; }
        public List<Cobertura> Coberturas { get; set; }

        public void EstablecerTamaño(string tamaño)
        {
            Tamaño = tamaño;
        }

        public void AgregarCobertura(string cobertura, int precio)
        {
            Cobertura tipoCobertura = new Cobertura { Tipo = cobertura, Precio = precio };

            if (tipoCobertura != null)
                Coberturas.Add(tipoCobertura);
        }

        public void EstablecerCoberturas(string[] coberturas) {
            int precio = -1;
            foreach (var tipo in coberturas) {
                switch (tipo) {
                    case "hongos":
                        precio = PrecioHongos;
                        break;
                    case "cebolla":
                        precio = PrecioCebolla;
                        break;
                    case "chile":
                        precio = PrecioChile;
                        break;
                    case "salami":
                        precio = PrecioSalami;
                        break;
                    case "jamon":
                        precio = PrecioJamon;
                        break;
                    case "pepperoni":
                        precio = PrecioPepperoni;
                        break;
                    case "piña":
                        precio = PrecioPiña;
                        break;
                    case "queso":
                        precio = PrecioQuesoExtra;
                        break;
                }

                AgregarCobertura(tipo, precio);
            }
        }
    }
}
