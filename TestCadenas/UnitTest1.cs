using ApiCadenas.Services;

namespace TestCadenas
{
    [TestClass]
    public class CadenaTest
    {
        CadenaClasica miCadena = new CadenaClasica();
        [TestMethod]
        public void Concatena()
        {
            var resultado = miCadena.Concatena("patatas", "bravas");
            Assert.AreEqual("patatasbravas", resultado);
        }
        [TestMethod]
        public void Cuenta()
        {
            var resultado = miCadena.Cuenta("patatas", "bravas");
            Assert.AreEqual(1,resultado);
        }
    }
}