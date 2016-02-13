using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Groupware.Calculadora.LogicaNegocio.Validaciones
{
    public class Resta
    {

        public double Calculo(double operando, double OperandoDos)
        {

            double resultado;
            //invoque a la acción correspondiente
            Acciones.Restar operacion = new Acciones.Restar();
            resultado = operacion.Calcular(operando, OperandoDos);
            return (resultado);
        }


    }
}