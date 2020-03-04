using Common.Core.Enum;
using Common.Core.Exceptions;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using Common.Core.Constants;
using Factura.Service.Factura.Contracts;
using Factura.ExternalService;
using Factura.ExternalService.Contracts;
using Factura.Service.Common.Contracts;

namespace Factura.Service.Factura
{
    public class FacturarElectrinicaStrategy : IFacturarStrategy
    {
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
            AfipObtenerCAERequest afipObtenerCAERequest = new AfipObtenerCAERequest()
            {
                TipoDocumentoFiscal = TipoDocumentoFiscal.Factura,
                TipoCliente = request.TipoCliente,
                CondicionIVA = request.CondicionIVA,
                Cuit = request.Cuit,
                ImporteNeto = request.Productos.Sum( x => x.Neto),
                AlicuotasIva = ObtenerAfipAlicuotaIvaRequest(request.TipoCliente, request.Productos)
            };

            AfipObtenerCAEResponse response = AfipFacturacionElectronicaService.ObtenerCEA(afipObtenerCAERequest);

            return new ObtenerNumeroFacturaResponse()
            {
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

        private List<AfipAlicuotaIvaRequest> ObtenerAfipAlicuotaIvaRequest(TipoCliente tipoCliente, List<ProductoRequest> Productos)
        {
            return Productos
                .GroupBy(x => x.IVA)
                .Select(g => new AfipAlicuotaIvaRequest()
                {
                    Codigo = g.Key.Id,
                    Monto = ObtenerMontoSegunTipoDeCliente(g.Sum(y => y.Neto), g.Key.Valor, tipoCliente),
                    IvaMonto = Math.Round(ObtenerMontoSegunTipoDeCliente(g.Sum(y => y.Neto), g.Key.Valor, tipoCliente) * g.Key.Valor, 1, MidpointRounding.AwayFromZero)
                }).ToList();
        }

        internal decimal ObtenerMontoSegunTipoDeCliente(decimal monto, decimal iva, TipoCliente tipoCliente)
        {
            switch (tipoCliente)
            {
                case TipoCliente.Minorista:
                    return Math.Round(monto / (1+iva), 1, MidpointRounding.AwayFromZero);
                case TipoCliente.Mayorista:
                    return monto;
                default:
                    throw new InvalidOperationException($"Error al realizar la facturación. Tipo de cliente no reconocido {tipoCliente.ToString()}");
            }
        }
    }
}
