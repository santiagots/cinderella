using Common.Core.Enum;
using System.Linq;
using Factura.ExternalService.Contracts;
using Factura.Service.NotaCredito.Contracts;
using Factura.ExternalService;
using System.Collections.Generic;
using Factura.Service.Common.Contracts;
using System;
using Common.Core.Model;
using Common.Core.Helper;

namespace Common.Service.NotaCredito
{
    internal class NotaCreditoElectrinicaStrategy : INotaCreditoStrategy
    {
        public static string PasswordCertificado;
        public string RutaCertificado;

        public NotaCreditoElectrinicaStrategy(string rutaCertificado, string passwordCertificado)
        {
            RutaCertificado = rutaCertificado;
            PasswordCertificado = passwordCertificado;
        }
        public ObtenerNumeroNotaCretidoResponse ObtenerNumeroNotaCretido(ObtenerNumeroNotaCretidoRequest request)
        {
            List<AfipAlicuotaIvaRequest> alicuotasIva = ObtenerAfipAlicuotaIvaRequest(request.CondicionIVA, request.Productos, request.PorcentajeFacturacion);

            AfipObtenerCAERequest afipObtenerCAERequest = new AfipObtenerCAERequest()
            {
                TipoDocumentoFiscal = TipoDocumentoFiscal.NotaCredito,
                TipoCliente = request.TipoCliente,
                CondicionIVA = request.CondicionIVA,
                Cuit = request.Cuit,
                ImporteNeto = alicuotasIva.Sum(x => x.Monto),
                AlicuotasIva = alicuotasIva,
                PasswordCertificado = PasswordCertificado,
                RutaCertificado = RutaCertificado
            };

            AfipObtenerCAEResponse response = AfipFacturacionElectronicaService.ObtenerCEA(afipObtenerCAERequest);

            return new ObtenerNumeroNotaCretidoResponse()
            {
                CAE = response.Codigo,
                FechaVencimientoCAE = response.FechaVencimiento,
                NumeroNotaCredito = new List<int>() { response.NumeroComprobante }
            };
        }

        private List<AfipAlicuotaIvaRequest> ObtenerAfipAlicuotaIvaRequest(CondicionIVA condicionIVA, List<ProductoRequest> Productos, decimal PorcentajeFacturacion)
        {
            List<AfipAlicuotaIvaRequest> alicuotasIva = new List<AfipAlicuotaIvaRequest>();
            List<IGrouping<IVA, ProductoRequest>> grupos = Productos.GroupBy(x => x.IVA).ToList();

            foreach (IGrouping<IVA, ProductoRequest> grupo in grupos)
            {
                decimal monto = ObtenerMontoSegunTipoDeCliente(grupo.Sum(y => y.NetoTotal), grupo.Key.Valor, condicionIVA);
                alicuotasIva.Add(new AfipAlicuotaIvaRequest()
                {
                    Codigo = grupo.Key.Id,
                    Monto = monto,
                    IvaMonto = monto * grupo.Key.Valor
                });
            }

            return alicuotasIva;
        }

        internal decimal ObtenerMontoSegunTipoDeCliente(decimal monto, decimal iva, CondicionIVA condicionIVA)
        {
            switch (condicionIVA)
            {
                case CondicionIVA.Consumidor_Final:
                case CondicionIVA.Monotributo:
                case CondicionIVA.Exento:
                    decimal montoSinIva = Monto.ObtenerSinIVA(monto, iva);
                    return montoSinIva;
                case CondicionIVA.Responsable_Inscripto:
                    return monto;
                default:
                    throw new InvalidOperationException($"Error al realizar la facturación. Condición IVA no reconocido {condicionIVA.ToString()}");
            }
        }
    }
}