using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Framework.Warming.BL.EF.Negocio.Repositorios
{
    public class RepProducts
    {
        private readonly Entity.Framework.Warming.Model.AdventureWorks2014Entities _context =
                new Model.AdventureWorks2014Entities();

        public IEnumerable<Model.Product> ListarProductosPorNombre(string NombreProducto)
        {

            IEnumerable<Model.Product> productos = _context.Products.Where(p => p.Name.Contains(NombreProducto));
                return (productos);
        }
    

    }
}
