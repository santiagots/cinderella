using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Common.Data.Repository;
using Ventas.Core.Model.VentaAggregate;
using Common.Data;
using System.Collections.Generic;
using Ventas.Data.Repository;
using Ventas.Data;
using System.Linq;
using Ventas.Core.Interfaces;

namespace Ventas.Test
{
    public class ProductoTest
    {
        [Fact]
        public void Obtener()
        {
            IProductoRepository repository = new ProductoRepository(new VentaContext());
            var productos = repository.Obtener();

        }
    }
}
