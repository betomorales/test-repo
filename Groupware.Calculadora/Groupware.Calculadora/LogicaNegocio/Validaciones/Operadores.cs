using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Groupware.Calculadora.LogicaNegocio.Validaciones
{
    public class Operadores
    {
        public Enumerados.Operadores ObtenerOperador(String elOperador)
        {

            Enumerados.Operadores resultado;
            resultado = Enumerados.Operadores.Desconocido;
            switch (elOperador)
            {
                case "+": resultado = Enumerados.Operadores.Suma;
                    break;


                case "-":
                    resultado = Enumerados.Operadores.Resta;
                    break;
            }
        


            return (resultado);

        }
        
    }
}