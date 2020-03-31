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
                AlicuotasIva = ObtenerAfipAlicuotaIvaRequest(request.CondicionIVA, request.Productos, request.PorcentajeFacturacion)
            };

            AfipObtenerCAEResponse response = AfipFacturacionElectronicaService.ObtenerCEA(afipObtenerCAERequest);

            return new ObtenerNumeroNotaCretidoResponse()
            {
                CAE = response.Codigo,
                FechaVencimientoCAE = response.FechaVencimiento,
                NumeroNotaCredito = new List<int>() { response.NumeroComprobante }
            };
        }

        private List<AfipAlicuotaIvaRequest> ObtenerAfipAlicuotaIvaRequest(CondicionIVA condicionIva, List<ProductoRequest> Productos, decimal PorcentajeFacturacion)
        {
            List<AfipAlicuotaIvaRequest> alicuotasIva = new List<AfipAlicuotaIvaRequest>();
            List<IGrouping<IVA, ProductoRequest>> grupos = Productos.GroupBy(x => x.IVA).ToList();

            foreach (IGrouping<IVA, ProductoRequest> grupo in grupos)
            {
                decimal monto = ObtenerMontoSegunTipoDeCliente(grupo.Sum(y => y.Neto), grupo.Key.Valor, condicionIva);
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

        internal decimal ObtenerMontoSegunTipoDeCliente(decimal monto, decimal iva, CondicionIVA condicionIva)
        {
            switch (condicionIva)
            {
                case CondicionIVA.Consumidor_Final:
                case CondicionIVA.Exento:
                case CondicionIVA.Monotributo:
                    return Math.Round(monto / (1 + iva), 2, MidpointRounding.AwayFromZero);
                case CondicionIVA.Responsable_Inscripto:
                    return monto;
                default:
                    throw new InvalidOperationException($"Error al realizar la facturación. Tipo de cliente no reconocido {condicionIva.ToString()}");
            }
        }
    }
}