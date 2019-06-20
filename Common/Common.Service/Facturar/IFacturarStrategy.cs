﻿using Common.Core.Enum;
using Common.Core.ValueObjects;
using System.Collections.Generic;

namespace Common.Service.Facturar
{
    public interface IFacturarStrategy
    {
        List<int> ObtenerNumeroFactura(TipoCliente tipoCliente, CondicionIVA condicionesIVA, List<TicketPago> pagos, IList<TicketProducto> productos, decimal porcentajeFacturacion, string nombreYApellido, string direccion, string localidad, string cuit);
    }
}