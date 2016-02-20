using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Entity.Framework.Warming.BL.EF.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //preparar scenario
            IEnumerable <Model.Product> listaProductos;
            var repos = new Negocio.Repositorios.RepProducts();
            var cantidadProductosEsperada = 12;
            var cantidadProductosReal = 0;
            const string patronBusqueda = "%ke%";

            //ejecutar
            listaProductos = repos.ListarProductosPorNombre(patronBusqueda);
            cantidadProductosReal = listaProductos.Count();


            //assert
            Assert.AreEqual(cantidadProductosEsperada, cantidadProductosReal);

        }
    }
}
