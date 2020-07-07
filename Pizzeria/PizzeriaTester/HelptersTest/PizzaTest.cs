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

    }
}
