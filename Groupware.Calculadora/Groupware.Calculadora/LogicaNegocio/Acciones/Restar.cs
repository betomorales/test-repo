using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groupware.Calculadora.LogicaNegocio.Acciones
{
    public class Restar
    {

        public double Calcular(double operando, double operandoDos)
        {

            double resultado = operando - operandoDos;
            return (resultado);

        }
    }
}