using Xunit;
using Ventas.Data.Repository;
using Ventas.Core.Interfaces;
using Ventas.Data;
using Ventas.Core.Model.VentaAggregate;
using System.Collections.Generic;
using System.Linq;
using Common.Data.Repository;

namespace Ventas.Test
{
    public class BancoTest
    {
        [Fact]
        public void Obtener()
        {
            Repository<Comision> repository = new Repository<Comision>(new VentaContext());
            List<Comision> bancos = repository.List().ToList();
        }

        [Fact]
        public void ObtenerVenta()
        {
            VentaRepository repository = new VentaRepository(new VentaContext());
            List<Venta> bancos = repository.Obtener();
        }

        [Fact]
        public void GuardarVenta()
        {

            Venta venta = new Venta(2);
            venta.AgregaVentaItem("ABC", "Producto1", 12.44M, 1, 0.1M, 1, Common.Core.Enum.TipoCliente.Minorista, 12.44M, 0.1M, 13.44M, 0);
            //venta.AgregaPago(12.01M, 12.01M, 12.01M, 12.01M, Common.Core.Enum.TipoPago.Cheque, 0.5M, "Visa", 2);
            venta.AgregarComision(0.4M, 0.4M);
            //venta.AgregarFactura(Common.Core.Enum.TipoFactura.Manual, Common.Core.Enum.CondicionIVA.Consumidor_Final, "", "", "", "", new List<int>() { 123, 456 });
            VentaRepository repository = new VentaRepository(new VentaContext());
            repository.Guardar(venta);
        }
    }
}
