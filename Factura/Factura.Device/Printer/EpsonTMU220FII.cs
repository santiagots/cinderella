using Common.Core.Enum;
using Common.Core.Exceptions;
using Factura.Device.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factura.Device.Printer
{
    internal class EpsonTMU220FII : EpsonTMBase, IEpsonTM
    {
        internal EpsonTMU220FII(string tipoConexionControladora, TipoCliente tipoCliente, CondicionIVA condicionesIVA, decimal porcentajeFacturacion, string nombreYApellido, string direccion, string localidad, string cuit):
            this(tipoConexionControladora)
        {
            NombreComprador1 = nombreYApellido;
            NombreComprador2 = "";
            DomicilioComprador1 = direccion;
            DomicilioComprador2 = localidad;
            DomicilioComprador3 = "";
            TasaIva = TASA_IVA;

            switch (condicionesIVA)
            {
                case CondicionIVA.Consumidor_Final:
                    ConfigurarLineaEncabezado(11, string.Empty);
                    ConfigurarLineaEncabezado(12, string.Empty);

                    ConfigurarLineaCola(4, string.Empty);
                    ConfigurarLineaCola(5, string.Empty);

                    TipoDocumentoComprador = DNI;
                    NumeroDocumentoComprador = cuit;
                    ResponsableIvaComprador = CONSUMIDOR_FINAL;
                    break;
                case CondicionIVA.Monotributo:
                    ConfigurarLineaEncabezado(11, "RECEPTOR DEL COMPROBANTE");
                    ConfigurarLineaEncabezado(12, "RESPONSABLE MONOTRIBUTO");

                    ColaRemplazo1 =        "El crédito fiscal discriminado en el pre";
                    ColaRemplazo2 =        "sente comprobante, sólo podrá ser comput";
                    ColaRemplazo3 =        "ado a efectos del Régimen de Sostenimien";
                    ConfigurarLineaCola(4, "to e Inclusión Fiscal para Pequeños Cont");
                    ConfigurarLineaCola(5, "ribuyentes de la Ley N 27.618");

                    LineaRemitoAsociados1 = ".";
                    TipoDocumentoComprador = CUIT;
                    NumeroDocumentoComprador = cuit;
                    ResponsableIvaComprador = ObtenerResponsableIvaComprador(condicionesIVA);
                    break;
                case CondicionIVA.Responsable_Inscripto:
                case CondicionIVA.Exento:
                default:
                    ConfigurarLineaEncabezado(11, string.Empty);
                    ConfigurarLineaEncabezado(12, string.Empty);

                    ConfigurarLineaCola(4, string.Empty);
                    ConfigurarLineaCola(5, string.Empty);

                    LineaRemitoAsociados1 = ".";
                    TipoDocumentoComprador = CUIT;
                    NumeroDocumentoComprador = cuit;
                    ResponsableIvaComprador = ObtenerResponsableIvaComprador(condicionesIVA);
                    break;
            }

            TipoCliente = tipoCliente;
            PorcentajeFacturacion = porcentajeFacturacion;
        }

        public EpsonTMU220FII(string tipoConexionControladora, TipoCliente tipoCliente, CondicionIVA condicionesIVA, decimal porcentajeFacturacion, string nombreYApellido, string direccion, string localidad, string cuit, string comprabanteOriginal)
            : this(tipoConexionControladora, tipoCliente, condicionesIVA, porcentajeFacturacion, nombreYApellido, direccion, localidad, cuit)
        {
            ComprabanteOriginal = comprabanteOriginal;
        }

        public EpsonTMU220FII(string tipoConexionControladora)
        {
            Initialize(tipoConexionControladora);
        }

        public int ObtenerNumeroFactura(List<ProductoTicketRequest> productos, List<PagoTicketRequest> pagos, out string TipoFactura, out decimal MontoTotal, out decimal MontoIvaTotal, out decimal MontoVuelto)
        {
            AbrirTicket();
            productos.ForEach(x => AgregarItemTicket(x.Codigo, x.Nombre, x.Cantidad, x.Neto, x.IVA));
            pagos.ForEach(x => PagarTicket(x.TipoPago, x.NumeroCuotas, x.Neto(PorcentajeFacturacion)));
            return CerrarTicket(out TipoFactura, out MontoTotal, out MontoIvaTotal, out MontoVuelto);
        }

        public int ObtenerNumeroNotaCretido(List<ProductoTicketRequest> productos, List<PagoTicketRequest> pagos, out string TipoFactura, out decimal MontoTotal, out decimal MontoIvaTotal, out decimal MontoVuelto)
        {
            AbrirNotaCredito();
            productos.ForEach(x => AgregarItemNotaCredito(x.Codigo, x.Nombre, x.Cantidad, x.Neto, x.IVA));
            return CerrarNotaCredito(out TipoFactura, out MontoTotal, out MontoIvaTotal, out MontoVuelto);
        }
       
        // Funcion que Abre un Tique.
        public void AbrirTicket()
        {
            var commands = new List<string>();

            commands.Add(EpsonTMU220FIICommand.AbrirTicket.Cmd);
            commands.Add(EpsonTMU220FIICommand.AbrirTicket.CmdExt);
            commands.Add(NombreComprador1);
            commands.Add(NombreComprador2);
            commands.Add(DomicilioComprador1);
            commands.Add(DomicilioComprador2);
            commands.Add(DomicilioComprador3);
            commands.Add(TipoDocumentoComprador);
            commands.Add(NumeroDocumentoComprador);
            commands.Add(ResponsableIvaComprador);
            commands.Add(LineaRemitoAsociados1);
            commands.Add(LineaRemitoAsociados2);
            commands.Add("");
            SendData(commands);
        }

        // Funcion que Abre una Nota de Credito.
        public void AbrirNotaCredito()
        {
            var commands = new List<string>();

            commands.Add(EpsonTMU220FIICommand.AbrirNotaCredito.Cmd);
            commands.Add(EpsonTMU220FIICommand.AbrirNotaCredito.CmdExt);
            commands.Add(NombreComprador1);
            commands.Add(NombreComprador2);
            commands.Add(DomicilioComprador1);
            commands.Add(DomicilioComprador2);
            commands.Add(DomicilioComprador3);
            commands.Add(TipoDocumentoComprador);
            commands.Add(NumeroDocumentoComprador);
            commands.Add(ResponsableIvaComprador);
            commands.Add(LineaRemitoAsociados1);
            commands.Add(LineaRemitoAsociados2);
            commands.Add(ComprabanteOriginal);
            SendData(commands);
        }


        // Funcion que Cierra un Tique.
        public int CerrarTicket(out string TipoFactura, out decimal MontoTotal, out decimal MontoIvaTotal, out decimal MontoVuelto)
        {
            var commands = new List<string>();

            commands.Add(EpsonTMU220FIICommand.CerraTicket.Cmd);
            commands.Add(EpsonTMU220FIICommand.CerraTicket.CmdExt);
            commands.Add("1");
            commands.Add(ReemplazarCaracteres(ColaRemplazo1));
            commands.Add("2");
            commands.Add(ReemplazarCaracteres(ColaRemplazo2));
            commands.Add("3");
            commands.Add(ReemplazarCaracteres(ColaRemplazo3));
            SendData(commands/*, false*/);
            int numeroTicket = int.Parse(GetExtraField(1));
            TipoFactura = GetExtraField(2);
            MontoTotal = FormatearPrecio(GetExtraField(3));
            MontoIvaTotal = FormatearPrecio(GetExtraField(4));
            MontoVuelto = FormatearPrecio(GetExtraField(5));
            return numeroTicket;
        }

        // Funcion que Cierra un Tique.
        public int CerrarNotaCredito(out string TipoFactura, out decimal MontoTotal, out decimal MontoIvaTotal, out decimal MontoVuelto)
        {
            var commands = new List<string>();

            commands.Add(EpsonTMU220FIICommand.CerraNotaCredito.Cmd);
            commands.Add(EpsonTMU220FIICommand.CerraNotaCredito.CmdExt);
            commands.Add("1");
            commands.Add(ReemplazarCaracteres(ColaRemplazo1));
            commands.Add("2");
            commands.Add(ReemplazarCaracteres(ColaRemplazo2));
            commands.Add("3");
            commands.Add(ReemplazarCaracteres(ColaRemplazo3));
            commands.Add("");
            SendData(commands/*, false*/);
            int numeroTicket = int.Parse(GetExtraField(1));
            TipoFactura = GetExtraField(2);
            MontoTotal = FormatearPrecio(GetExtraField(3));
            MontoIvaTotal = FormatearPrecio(GetExtraField(4));
            MontoVuelto = FormatearPrecio(GetExtraField(5));
            return numeroTicket;
        }

        // Funcion que obtiene el subtotal de un Tique.
        public void SubtotalTicket()
        {
            var commands = new List<string>();

            commands.Add(EpsonTMU220FIICommand.SubtotalTicket.Cmd);
            commands.Add(EpsonTMU220FIICommand.SubtotalTicket.CmdExt);
            SendData(commands/*, false*/);
        }

        // Funcion que obtiene el subtotal de una Nota de Credito.
        public void SubtotalNotaCredito()
        {
            var commands = new List<string>();

            commands.Add(EpsonTMU220FIICommand.SubtotalNotaCredito.Cmd);
            commands.Add(EpsonTMU220FIICommand.SubtotalNotaCredito.CmdExt);
            SendData(commands/*, false*/);
        }

        // Funcion que Agrega descuentos.
        public void DescuentosTicket(string descripcion, decimal descuento, decimal iva)
        {
            var commands = new List<string>();

            commands.Add(EpsonTMU220FIICommand.DescuentoTicket.Cmd);
            commands.Add(EpsonTMU220FIICommand.DescuentoTicket.CmdExt);
            commands.Add(ReemplazarCaracteres($"DTO. {descripcion}"));
            commands.Add(FormatearPrecio(descuento, 2));
            SendData(commands/*, false*/);
        }

        // Funcion que Agrega recargo.
        public void RecargosTicket(string descripcion, decimal recargo, decimal iva)
        {
            var commands = new List<string>();

            commands.Add(EpsonTMU220FIICommand.RecargoTicket.Cmd);
            commands.Add(EpsonTMU220FIICommand.RecargoTicket.CmdExt);
            commands.Add(ReemplazarCaracteres($"AJUSTE {descripcion}"));
            commands.Add(FormatearPrecio(recargo, 2));
            SendData(commands/*, false*/);
        }

        // Funcion que Agrega descuentos a la nota de credito.
        public void DescuentosNotaCredito(string descripcion, decimal descuento, decimal iva)
        {
            var commands = new List<string>();

            commands.Add(EpsonTMU220FIICommand.DescuentoNotaCredito.Cmd);
            commands.Add(EpsonTMU220FIICommand.DescuentoNotaCredito.CmdExt);
            commands.Add(ReemplazarCaracteres(descripcion));
            commands.Add(FormatearPrecio(descuento, 2));
            SendData(commands/*, false*/);
        }

        // Funcion que Agrega recargo.
        public void RecargosNotaCredito(string descripcion, decimal recargo, decimal iva)
        {
            var commands = new List<string>();

            commands.Add(EpsonTMU220FIICommand.RecargoNotaCredito.Cmd);
            commands.Add(EpsonTMU220FIICommand.RecargoNotaCredito.CmdExt);
            commands.Add(ReemplazarCaracteres(descripcion));
            commands.Add(FormatearPrecio(recargo, 2));
            SendData(commands/*, false*/);
        }

        // Funcion que Paga un Tique.
        public void PagarTicket(TipoPago TipoPago, int cantidadCuotas, decimal MontoPago)
        {
            string formaPago = string.Empty;
            if (cantidadCuotas > 0)
                formaPago = $"{TipoPago.ToString()} ({cantidadCuotas.ToString()})";
            else
                formaPago = TipoPago.ToString();

            var commands = new List<string>();

            commands.Add(EpsonTMU220FIICommand.Pago.Cmd);
            commands.Add(EpsonTMU220FIICommand.Pago.CmdExt);
            commands.Add("");
            commands.Add(ReemplazarCaracteres(formaPago));
            commands.Add(FormatearPrecio(MontoPago, 2));
            SendData(commands/*, false*/);
        }

        // Funcion que Agrega un item a un Tique.
        public void AgregarItemTicket(string codigoItem, string descripcion, int cantidad, decimal precioUnitario, decimal iva)
        {
            decimal precioUnitarioTipoCliente = ObtenerMontoSegunTipoDeCliente(precioUnitario, iva);
            var commands = new List<string>();

            if (cantidad >= 0)
            {
                commands.Add(EpsonTMU220FIICommand.ItemTicket.Cmd);
                commands.Add(EpsonTMU220FIICommand.ItemTicket.CmdExt);
            }
            else
            {
                commands.Add(EpsonTMU220FIICommand.ItemTicketRetorno.Cmd);
                commands.Add(EpsonTMU220FIICommand.ItemTicketRetorno.CmdExt);
            }
            commands.Add(DescripcionExtra1);
            commands.Add(DescripcionExtra2);
            commands.Add(DescripcionExtra3);
            commands.Add(DescripcionExtra4);
            commands.Add(ReemplazarCaracteres(descripcion));
            commands.Add(FormatearCantidad(Math.Abs(cantidad)));
            commands.Add(FormatearPrecio(precioUnitarioTipoCliente));
            commands.Add(FormatearIVA(iva));
            commands.Add(IMPUESTOINTERNOFIJO);
            commands.Add(IMPUESTOINTERNOPORCENTUAL);
            SendData(commands/*, false*/);
        }

        // Funcion que Agrega un item a una Nota de Credito.
        public void AgregarItemNotaCredito(string codigoItem, string descripcion, int cantidad, decimal precioUnitario, decimal iva)
        {
            decimal precioUnitarioTipoCliente = ObtenerMontoSegunTipoDeCliente(precioUnitario, iva);
            var commands = new List<string>();

            if (cantidad >= 0)
            {
                commands.Add(EpsonTMU220FIICommand.ItemNotaCredito.Cmd);
                commands.Add(EpsonTMU220FIICommand.ItemNotaCredito.CmdExt);
            }
            else
            {
                commands.Add(EpsonTMU220FIICommand.ItemNotaCreditoRetorno.Cmd);
                commands.Add(EpsonTMU220FIICommand.ItemNotaCreditoRetorno.CmdExt);
            }
            commands.Add(DescripcionExtra1);
            commands.Add(DescripcionExtra2);
            commands.Add(DescripcionExtra3);
            commands.Add(DescripcionExtra4);
            commands.Add(ReemplazarCaracteres(descripcion));
            commands.Add(FormatearCantidad(Math.Abs(cantidad)));
            commands.Add(FormatearPrecio(precioUnitarioTipoCliente));
            commands.Add(FormatearIVA(iva));
            commands.Add(IMPUESTOINTERNOFIJO);
            commands.Add(IMPUESTOINTERNOPORCENTUAL);
            SendData(commands/*, false*/);
        }

        // Funcion que emite el Cierre X en la controladora
        public void CierreX()
        {
            var commands = new List<string>();

            commands.Add(EpsonTMU220FIICommand.CierreDeCaja.Cmd);
            commands.Add(EpsonTMU220FIICommand.CierreDeCaja.CmdExt);
            SendData(commands);
        }

        // Funcion que emite el Cierre Z en la controladora
        public void CierreZ()
        {
            var commands = new List<string>();

            commands.Add(EpsonTMU220FIICommand.CierreZ.Cmd);
            commands.Add(EpsonTMU220FIICommand.CierreZ.CmdExt);
            SendData(commands);
        }

        public void CierreZPorRangoDeFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            var commands = new List<string>();

            commands.Add(EpsonTMU220FIICommand.CierreZPorRangoDeFecha.Cmd);
            commands.Add(EpsonTMU220FIICommand.CierreZPorRangoDeFecha.CmdExt);
            commands.Add(fechaDesde.ToString("ddMMyy"));
            commands.Add(fechaHasta.ToString("ddMMyy"));
            SendData(commands);
        }

        // Funcion que Configura la linea de Encabezado.
        public void ConfigurarLineaEncabezado(int numeroDeColaDeLinea, string texto)
        {
            var commands = new List<string>();

            commands.Add(EpsonTMU220FIICommand.ConfigurarLineaEncabezado.Cmd);
            commands.Add(EpsonTMU220FIICommand.ConfigurarLineaEncabezado.CmdExt);
            commands.Add(numeroDeColaDeLinea.ToString());
            commands.Add(ReemplazarCaracteres(texto));
            SendData(commands);
        }

        // Funcion que Configura la linea de cola.
        public void ConfigurarLineaCola(int numeroDeColaDeLinea, string texto)
        {
            var commands = new List<string>();

            commands.Add(EpsonTMU220FIICommand.ConfigurarLineaCola.Cmd);
            commands.Add(EpsonTMU220FIICommand.ConfigurarLineaCola.CmdExt);
            commands.Add(numeroDeColaDeLinea.ToString());
            commands.Add(ReemplazarCaracteres(texto));
            SendData(commands);
        }


        public void CintaTestigoDigitalPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            throw new NegocioException("El modelo de impresoras EPSON TMU 220 FII no soporta este comando.");
        }

        public void CintaTestigoDigitalPorJornada(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta)
        {
            throw new NegocioException("El modelo de impresoras EPSON TMU 220 FII no soporta este comando.");
        }

        public void CintaTestigoDigitalPorFecha(DateTime fechaDesde, DateTime fechaHasta, out string nombreArchivo, out StringBuilder datos)
        {
            throw new NegocioException("El modelo de impresoras EPSON TMU 220 FII no soporta este comando.");
        }

        public void CintaTestigoDigitalPorJornada(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta, out string nombreArchivo, out StringBuilder datos)
        {
            throw new NegocioException("El modelo de impresoras EPSON TMU 220 FII no soporta este comando.");
        }

        public void DuplicadosDocumentosTipoAPorFecha(DateTime fechaDesde, DateTime fechaHasta, out string nombreArchivo, out StringBuilder datos)
        {
            throw new NegocioException("El modelo de impresoras EPSON TMU 220 FII no soporta este comando.");
        }

        public void DuplicadosDocumentosTipoAPorJornada(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta, out string nombreArchivo, out StringBuilder datos)
        {
            throw new NegocioException("El modelo de impresoras EPSON TMU 220 FII no soporta este comando.");
        }

        public void ResumenTotalesPorRangoDeFecha(DateTime fechaDesde, DateTime fechaHasta, out string nombreArchivo, out StringBuilder datos)
        {
            throw new NegocioException("El modelo de impresoras EPSON TMU 220 FII no soporta este comando.");
        }

        public void ResumenTotalesPorRangoDeJornadaFiscal(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta, out string nombreArchivo, out StringBuilder datos)
        {
            throw new NegocioException("El modelo de impresoras EPSON TMU 220 FII no soporta este comando.");
        }

        public void ObtenerMemoriaTransacciones(out int cintaTestigoDigitalDisponiblesDesde, out int cintaTestigoDigitalDisponiblesHasta, out int descargarDuplicadosTipoADisponiblesDesde, out int descargarDuplicadosTipoADisponiblesHasta, out int resumenTotalesDisponiblesDesde, out int resumenTotalesDisponiblesHasta, out int jornadasDescargadasCompletamenteDesde, out int jornadasDescargadasCompletamenteHasta, out int jornadasBorradasDesde, out int jornadasBorradasHasta)
        {
            throw new NegocioException("El modelo de impresoras EPSON TMU 220 FII no soporta este comando.");
        }

        public void BorradoJornadasMemoriaTransacciones(int borradasJornadasHasta)
        {
            throw new NegocioException("El modelo de impresoras EPSON TMU 220 FII no soporta este comando.");
        }

        public void CierreZPorRangoDeJornada(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta)
        {
            var commands = new List<string>();

            commands.Add(EpsonTMU220FIICommand.CierreZPorRangoDeJornada.Cmd);
            commands.Add(EpsonTMU220FIICommand.CierreZPorRangoDeJornada.CmdExt);
            commands.Add(controladorFiscalJornadaDesde.ToString());
            commands.Add(controladorFiscalJornadaHasta.ToString());
            SendData(commands);
        }

        public void Informacionjornada()
        {
            var commands = new List<string>();

            commands.Add(EpsonTMU220FIICommand.Informacionjornada.Cmd);
            commands.Add(EpsonTMU220FIICommand.Informacionjornada.CmdExt);
            SendData(commands);
        }

        public void ObtenerEstados()
        {
            var commands = new List<string>();

            commands.Add(EpsonTMU220FIICommand.ObtenerEstadoImpresora.Cmd);
            commands.Add(EpsonTMU220FIICommand.ObtenerEstadoImpresora.CmdExt);
            SendData(commands);
        }
    }
}
