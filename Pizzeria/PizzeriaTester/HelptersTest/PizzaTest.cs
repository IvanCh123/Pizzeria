using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizzeria.Helpers;
using System;
using System.Diagnostics;

namespace PizzeriaTester
{
    [TestClass]
    public class PizzaTest
    {
        private Pizza Pizza = new Pizza();

        //Test de EstablecerTamaño
        [TestMethod]
        public void DadoTamañoPequeñaEstablecerEsteTamañoYPrecioPequeña()
        {
            Pizza.EstablecerTamaño("pequeña");

            string tamaño = Pizza.Coberturas[0].Tipo;
            int precio = Pizza.Coberturas[0].Precio;

            Assert.AreEqual("pequeña", tamaño);
            Assert.AreEqual(3000, precio);
        }

        [TestMethod]
        public void DadoTamañoMedianoEstablecerEsteTamañoYPrecioMediano()
        {
            Pizza.EstablecerTamaño("mediana");

            string tamaño = Pizza.Coberturas[0].Tipo;
            int precio = Pizza.Coberturas[0].Precio;


            Assert.AreEqual("mediana", tamaño);
            Assert.AreEqual(5000, precio);
        }

        [TestMethod]
        public void DadoTamañoGrandeEstablecerEsteTamañoYPrecioGrande()
        {
            Pizza.EstablecerTamaño("grande");

            string tamaño = Pizza.Coberturas[0].Tipo;
            int precio = Pizza.Coberturas[0].Precio;

            Assert.AreEqual("grande", tamaño);
            Assert.AreEqual(7000, precio);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
        "No existe el indice indicado.")]
        public void DadoTamañoNoExistenteNoEstablecer()
        {
            Pizza.EstablecerTamaño("super grande");

            string tamaño = Pizza.Coberturas[0].Tipo;
            int precio = Pizza.Coberturas[0].Precio;
        }

        //Test de EstablecerCoberturas
        [TestMethod]
        public void Dado3CoberturasEstablecerlas()
        {
            string[] coberturas = {"queso", "hongos", "jamon"};
            int[] precios = {1000, 500, 1000};

            Pizza.EstablecerCoberturas(coberturas);

            Assert.AreEqual(3, Pizza.Coberturas.Count);

            for (int index = 0; index < Pizza.Coberturas.Count; index++)
            {
                string cobertura = Pizza.Coberturas[index].Tipo;
                int precio = Pizza.Coberturas[index].Precio;

                Assert.AreEqual(coberturas[index], cobertura);
                Assert.AreEqual(precios[index], precio);
            }
        }

        [TestMethod]
        public void DadoCoberturaNoExistenteNoAgregarla()
        {
            string[] coberturas = { "queso", "EXTRA SUPER JAMON", "jamon" };

            Pizza.EstablecerCoberturas(coberturas);
            Assert.AreEqual(2, Pizza.Coberturas.Count);
        }

        [TestMethod]
        public void DadoNoCoberturaNoGenerar()
        {
            string[] coberturas = {};

            Pizza.EstablecerCoberturas(coberturas);
            Assert.AreEqual(0, Pizza.Coberturas.Count);
        }
    }
}
