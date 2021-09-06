using Common.Core.Enum;
using Common.Core.Exceptions;
using Common.Core.Helper;
using Factura.Core.Enum;
using Factura.Core.Helper;
using Factura.Core.Model.AfipAgreggate;
using Factura.ExternalService.Afip.Wsfev1;
using Factura.ExternalService.Contracts;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Factura.ExternalService
{
    public class AfipFacturacionElectronicaService
    {
        public static AfipObtenerCAEResponse ObtenerCEA(AfipObtenerCAERequest request)
        {
            Afip.Wsfev1.ServiceSoapClient serviceClient = new Afip.Wsfev1.ServiceSoapClient();

            //Compruevo que el servicio este disponible
            Afip.Wsfev1.DummyResponse dummyResponse = serviceClient.FEDummy();

            Afip.Wsfev1.FECAERequest feCAERequest = new Afip.Wsfev1.FECAERequest()
            {
                FeCabReq = ObtenerCabecera(1, request.CondicionIVA, request.TipoDocumentoFiscal),
                FeDetReq = new Afip.Wsfev1.FECAEDetRequest[] { ObtenerDetalle(request) }
            };

            Afip.Wsfev1.FECAEResponse feCAEResponse = serviceClient.FECAESolicitar(ObtenerAuth(request.PasswordCertificado, request.RutaCertificado), feCAERequest);

            VerificarErrorEnRespuesta(feCAEResponse.Errors);
            VerificarObservacionesEnRespuesta(feCAEResponse);

            return new AfipObtenerCAEResponse()
            {
                Subtotal = (decimal) feCAERequest.FeDetReq[0].ImpNeto,
                Iva = (decimal) feCAERequest.FeDetReq[0].ImpIVA,
                Total = (decimal) feCAERequest.FeDetReq[0].ImpTotal,
                NumeroComprobante = (int)feCAEResponse.FeDetResp.First().CbteDesde,
                Codigo = feCAEResponse.FeDetResp.First().CAE,
                FechaVencimiento = DateTime.ParseExact(feCAEResponse.FeDetResp.First().CAEFchVto, "yyyyMMdd", CultureInfo.InvariantCulture)
            };
        }

        private static Afip.Wsfev1.FEAuthRequest ObtenerAuth(string passwordCertificado, string rutaCertificado)
        {
            AfipTokenAcces afipTokenAcces = AfipTokenAccesService.Obtener(AfipFacturacionElectronicaConstantes.NOMBRE_SERVICIO, rutaCertificado, passwordCertificado);

            return new Afip.Wsfev1.FEAuthRequest()
            {
                Cuit = AfipFacturacionElectronicaConstantes.CUIT_FACTURACION,
                Sign = afipTokenAcces.Firma,
                Token = afipTokenAcces.Token
            };
        }

        private static Afip.Wsfev1.FECAECabRequest ObtenerCabecera(int cantidadRegistros, CondicionIVA condicionIVA, TipoDocumentoFiscal tipoDocumentoFiscal)
            => new Afip.Wsfev1.FECAECabRequest()
            {
                CantReg = cantidadRegistros,
                CbteTipo = AfipFacturacionElectronica.ObtenerTipoComprobante(AfipFacturacionElectronicaConstantes.CONDICION_IVA_VENDEDOR, condicionIVA, tipoDocumentoFiscal),
                PtoVta = AfipFacturacionElectronicaConstantes.PUNTO_VENTA
            };

        private static Afip.Wsfev1.FECAEDetRequest ObtenerDetalle(AfipObtenerCAERequest CAErequest)
        {
            Afip.Wsfev1.FECAEDetRequest request = new Afip.Wsfev1.FECAEDetRequest();

            request.Concepto = AfipFacturacionElectronicaConstantes.CONCEPTO;
            request.DocTipo = AfipFacturacionElectronica.ObtenerTipoDocumento(CAErequest.CondicionIVA);
            request.DocNro = long.Parse(CAErequest.Cuit);
            request.CbteDesde = ObtenerNumeroComprobante(CAErequest.CondicionIVA, CAErequest.TipoDocumentoFiscal, CAErequest.PasswordCertificado, CAErequest.RutaCertificado);
            request.CbtesAsoc = ObtenerComprobanteAsociado(CAErequest.CondicionIVA, CAErequest.TipoDocumentoFiscal, CAErequest.PuntoVentaOrigen, CAErequest.NumeroFacturaOrigen);
            request.CbteHasta = request.CbteDesde;
            request.CbteFch = DateTime.Now.ToString("yyyyMMdd");
            request.MonId = AfipFacturacionElectronicaConstantes.PESOS;
            request.MonCotiz = AfipFacturacionElectronicaConstantes.PESOS_COTIZACION;
            request.ImpTotConc = 0;                                             //Importe total no grabado
            request.ImpNeto = (double)Monto.Redondeo(CAErequest.ImporteNeto);   //Importe total neto
            request.ImpOpEx = 0;                                                //Importe total excento
            request.ImpTrib = 0;                                                //Importe total tributo

            AgregarAlicutaIva(CAErequest.AlicuotasIva, request);

            request.ImpTotal = request.ImpTotConc + request.ImpNeto + request.ImpOpEx + request.ImpIVA + request.ImpTrib;

            return request;
        }

        private static void AgregarAlicutaIva(List<AfipAlicuotaIvaRequest> alicuotaIva, Afip.Wsfev1.FECAEDetRequest request)
        {
            if (AfipFacturacionElectronicaConstantes.CONDICION_IVA_VENDEDOR == CondicionIVA.Monotributo)
            {
                request.ImpIVA = 0;
            }
            else
            {
                request.Iva = alicuotaIva.Select(x => new Afip.Wsfev1.AlicIva()
                {
                    Id = x.Codigo,
                    BaseImp = (double)Monto.Redondeo(x.Monto),
                    Importe = (double)Monto.Redondeo(x.IvaMonto)
                }).ToArray();

                request.ImpIVA = request.Iva.Sum(x => x.Importe);
            }
        }

        private static int ObtenerNumeroComprobante(CondicionIVA condicionesIVA, TipoDocumentoFiscal tipoDocumentoFiscal, string passwordCertificado, string rutaCertificado)
        {
            try
            {
                Afip.Wsfev1.ServiceSoapClient serviceClient = new Afip.Wsfev1.ServiceSoapClient();
                Afip.Wsfev1.FERecuperaLastCbteResponse response = serviceClient.FECompUltimoAutorizado(ObtenerAuth(passwordCertificado, rutaCertificado),
                                                                                                        AfipFacturacionElectronicaConstantes.PUNTO_VENTA,
                                                                                                        AfipFacturacionElectronica.ObtenerTipoComprobante(AfipFacturacionElectronicaConstantes.CONDICION_IVA_VENDEDOR, condicionesIVA, tipoDocumentoFiscal));
                VerificarErrorEnRespuesta(response.Errors);

                return response.CbteNro + 1;
            }
            catch (Exception ex)
            {
                throw new NegocioException($"Error al realizar la facturación. No se pudo obtener el numero de factura.", ex);
            }
        }

        private static CbteAsoc[] ObtenerComprobanteAsociado(CondicionIVA condicionIVA, TipoDocumentoFiscal tipoDocumentoFiscal, int puntoVentaOrigen, int numeroConprobanteOrigen)
        {
            if (tipoDocumentoFiscal == TipoDocumentoFiscal.NotaCredito)
            {
                return new CbteAsoc[]{
                    new CbteAsoc
                    {
                        Tipo = AfipFacturacionElectronica.ObtenerTipoComprobante(AfipFacturacionElectronicaConstantes.CONDICION_IVA_VENDEDOR, condicionIVA, TipoDocumentoFiscal.Factura),
                        PtoVta = puntoVentaOrigen,
                        Nro = numeroConprobanteOrigen
                    }
                };
            }
            else
                return null;
        }


        private static void VerificarErrorEnRespuesta(Afip.Wsfev1.Err[] error)
        {
            if (error != null)
                throw new NegocioException($"{string.Join("\n", error.Select(x =>$"{x.Code} {x.Msg}"))}");
        }

        private static void VerificarObservacionesEnRespuesta(Afip.Wsfev1.FECAEResponse CaeResponse)
        {
            List<string> errores = new List<string>();
            if (CaeResponse.FeCabResp.Resultado != AfipFacturacionElectronicaConstantes.APROBADO && CaeResponse.FeDetResp.Any(x => x.Observaciones.Any()))
            {
                CaeResponse.FeDetResp.ToList().ForEach(x => errores.AddRange(x.Observaciones.Select(y => $"{y.Code}: {y.Msg}")));
                throw new NegocioException(string.Join("\n", errores));
            }
        }
    }
}
