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
            List<AfipTributoRequest> tributos = ObtenerAfipTributosRequest(request.Percepciones);

            AfipObtenerCAERequest afipObtenerCAERequest = new AfipObtenerCAERequest()
            {
                TipoDocumentoFiscal = TipoDocumentoFiscal.NotaCredito,
                TipoCliente = request.TipoCliente,
                CondicionIVA = request.CondicionIVA,
                Cuit = request.Cuit,
                ImporteNeto = alicuotasIva.Sum(x => x.Monto),
                AlicuotasIva = alicuotasIva,
                Tributos = tributos,
                NumeroFacturaOrigen = request.NumeroFacturaOrigen,
                PuntoVentaOrigen = request.PuntoVentaOrigen,
                PasswordCertificado = PasswordCertificado,
                RutaCertificado = RutaCertificado
            };

            AfipObtenerCAEResponse response = AfipFacturacionElectronicaService.ObtenerCEA(afipObtenerCAERequest);

            return new ObtenerNumeroNotaCretidoResponse()
            {
                SubTotal = response.Subtotal,
                Iva = response.Iva,
                Total = response.Total,
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
                decimal monto = Monto.ObtenerMontoSinIvaSegunTipoDeCliente(grupo.Sum(y => y.NetoTotal), grupo.Key.Valor, condicionIVA);
                alicuotasIva.Add(new AfipAlicuotaIvaRequest()
                {
                    Codigo = grupo.Key.Id,
                    Monto = monto,
                    IvaMonto = monto * grupo.Key.Valor
                });
            }

            return alicuotasIva;
        }

        private List<AfipTributoRequest> ObtenerAfipTributosRequest(List<PercepcionRequest> Percepciones)
        {
            List<AfipTributoRequest> tributos = new List<AfipTributoRequest>();

            foreach (var percepcion in Percepciones)
            {
                tributos.Add(new AfipTributoRequest()
                {
                    Codigo = (short)percepcion.Tipo,
                    Comcepto = percepcion.Comcepto,
                    Alicuota = percepcion.Alicuota,
                    Monto = percepcion.Monto
                });
            }

            return tributos;
        }
    }
}