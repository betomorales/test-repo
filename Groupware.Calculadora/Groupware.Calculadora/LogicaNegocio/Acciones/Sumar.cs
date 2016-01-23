using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Groupware.Calculadora.LogicaNegocio.Acciones
{
    public class Sumar
    {
        public double Calcular(double operando, double operandoDos)
        {
            double resultado = operando + operandoDos;
            return resultado;

        }
    }
}