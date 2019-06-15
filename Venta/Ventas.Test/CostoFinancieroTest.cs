using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Ventas.Data.Repository;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.VentaAggregate;
using System.Linq;
using Ventas.Data;
using System.Collections.Generic;

namespace Ventas.Test
{
    public class CostoFinancieroTest
    {
        [Fact]
        public void Obtener()
        {
            ICostoFinancieroRepository repository = new CostoFinancieroRepository(new VentaContext());
            List<CostoFinanciero> bancos = repository.Obtener(1).ToList();
        }
    }
}
