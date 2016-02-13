//using Groupware.Calculadora.LogicaNegocio.Validaciones;

using Groupware.Calculadora.LogicaNegocio.Enumerados;
using Groupware.Calculadora.LogicaNegocio.Validaciones;

namespace Groupware.Calculadora.LogicaNegocio.Especificaciones
{
    internal class RealizarOperacionBinaria
    {
       // private Enumerados.Operadores miOperador;
      //  private double operando;
       // private double operandoDos;

        public double RealizarLaOperacionBinaria(Enumerados.Operadores miOperador, double operando, double operandoDos)
        {
            double resultado = 0.0;
            switch (miOperador)
            {

                case Enumerados.Operadores.Suma:
                    var laSuma = new Suma();
                    resultado = laSuma.Calculo(operando, operandoDos);
                    break;


                case Enumerados.Operadores.Resta:
                    var laResta = new Resta();
                    resultado = laResta.Calculo(operando, operandoDos);
                    break;


                    /*case Enumerados.Operadores.Multiplicacion:
                        var laMultiplicacion = new Multiplicacion();
                        resultado = laMultiplicacion.Calculo(operando, operandoDos);
                        break;
                        */





            }
            return resultado;
        }
    }
}