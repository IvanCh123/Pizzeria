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

    }
}
