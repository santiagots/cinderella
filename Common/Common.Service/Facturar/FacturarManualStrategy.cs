using System;
using System.Collections.Generic;
using Common.Core.Enum;
using Common.Core.ValueObjects;
using Common.Core.Exceptions;
using System.Text;

namespace Common.Service.Facturar
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

        public List<int> ObtenerNumeroFactura(TipoCliente tipoCliente, CondicionIVA condicionesIVA, List<TicketPago> pagos, IList<TicketProducto> productos, decimal porcentajeFacturacion, string nombreYApellido, string direccion, string localidad, string cuit)
        {
            throw new NegocioException("El metodo de facturacion manual no permite obtener reportes de Cinta Testigo Digital");
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
    }
}
