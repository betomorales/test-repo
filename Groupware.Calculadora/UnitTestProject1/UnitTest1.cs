using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SumarDosMasDos()
        {
            string miOperador = "+";
            double miOperandoUno = 10;
            double miOperandoDos = 2;
            double miResultadoEsperado = 12;
            double miResultadoReal;

            var invocador = new Groupware.Calculadora.MiCalculadora();
            miResultadoReal = invocador.OperadorBinario(miOperador, miOperandoUno, miOperandoDos);
            Assert.AreEqual(miResultadoEsperado, miResultadoReal);
        }
    }
}
