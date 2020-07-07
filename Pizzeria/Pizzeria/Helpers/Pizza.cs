using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria.Helpers
{
    public class Cobertura
    {
        public string Tipo { get; set; }
        public int Precio { get; set; }
    }
    public class Pizza : IPizza
    {
        private const int PrecioPequeña = 3000;
        private const int PrecioMediana = 5000;
        private const int PrecioGrande = 7000;

        private const int PrecioSalsa = 500;

        private const int PrecioHongos = 500;
        private const int PrecioCebolla = 500;
        private const int PrecioChile = 500;
        private const int PrecioQueso = 1000;
        private const int PrecioJamon = 1000;
        private const int PrecioPepperoni = 1000;
        private const int PrecioPiña = 1500;
        private const int PrecioSalami = 1500;

        private const int PrecioEnvio = 2000;

        public List<Cobertura> Coberturas = new List<Cobertura>();

        public void EstablecerTamaño(string tamaño)
        {
            int precioTamaño = ObtenerPrecioTamaño(tamaño);

            if (precioTamaño != -1) {
                Cobertura TamañoPizza = new Cobertura { Tipo = tamaño, Precio = precioTamaño };

                Coberturas.Add(TamañoPizza);
            }
        }

        public void EstablecerCoberturas(string[] coberturas)
        {
            foreach (string tipo in coberturas)
            {
                int precio = ObtenerPrecioCobertura(tipo);

                if(precio != -1)
                {
                    AgregarCobertura(tipo, precio);
                }
            }
        }

        public void AgregarCobertura(string cobertura, int precio)
        {
            Cobertura TipoCobertura = new Cobertura { Tipo = cobertura, Precio = precio };

            Coberturas.Add(TipoCobertura);
        }

        public int ObtenerPrecioTamaño(string tamaño) {
            int precioTamaño = -1;
            tamaño = tamaño.ToLower();
            switch (tamaño) {
                case "pequeña":
                    precioTamaño = PrecioPequeña;
                    break;

                case "mediana":
                    precioTamaño = PrecioMediana;
                    break;

                case "grande":
                    precioTamaño = PrecioGrande;
                    break;
            }

            return precioTamaño;
        }

        public int ObtenerPrecioCobertura(string cobertura) {
            int precio = -1;
            cobertura = cobertura.ToLower();
            switch (cobertura)
            {
                case "salsa":
                    precio = PrecioSalsa;
                    break;
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
                    precio = PrecioQueso;
                    break;
            }

            return precio;
        }

        public double CalcularTotal()
        {
            double precioTotal = 0;

            foreach (Cobertura Cobertura in Coberturas) {
                precioTotal += Cobertura.Precio;
            }

            precioTotal += PrecioEnvio;

            return precioTotal;
        }
    }
}
