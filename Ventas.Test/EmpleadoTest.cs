using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ventas.Data.Repository;
using Ventas.Core.Interfaces;
using Ventas.Data;
using Ventas.Core.Model.VentaAggregate;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Ventas.Core.Model.BaseAgreggate;

namespace Ventas.Test
{
    public class EmpleadoTest
    {
        [Fact]
        public void Obtener()
        {
            IEmpleadoRepository repository = new EmpleadoRepository(new VentaContext());
            List<Empleado> bancos = repository.ObtenerPorSucursal(42, Common.Core.Enum.TipoEmpleado.Vendedor).ToList();
        }

        [Fact]
        public void ObtenerClienteMayorista()
        {
            ClienteMayoristaRepository repository = new ClienteMayoristaRepository(new VentaContext());
            ClienteMayorista bancos = repository.Obtener(2);
        }
    }
}
