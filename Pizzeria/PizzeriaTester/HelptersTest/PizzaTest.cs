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

        //Test de EstablecerTama�o
        [TestMethod]
        public void DadoTama�oPeque�aEstablecerEsteTama�oYPrecioPeque�a()
        {
            Pizza.EstablecerTama�o("peque�a");

            string tama�o = Pizza.Coberturas[0].Tipo;
            int precio = Pizza.Coberturas[0].Precio;

            Assert.AreEqual("peque�a", tama�o);
            Assert.AreEqual(3000, precio);
        }

        [TestMethod]
        public void DadoTama�oMedianoEstablecerEsteTama�oYPrecioMediano()
        {
            Pizza.EstablecerTama�o("mediana");

            string tama�o = Pizza.Coberturas[0].Tipo;
            int precio = Pizza.Coberturas[0].Precio;


            Assert.AreEqual("mediana", tama�o);
            Assert.AreEqual(5000, precio);
        }

        [TestMethod]
        public void DadoTama�oGrandeEstablecerEsteTama�oYPrecioGrande()
        {
            Pizza.EstablecerTama�o("grande");

            string tama�o = Pizza.Coberturas[0].Tipo;
            int precio = Pizza.Coberturas[0].Precio;

            Assert.AreEqual("grande", tama�o);
            Assert.AreEqual(7000, precio);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
        "No existe el indice indicado.")]
        public void DadoTama�oNoExistenteNoEstablecer()
        {
            Pizza.EstablecerTama�o("super grande");

            string tama�o = Pizza.Coberturas[0].Tipo;
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

        //Test de ObtenerPrecioTama�o
        [TestMethod]
        public void DadoTama�oPeque�aRetonar3000()
        {
            int precio = Pizza.ObtenerPrecioTama�o("peque�a");

            Assert.AreEqual(3000, precio);
        }

        [TestMethod]
        public void DadoTama�oMedianaRetonar5000()
        {
            int precio = Pizza.ObtenerPrecioTama�o("mediana");

            Assert.AreEqual(5000, precio);
        }

        [TestMethod]
        public void DadoTama�oGrandeRetonar7000()
        {
            int precio = Pizza.ObtenerPrecioTama�o("grande");

            Assert.AreEqual(7000, precio);
        }

        [TestMethod]
        public void DadoTama�oNoExistenteRetonarNegativo()
        {
            int precio = Pizza.ObtenerPrecioTama�o("SUPER GRANDE");

            Assert.AreEqual(-1, precio);
        }
    }
}
