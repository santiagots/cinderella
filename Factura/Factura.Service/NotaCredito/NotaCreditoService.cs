using Common.Core.Enum;
using Factura.Service.NotaCredito.Contracts;
using System;
using System.Collections.Generic;


namespace Common.Service.NotaCredito
{
    public class NotaCreditoService
    {
        private INotaCreditoStrategy notaCreditoStrategy;

        public NotaCreditoService(TipoFactura tiposFactura, string rutaCertificado)
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
                    notaCreditoStrategy = new NotaCreditoElectrinicaStrategy(rutaCertificado);
                    break;
                default:
                    throw new InvalidOperationException($"El método de facturación {tiposFactura.ToString()} no tiene un una forma de facturación definida.");
            }
        }

        public ObtenerNumeroNotaCretidoResponse ObtenerNumeroNotaCretido(ObtenerNumeroNotaCretidoRequest request)
        {
            return notaCreditoStrategy.ObtenerNumeroNotaCretido(request);
        }
    }
}
