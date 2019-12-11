using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ventas.Core.Model.InformeAggregate;
using Ventas.Data;
using Ventas.Data.Repository;

namespace Ventas.Test
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            InformeVentaRepository repository = new InformeVentaRepository(new VentaContext());
            IList<InformeVenta> informeVenta = repository.ObtenerTotal(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 },
                                                            new DateTime(1990, 1, 1),
                                                            new DateTime(2030, 1, 1));
        }
    }
}
