using Common.Core.Enum;
using Common.Core.ValueObjects;
using System;
using System.Collections.Generic;

namespace Common.Service.Facturar
{
    public class FacturarService
    {
        private IFacturarStrategy facturarStrategy;

        public FacturarService(TipoFactura tiposFactura)
        {
            switch (tiposFactura)
            {
                case TipoFactura.Ticket:
                    facturarStrategy = new FacturarControladorFiscalStrategy();
                    break;
                case TipoFactura.Manual:
                    facturarStrategy = new FacturarManualStrategy();
                    break;
                case TipoFactura.Electronica:
                    facturarStrategy = new FacturarElectrinicaStrategy();
                    break;
                default:
                    throw new InvalidOperationException($"El método de facturación {tiposFactura.ToString()} no tiene un una forma de facturación definida.");
            }
        }

        public List<int> ObtenerNumeroFactura(TipoCliente tipoCliente, CondicionIVA condicionesIVA, List<TicketPago> pagos, IList<TicketProducto> productos, decimal porcentajeFacturacion, string nombreYApellido, string direccion, string localidad, string cuit)
        {
            return facturarStrategy.ObtenerNumeroFactura(tipoCliente, condicionesIVA, pagos, productos, porcentajeFacturacion , nombreYApellido, direccion, localidad, cuit);
        }
    }
}
