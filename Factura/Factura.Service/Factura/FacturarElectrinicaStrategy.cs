using Common.Core.Enum;
using Common.Core.Exceptions;
using Common.Core.Helper;
using Common.Core.Model;
using Factura.ExternalService;
using Factura.ExternalService.Contracts;
using Factura.Service.Common.Contracts;
using Factura.Service.Factura.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factura.Service.Factura
{
    public class FacturarElectrinicaStrategy : IFacturarStrategy
    {
        private static string PasswordCertificado;
        private string RutaCertificado;

        public FacturarElectrinicaStrategy(string rutaCertificado, string passwordCertificado)
        {
            RutaCertificado = rutaCertificado;
            PasswordCertificado = passwordCertificado;
        }

        public void ObtenerCierreZ()
        {
            throw new NegocioException("El metodo de facturación electrónico no se encuentra implementado");
        }

        public void ObtenerCierreZPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            throw new NegocioException("El metodo de facturación electrónico no se encuentra implementado");
        }

        public void ObtenerCierreZPorJornadaFiscal(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta)
        {
            throw new NegocioException("El metodo de facturación electrónico no se encuentra implementado");
        }

        public void ObtenerCintaTestigoDigitalPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            throw new NegocioException("El metodo de facturación electrónico no se encuentra implementado");
        }

        public void ObtenerCintaTestigoDigitalPorFecha(DateTime fechaDesde, DateTime fechaHasta, out string nombre, out StringBuilder datos)
        {
            throw new NegocioException("El metodo de facturación electrónico no se encuentra implementado");
        }

        public void ObtenerCintaTestigoDigitalPorJornada(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta, out string nombre, out StringBuilder datos)
        {
            throw new NegocioException("El metodo de facturación electrónico no se encuentra implementado");
        }

        public ObtenerNumeroFacturaResponse ObtenerNumeroFactura(ObtenerNumeroFacturaRequest request)
        {
            List<AfipAlicuotaIvaRequest> alicuotasIva = ObtenerAfipAlicuotaIvaRequest(request.CondicionIVA, request.Productos, request.PorcentajeFacturacion);

            AfipObtenerCAERequest afipObtenerCAERequest = new AfipObtenerCAERequest()
            {
                TipoDocumentoFiscal = TipoDocumentoFiscal.Factura,
                TipoCliente = request.TipoCliente,
                CondicionIVA = request.CondicionIVA,
                Cuit = request.Cuit,
                ImporteNeto = alicuotasIva.Sum(x => x.Monto),
                AlicuotasIva = alicuotasIva,
                PasswordCertificado = PasswordCertificado,
                RutaCertificado = RutaCertificado 
            };

            AfipObtenerCAEResponse response = AfipFacturacionElectronicaService.ObtenerCEA(afipObtenerCAERequest);

            return new ObtenerNumeroFacturaResponse()
            {
                SubTotal = response.Subtotal,
                Iva = response.Iva,
                Total = response.Total,
                CAE = response.Codigo,
                FechaVencimientoCAE = response.FechaVencimiento,
                NumeroFactura = new List<int>() { response.NumeroComprobante }
            };
        }

        public void ResumenTotalesPorRangoDeFecha(DateTime fechaDesde, DateTime fechaHasta, out string nombre, out StringBuilder datos)
        {
            throw new NegocioException("El metodo de facturación electrónico no se encuentra implementado");
        }

        public void ResumenTotalesPorRangoDeJornadaFiscal(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta, out string nombre, out StringBuilder datos)
        {
            throw new NegocioException("El metodo de facturación electrónico no se encuentra implementado");
        }

        public void DuplicadosDocumentosTipoAPorFecha(DateTime fechaDesde, DateTime fechaHasta, out string nombre, out StringBuilder datos)
        {
            throw new NegocioException("El metodo de facturación electrónico no se encuentra implementado");
        }

        public void DuplicadosDocumentosTipoAPorJornada(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta, out string nombre, out StringBuilder datos)
        {
            throw new NegocioException("El metodo de facturación electrónico no se encuentra implementado");
        }

        public void ObtenerMemoriaTransacciones(out int cintaTestigoDigitalDisponiblesDesde, out int cintaTestigoDigitalDisponiblesHasta, out int descargarDuplicadosTipoADisponiblesDesde, out int descargarDuplicadosTipoADisponiblesHasta, out int resumenTotalesDisponiblesDesde, out int resumenTotalesDisponiblesHasta, out int jornadasDescargadasCompletamenteDesde, out int jornadasDescargadasCompletamenteHasta, out int jornadasBorradasDesde, out int jornadasBorradasHasta)
        {
            throw new NegocioException("El metodo de facturación electrónico no se encuentra implementado");
        }

        public void BorradoJornadasMemoriaTransacciones(int borradasJornadasHasta)
        {
            throw new NegocioException("El metodo de facturación electrónico no se encuentra implementado");
        }

        private List<AfipAlicuotaIvaRequest> ObtenerAfipAlicuotaIvaRequest(CondicionIVA condicionIVA, List<ProductoRequest> Productos, decimal PorcentajeFacturacion)
        {
            List<AfipAlicuotaIvaRequest> alicuotasIva = new List<AfipAlicuotaIvaRequest>();
            List<IGrouping<IVA, ProductoRequest>> grupos = Productos.GroupBy(x => x.IVA).ToList();

            foreach(IGrouping<IVA, ProductoRequest> grupo in grupos)
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
    }
}
