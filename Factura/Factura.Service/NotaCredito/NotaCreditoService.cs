using Common.Core.Enum;
using Common.Core.Exceptions;
using Factura.Service.NotaCredito.Contracts;
using System;
using System.Collections.Generic;


namespace Common.Service.NotaCredito
{
    public class NotaCreditoService
    {
        private INotaCreditoStrategy notaCreditoStrategy;

        public NotaCreditoService(TipoFactura tiposFactura, string rutaCertificado, string passwordCertificado)
        {
            switch (tiposFactura)
            {
                case TipoFactura.Ticket:
                    notaCreditoStrategy = new NotaCreditoControladorFiscalStrategy();
                    break;
                case TipoFactura.Manual:
                    notaCreditoStrategy = new NotaCreditoManualStrategy();
                    break;
                case TipoFactura.Electronica:
                    notaCreditoStrategy = new NotaCreditoElectrinicaStrategy(rutaCertificado, passwordCertificado);
                    break;
                default:
                    throw new InvalidOperationException($"El método de facturación {tiposFactura.ToString()} no tiene un una forma de facturación definida.");
            }
        }

        public ObtenerNumeroNotaCretidoResponse ObtenerNumeroNotaCretido(ObtenerNumeroNotaCretidoRequest request)
        {
            if (request.Productos == null || request.Productos.Count == 0)
                throw new NegocioException($"Error al generar la nota de crédito. No se encuentran productos para generar la nota de crédito.");
            return notaCreditoStrategy.ObtenerNumeroNotaCretido(request);
        }
    }
}
