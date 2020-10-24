using Common.Core.Enum;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.CuentaCorrienteAggregate;
using Ventas.Data.Repository;

namespace Ventas.Data.Service
{
    public class MovimientoService
    {
        public static Task<List<Movimiento>> ObtenerMovimientosAsync(TipoBase tipoBase, int idCuentaCorriente, DateTime fechaDesde, DateTime fechaHasta, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int pagina, int itemsPorPagina, out int totalElementos)
        {
            IMovimientoRepository movimientoRepository = new MovimientoRepository(new VentaContext(tipoBase));
            return movimientoRepository.ObtenerMovimientosAsync(idCuentaCorriente, fechaDesde, fechaHasta, ordenadoPor, ordenarDireccion, pagina, itemsPorPagina, out totalElementos);
        }

        public static Task<decimal> ObtenerSaldoAsync(TipoBase tipoBase, int idCuentaCorriente)
        {
            IMovimientoRepository movimientoRepository = new MovimientoRepository(new VentaContext(tipoBase));
            return movimientoRepository.ObtenerSaldoAsync(idCuentaCorriente);
        }

        public static Task GuardarAsync(TipoBase tipoBase, Movimiento movimiento)
        {
            IMovimientoRepository movimientoRepository = new MovimientoRepository(new VentaContext(tipoBase));
            return movimientoRepository.GuardarAsync(movimiento);
        }
    }
}
