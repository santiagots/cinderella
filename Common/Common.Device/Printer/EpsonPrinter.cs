﻿using Common.Core.Constants;
using Common.Core.Enum;
using Common.Core.Exceptions;
using EpsonFPHostControlX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Common.Device.Printer
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

        public void AbrirTicket()
        {
            epsonTM.AbrirTicket();
        }

        public void AbrirNotaCredito()
        {
            epsonTM.AbrirNotaCredito();
        }

        public int CerrarTicket()
        {
            return epsonTM.CerrarTicket();
        }

        public int CerrarNotaCredito()
        {
            return epsonTM.CerrarNotaCredito();
        }

        public void SubtotalTicket()
        {
            epsonTM.SubtotalTicket();
        }

        public void SubtotalNotaCredito()
        {
            epsonTM.SubtotalNotaCredito();
        }

        public void DescuentosTicket(string descripcion, decimal descuento)
        {
            epsonTM.DescuentosTicket(descripcion, descuento);
        }

        public void RecargosTicket(string descripcion, decimal recargo)
        {
            epsonTM.RecargosTicket(descripcion, recargo);
        }

        public void DescuentosNotaCredito(string descripcion, decimal descuento)
        {
            epsonTM.DescuentosNotaCredito(descripcion, descuento);
        }

        public void RecargosNotaCredito(string descripcion, decimal recargo)
        {
            epsonTM.RecargosNotaCredito(descripcion, recargo);
        }

        public void PagarTicket(TipoPago TipoPago, int numeroCuotas, decimal montoPago)
        {
            epsonTM.PagarTicket(TipoPago, numeroCuotas, montoPago);
        }

        public void AgregarItemTicket(string codigoItem, string descripcion, int cantidad, decimal precioUnitario)
        {
            epsonTM.AgregarItemTicket(codigoItem, descripcion, cantidad, precioUnitario);
        }

        public void AgregarItemNotaCredito(string codigoItem, string descripcion, int cantidad, decimal precioUnitario)
        {
            epsonTM.AgregarItemNotaCredito(codigoItem, descripcion, cantidad, precioUnitario);
        }

        public void CierreX()
        {
            epsonTM.CierreX();
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
