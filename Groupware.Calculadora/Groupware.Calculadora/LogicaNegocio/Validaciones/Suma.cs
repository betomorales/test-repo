using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Groupware.Calculadora.LogicaNegocio.Validaciones
{
    public class Suma
    {
        public double Calculo(double operando, double operandoDos)
        {
            double resultado;
            Acciones.Sumar operacion = new Acciones.Sumar();
            resultado = operacion.Calcular(operando, operandoDos);
            return resultado;

        }

    }
}