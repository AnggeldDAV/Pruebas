using PruebasInicial.Services;

namespace TestProject1
{
    [TestClass]
    public class CalculadoraClasicaTest
    {
        CalculadoraClasica miCalculadora = new CalculadoraClasica();
        [TestMethod]
        public void Suma()
        {
            var resultado = miCalculadora.Suma(4, 4);
            Assert.AreEqual(8,resultado);
        }
        [TestMethod]
        public void Resta()
        {
            var resultado = miCalculadora.Resta(4, 4);
            Assert.IsTrue(resultado == 0);
        }
        [TestMethod]
        public void Multiplica()
        {
            var resultado = miCalculadora.Multiplica(4, 4);
            Assert.IsNotNull(resultado);
            Assert.IsTrue(resultado == 16);
            Assert.AreEqual(16, resultado);
        }
        [TestMethod]
        public void Divide()
        {
            var resultado = miCalculadora.Divide(4, 4);
            Assert.AreEqual(1, resultado);
        }
    }
}