using Common.Core.Enum;
using Common.Core.Exceptions;
using System.Collections.Generic;
using Common.Core.ValueObjects;
using System;
using System.Linq;
using System.Text;
using Common.ExternalService;
using Common.Service.Facturar.Contracts;
using Common.ExternalService.Contracts;
using Common.Core.Constants;

namespace Common.Service.Facturar
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

        public ObtenerNumeroFacturaResponse ObtenerNumeroFactura(TipoCliente tipoCliente, CondicionIVA condicionesIVA, List<TicketPago> pagos, IList<TicketProducto> productos, decimal porcentajeFacturacion, string nombreYApellido, string direccion, string localidad, string cuit)
        {
            AfipCAEResponse response = AfipFacturacionElectronicaService.ObtenerCEA(tipoCliente, 
                TipoDocumentoFiscal.Factura,
                condicionesIVA,
                productos,
                porcentajeFacturacion,
                cuit);

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

        private decimal ObtenerMonto(TipoCliente tipoCliente, List<TicketPago> pagos, decimal porcentajeFacturacion)
        {
            switch (tipoCliente)
            {
                case TipoCliente.Minorista:
                    return Math.Round(pagos.Sum(x => x.Total) / (1 + Constants.IVA), 1); //obtengo el total sin el iva
                case TipoCliente.Mayorista:
                    return Math.Round(pagos.Sum(x => x.Total) * porcentajeFacturacion, 1);
                default:
                    throw new InvalidOperationException($"Error al realizar la facturación. Tipo de cliente no reconocido {tipoCliente.ToString()}");
            }
        }
    }
}
