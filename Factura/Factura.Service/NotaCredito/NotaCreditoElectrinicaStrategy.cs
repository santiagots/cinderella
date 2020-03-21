using Common.Core.Enum;
using System.Linq;
using Factura.ExternalService.Contracts;
using Factura.Service.NotaCredito.Contracts;
using Factura.ExternalService;
using System.Collections.Generic;
using Factura.Service.Common.Contracts;
using System;
using Common.Core.Model;

namespace Common.Service.NotaCredito
{
    internal class NotaCreditoElectrinicaStrategy : INotaCreditoStrategy
    {
        public ObtenerNumeroNotaCretidoResponse ObtenerNumeroNotaCretido(ObtenerNumeroNotaCretidoRequest request)
        {
            AfipObtenerCAERequest afipObtenerCAERequest = new AfipObtenerCAERequest()
            {
                TipoDocumentoFiscal = TipoDocumentoFiscal.NotaCredito,
                TipoCliente = request.TipoCliente,
                CondicionIVA = request.CondicionIVA,
                Cuit = request.Cuit,
                ImporteNeto = request.Productos.Sum(x => x.Neto) * request.PorcentajeFacturacion,
                AlicuotasIva = ObtenerAfipAlicuotaIvaRequest(request.TipoCliente, request.Productos, request.PorcentajeFacturacion)
            };

            AfipObtenerCAEResponse response = AfipFacturacionElectronicaService.ObtenerCEA(afipObtenerCAERequest);

            return new ObtenerNumeroNotaCretidoResponse()
            {
                CAE = response.Codigo,
                FechaVencimientoCAE = response.FechaVencimiento,
                NumeroNotaCredito = new List<int>() { response.NumeroComprobante }
            };
        }

        private List<AfipAlicuotaIvaRequest> ObtenerAfipAlicuotaIvaRequest(TipoCliente tipoCliente, List<ProductoRequest> Productos, decimal PorcentajeFacturacion)
        {
            List<AfipAlicuotaIvaRequest> alicuotasIva = new List<AfipAlicuotaIvaRequest>();
            List<IGrouping<IVA, ProductoRequest>> grupos = Productos.GroupBy(x => x.IVA).ToList();

            foreach (IGrouping<IVA, ProductoRequest> grupo in grupos)
            {
                decimal monto = ObtenerMontoSegunTipoDeCliente(grupo.Sum(y => y.Neto), grupo.Key.Valor, tipoCliente);
                monto = monto * PorcentajeFacturacion;
                alicuotasIva.Add(new AfipAlicuotaIvaRequest()
                {
                    Codigo = grupo.Key.Id,
                    Monto = monto,
                    IvaMonto = Math.Round(monto * grupo.Key.Valor, 2, MidpointRounding.AwayFromZero)
                });
            }

            return alicuotasIva;
        }

        internal decimal ObtenerMontoSegunTipoDeCliente(decimal monto, decimal iva, TipoCliente tipoCliente)
        {
            switch (tipoCliente)
            {
                case TipoCliente.Minorista:
                    return Math.Round(monto / (1 + iva), 1, MidpointRounding.AwayFromZero);
                case TipoCliente.Mayorista:
                    return monto;
                default:
                    throw new InvalidOperationException($"Error al realizar la facturación. Tipo de cliente no reconocido {tipoCliente.ToString()}");
            }
        }
    }
}