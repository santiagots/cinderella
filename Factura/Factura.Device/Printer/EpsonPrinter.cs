using Common.Core.Enum;
using Factura.Core.Enum;
using Factura.Device.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factura.Device.Printer
{
    public class EpsonPrinter : IDisposable
    {
        private IEpsonTM epsonTM;
        public static string PUNTO_VENTA = "1";
        public static ModeloControladoraFiscal MODELO_CONTROLADORA_FISCAL = ModeloControladoraFiscal.TM_U220FII;
        public static string TIPO_CONEXION = "USB";

        public EpsonPrinter()
        {
            if (MODELO_CONTROLADORA_FISCAL == ModeloControladoraFiscal.TM_U220FII)
            {
                epsonTM = new EpsonTMU220FII(TIPO_CONEXION);
            }
            else
            {
                epsonTM = new EpsonTMT900FA(TIPO_CONEXION);
            }
        }

        public EpsonPrinter(TipoCliente tipoCliente, CondicionIVA condicionesIVA, decimal porcentajeFacturacion, string nombreYApellido, string direccion, string localidad, string cuit)
        {
            if (MODELO_CONTROLADORA_FISCAL == ModeloControladoraFiscal.TM_U220FII)
            {
                epsonTM = new EpsonTMU220FII(TIPO_CONEXION, tipoCliente, condicionesIVA, porcentajeFacturacion, nombreYApellido, direccion, localidad, cuit);
            }
            else
            {
                epsonTM = new EpsonTMT900FA(TIPO_CONEXION, tipoCliente, condicionesIVA, porcentajeFacturacion, nombreYApellido, direccion, localidad, cuit);
            }
        }

        public EpsonPrinter(TipoCliente tipoCliente, CondicionIVA condicionesIVA, decimal porcentajeFacturacion, string nombreYApellido, string direccion, string localidad, string cuit, string comprabanteOriginal, string puntoVentaOrigen, CondicionIVA CondicionIVAOriginal)
        {
            if (MODELO_CONTROLADORA_FISCAL == ModeloControladoraFiscal.TM_U220FII)
            {
                epsonTM = new EpsonTMU220FII(TIPO_CONEXION, tipoCliente, condicionesIVA, porcentajeFacturacion, nombreYApellido, direccion, localidad, cuit, comprabanteOriginal);
            }
            else
            {
                epsonTM = new EpsonTMT900FA(TIPO_CONEXION, tipoCliente, condicionesIVA, porcentajeFacturacion, nombreYApellido, direccion, localidad, cuit, comprabanteOriginal, puntoVentaOrigen, CondicionIVAOriginal);
            }
        }

        public int ObtenreNumeroFactura(List<ProductoTicketRequest> productos, List<PagoTicketRequest> pagos, out string TipoFactura, out decimal MontoTotal, out decimal MontoIvaTotal, out decimal MontoVuelto)
        {
            return epsonTM.ObtenerNumeroFactura(productos, pagos, out TipoFactura, out MontoTotal, out MontoIvaTotal, out MontoVuelto);
        }

        public int ObtenerNumeroNotaCretido(List<ProductoTicketRequest> productos, List<PagoTicketRequest> pagos, out string TipoFactura, out decimal MontoTotal, out decimal MontoIvaTotal, out decimal MontoVuelto)
        {
            return epsonTM.ObtenerNumeroNotaCretido(productos, pagos, out TipoFactura, out MontoTotal, out MontoIvaTotal, out MontoVuelto);
        }

        public void CierreZ()
        {
            epsonTM.CierreZ();
        }

        public void CierreZPorRangoDeFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            epsonTM.CierreZPorRangoDeFecha(fechaDesde, fechaHasta);
        }

        public void CierreZPorRangoDeJornada(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta)
        {
            epsonTM.CierreZPorRangoDeJornada(controladorFiscalJornadaDesde, controladorFiscalJornadaHasta);
        }

        public void CintaTestigoDigitalPorFecha(DateTime fechaDesde, DateTime fechaHasta, out string nombreArchivo, out StringBuilder datos)
        {
            epsonTM.CintaTestigoDigitalPorFecha(fechaDesde, fechaHasta, out nombreArchivo, out datos);
        }

        public void CintaTestigoDigitalPorJornada(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta, out string nombreArchivo, out StringBuilder datos)
        {
            epsonTM.CintaTestigoDigitalPorJornada(controladorFiscalJornadaDesde, controladorFiscalJornadaHasta, out nombreArchivo, out datos);
        }

        public void DuplicadosDocumentosTipoAPorFecha(DateTime fechaDesde, DateTime fechaHasta, out string nombreArchivo, out StringBuilder datos)
        {
            epsonTM.DuplicadosDocumentosTipoAPorFecha(fechaDesde, fechaHasta, out nombreArchivo, out datos);
        }

        public void DuplicadosDocumentosTipoAPorJornada(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta, out string nombreArchivo, out StringBuilder datos)
        {
            epsonTM.DuplicadosDocumentosTipoAPorJornada(controladorFiscalJornadaDesde, controladorFiscalJornadaHasta, out nombreArchivo, out datos);
        }

        public void ResumenTotalesPorRangoDeFecha(DateTime fechaDesde, DateTime fechaHasta, out string nombreArchivo, out StringBuilder datos)
        {
            epsonTM.ResumenTotalesPorRangoDeFecha(fechaDesde, fechaHasta, out nombreArchivo, out datos);
        }

        public void ResumenTotalesPorRangoDeJornadaFiscal(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta, out string nombreArchivo, out StringBuilder datos)
        {
            epsonTM.ResumenTotalesPorRangoDeJornadaFiscal(controladorFiscalJornadaDesde, controladorFiscalJornadaHasta, out nombreArchivo, out datos);
        }

        public void ObtenerMemoriaTransacciones(out int cintaTestigoDigitalDisponiblesDesde, out int cintaTestigoDigitalDisponiblesHasta, out int descargarDuplicadosTipoADisponiblesDesde, out int descargarDuplicadosTipoADisponiblesHasta, out int resumenTotalesDisponiblesDesde, out int resumenTotalesDisponiblesHasta, out int jornadasDescargadasCompletamenteDesde, out int jornadasDescargadasCompletamenteHasta, out int jornadasBorradasDesde, out int jornadasBorradasHasta)
        {
            epsonTM.ObtenerMemoriaTransacciones(out cintaTestigoDigitalDisponiblesDesde, out cintaTestigoDigitalDisponiblesHasta, out descargarDuplicadosTipoADisponiblesDesde, out descargarDuplicadosTipoADisponiblesHasta, out resumenTotalesDisponiblesDesde, out resumenTotalesDisponiblesHasta, out jornadasDescargadasCompletamenteDesde, out jornadasDescargadasCompletamenteHasta, out jornadasBorradasDesde, out jornadasBorradasHasta);
        }

        public void BorradoJornadasMemoriaTransacciones(int borradasJornadasHasta)
        {
            epsonTM.BorradoJornadasMemoriaTransacciones(borradasJornadasHasta);
        }

        public void Informacionjornada()
        {
            epsonTM.Informacionjornada();
        }

        public void ObtenerEstados()
        {
            epsonTM.ObtenerEstados();
        }

        public void Dispose()
        {
            epsonTM.Dispose();
        }
    }
}
