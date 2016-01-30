using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groupware.Calculadora.LogicaNegocio.Especificaciones
{
    class ObtenerOperador
    {
        public Enumerados.Operadores obtenerElOperador(string elOperador)
        {
            var elValidador = new Validaciones.Operadores();
            return elValidador.ObtenerOperador(elOperador);

        } 

    }
}
