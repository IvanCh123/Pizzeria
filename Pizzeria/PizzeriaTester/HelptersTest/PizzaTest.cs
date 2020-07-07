using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizzeria.Helpers;

namespace PizzeriaTester
{
    [TestClass]
    public class PizzaTest
    {
        private readonly Pizza Pizza = new Pizza();

        //Test de EstablecerTamaño

        [TestMethod]
        public void DadoUnTamañoEstablecerEsteTamaño()
        {
            Pizza.EstablecerTamaño("pequeña");

            Assert.AreEqual("pequeña", Pizza.Tamaño);

            Pizza.EstablecerTamaño("mediana");

            Assert.AreEqual("mediana", Pizza.Tamaño);

            Pizza.EstablecerTamaño("grande");

            Assert.AreEqual("grande", Pizza.Tamaño);
        }

    }
}
