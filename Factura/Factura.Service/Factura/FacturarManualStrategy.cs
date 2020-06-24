using System;
using System.Collections.Generic;
using Common.Core.Enum;
using Common.Core.Exceptions;
using System.Text;
using Factura.Service.Factura.Contracts;
using System.Linq;
using Common.Core.Helper;

namespace Factura.Service.Factura
{
    class FacturarManualStrategy : IFacturarStrategy
    {
        public void ObtenerCierreZ()
        {
            throw new InvalidOperationException();
        }

        public void ObtenerCierreZPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            throw new NegocioException("El metodo de facturacion manual no permite obtener reportes de cierre Z");
        }

        public void ObtenerCierreZPorJornadaFiscal(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta)
        {
            throw new NegocioException("El metodo de facturacion manual no permite obtener reportes de cierre Z");
        }

        public void ObtenerCintaTestigoDigitalPorFecha(DateTime fechaDesde, DateTime fechaHasta, out string nombre, out StringBuilder datos)
        {
            throw new NegocioException("El metodo de facturacion manual no permite obtener reportes de Cinta Testigo Digital");
        }

        public void ObtenerCintaTestigoDigitalPorJornada(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta, out string nombre, out StringBuilder datos)
        {
            throw new NegocioException("El metodo de facturacion manual no permite obtener reportes de Cinta Testigo Digital");
        }

        public ObtenerNumeroFacturaResponse ObtenerNumeroFactura(ObtenerNumeroFacturaRequest request)
        {
            decimal subTotal = 0;
            decimal iva = 0;

            request.Productos.ForEach(x => {
                decimal montoSinIva = Monto.ObtenerMontoSegunTipoDeCliente(x.NetoTotal, x.IVA.Valor, request.CondicionIVA);
                subTotal += montoSinIva;
                iva += montoSinIva * x.IVA.Valor;
            });
                       
            return new ObtenerNumeroFacturaResponse()
            {
                SubTotal = Monto.Redondeo(subTotal),
                Iva = Monto.Redondeo(iva),
                Total = Monto.Redondeo(subTotal + iva),
                NumeroFactura = request.NumerosFacturas
            };
        }

        public void ResumenTotalesPorRangoDeFecha(DateTime fechaDesde, DateTime fechaHasta, out string nombre, out StringBuilder datos)
        {
            throw new NegocioException("El metodo de facturacion manual no permite obtener reportes de Resumen Totales");
        }

        public void ResumenTotalesPorRangoDeJornadaFiscal(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta, out string nombre, out StringBuilder datos)
        {
            throw new NegocioException("El metodo de facturacion manual no permite obtener reportes de Resumen Totales");
        }

        public void DuplicadosDocumentosTipoAPorFecha(DateTime fechaDesde, DateTime fechaHasta, out string nombre, out StringBuilder datos)
        {
            throw new NegocioException("El metodo de facturacion manual no permite obtener reportes de Duplicados Documentos Tipo A");
        }

        public void DuplicadosDocumentosTipoAPorJornada(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta, out string nombre, out StringBuilder datos)
        {
            throw new NegocioException("El metodo de facturacion manual no permite obtener reportes de Duplicados Documentos Tipo A");
        }

        public void ObtenerMemoriaTransacciones(out int cintaTestigoDigitalDisponiblesDesde, out int cintaTestigoDigitalDisponiblesHasta, out int descargarDuplicadosTipoADisponiblesDesde, out int descargarDuplicadosTipoADisponiblesHasta, out int resumenTotalesDisponiblesDesde, out int resumenTotalesDisponiblesHasta, out int jornadasDescargadasCompletamenteDesde, out int jornadasDescargadasCompletamenteHasta, out int jornadasBorradasDesde, out int jornadasBorradasHasta)
        {
            throw new NegocioException("El metodo de facturacion manual no permite obtener el estado de la Memoria de Transacciones");
        }

        public void BorradoJornadasMemoriaTransacciones(int borradasJornadasHasta)
        {
            throw new NegocioException("El metodo de facturacion manual no permite borrar jornadas de la Memoria de Transacciones");
        }
    }
}
