using Groupware.Calculadora.LogicaNegocio.Enumerados;
using Groupware.Calculadora.LogicaNegocio.Validaciones;

namespace Groupware.Calculadora.LogicaNegocio.Especificaciones
{
    internal class RealizarOperacionBinaria
    {
        private Operadores miOperador;
        private double operando;
        private double operandoDos;

        public RealizarOperacionBinaria(Operadores miOperador, double operando, double operandoDos)
        {
            switch (miOperador)
            {

                case Suma: var laSuma = new LogicaNegocio.Especificaciones.Suma();
                    resultado = laSuma.calculo(operando, operandoDos);
                    break;
            }
        }
    }
}