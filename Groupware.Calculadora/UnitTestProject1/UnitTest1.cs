using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class TestsOperadores

    {
        const string miOperador = "-";
        double miOperando;
        double miOperandoDos;
        double miResultadoEsperado;
        double miResultadoReal;


        Groupware.Calculadora.MiCalculadora invocador = new Groupware.Calculadora.MiCalculadora();

        [TestMethod]
        /*public void SumarDosMasDos()
        {
            string miOperador = "+";
            double miOperandoUno = 10;
            double miOperandoDos = 2;
            double miResultadoEsperado = 12;
            double miResultadoReal;

            var invocador = new Groupware.Calculadora.MiCalculadora();
            miResultadoReal = invocador.OperadorBinario(miOperador, miOperandoUno, miOperandoDos);
            Assert.AreEqual(miResultadoEsperado, miResultadoReal);
        }*/

        public void RestarTresMenosDos()
        {
            //Prepare Resultado

            miOperando = 3;
            miOperandoDos = 2;
            miResultadoEsperado = 1;


            // realice la invocacion al metodo


            miResultadoReal = invocador.OperadorBinario(miOperador, miOperando, miOperandoDos);

            // realice la verificacion de si el calculo es correcto

            Assert.AreEqual(miResultadoEsperado, miResultadoReal);

        }
    }
}
