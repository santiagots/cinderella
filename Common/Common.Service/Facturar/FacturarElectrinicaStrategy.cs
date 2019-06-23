using Common.Core.Enum;
using Common.Core.Exceptions;
using System.Collections.Generic;
using Common.Core.ValueObjects;
using System;

namespace Common.Service.Facturar
{
    public class FacturarElectrinicaStrategy : IFacturarStrategy
    {
        public void ObtenerCierreZ()
        {
            throw new NegocioException("El metodo de facturación electrónico no se encuentra implementado");
        }

        public void ObtenerCierreZPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            throw new NegocioException("El metodo de facturación electrónico no se encuentra implementado");
        }

        public List<int> ObtenerNumeroFactura(TipoCliente tipoCliente, CondicionIVA condicionesIVA, List<TicketPago> pagos, IList<TicketProducto> productos, decimal porcentajeFacturacion, string nombreYApellido, string direccion, string localidad, string cuit)
        {
            throw new NegocioException("El metodo de facturación electrónico no se encuentra implementado");
        }
    }
}
