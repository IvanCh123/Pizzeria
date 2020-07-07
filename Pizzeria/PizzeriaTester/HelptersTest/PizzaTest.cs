using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizzeria.Helpers;

namespace PizzeriaTester
{
    [TestClass]
    public class PizzaTest
    {
        private readonly Pizza Pizza = new Pizza();

        //Test de EstablecerTama�o

        [TestMethod]
        public void DadoUnTama�oEstablecerEsteTama�o()
        {
            Pizza.EstablecerTama�o("peque�a");

            Assert.AreEqual("peque�a", Pizza.Tama�o);

            Pizza.EstablecerTama�o("mediana");

            Assert.AreEqual("mediana", Pizza.Tama�o);

            Pizza.EstablecerTama�o("grande");

            Assert.AreEqual("grande", Pizza.Tama�o);
        }

    }
}
