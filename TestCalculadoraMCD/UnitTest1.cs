using CalculadoraMCM.Services;

namespace TestCalculadoraMCD
{
    [TestClass]
    public class CalculadoraMCD
    {
        CalculadoraMatematica miCalculadora = new CalculadoraMatematica();
        [TestMethod]
        public void MCD()
        {
            var resultado = miCalculadora.MCD(6,9);
            Assert.AreEqual(3,resultado);
        }
        [TestMethod]
        public void MCM()
        {
            var resultado = miCalculadora.MCM(12,8);
            Assert.AreEqual(24,resultado);
        }
    }
}