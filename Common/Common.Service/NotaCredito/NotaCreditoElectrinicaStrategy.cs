using System;
using System.Collections.Generic;
using Common.Core.Enum;
using Common.Core.ValueObjects;
using Common.Core.Exceptions;

namespace Common.Service.NotaCredito
{
    internal class NotaCreditoElectrinicaStrategy : INotaCreditoStrategy
    {
        public List<int> ObtenerNumeroNotaCretido(TipoCliente tipoCliente, CondicionIVA condicionesIVA, List<TicketPago> pagos, IList<TicketProducto> productos, decimal porcentajeFacturacion, string nombreYApellido, string direccion, string localidad, string cuit, int numeroFacturaOrigen)
        {
            throw new NegocioException("El metodo de generacion de nota de crédito electrónico no se encuentra implementado");
        } 
    }
}