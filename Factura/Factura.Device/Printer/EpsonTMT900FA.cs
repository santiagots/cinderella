using Common.Core.Enum;
using Factura.Device.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factura.Device.Printer
{
    internal class EpsonTMT900FA : EpsonTMBase, IEpsonTM
    {
        internal EpsonTMT900FA(string tipoConexionControladora, TipoCliente tipoCliente, CondicionIVA condicionesIVA, decimal porcentajeFacturacion, string nombreYApellido, string direccion, string localidad, string cuit): 
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
                    TipoDocumentoComprador = DNI;
                    NumeroDocumentoComprador = cuit;
                    ResponsableIvaComprador = CONSUMIDOR_FINAL;
                    break;
                case CondicionIVA.Monotributo:
                case CondicionIVA.Responsable_Inscripto:
                case CondicionIVA.Exento:
                default:
                    LineaRemitoAsociados1 = "903-00001-00000001";
                    TipoDocumentoComprador = CUIT;
                    NumeroDocumentoComprador = cuit;
                    ResponsableIvaComprador = ObtenerResponsableIvaComprador(condicionesIVA);
                    break;
            }

            TipoCliente = tipoCliente;
            PorcentajeFacturacion = porcentajeFacturacion;
        }

        public EpsonTMT900FA(string tipoConexionControladora, TipoCliente tipoCliente, CondicionIVA condicionesIVA, decimal porcentajeFacturacion, string nombreYApellido, string direccion, string localidad, string cuit, string comprabanteOriginal, string PuntoVentaOrigen, CondicionIVA CondicionIVAOriginal)
            : this(tipoConexionControladora, tipoCliente, condicionesIVA, porcentajeFacturacion, nombreYApellido, direccion, localidad, cuit)
        {
            LineaRemitoAsociados1 = "";
            ComprabanteOriginal = obtenerComprobanteOriginal(CondicionIVAOriginal, PuntoVentaOrigen, comprabanteOriginal);
        }

        public EpsonTMT900FA(string tipoConexionControladora)
        {
            Initialize(tipoConexionControladora);
        }

        public int ObtenreNumeroFactura(List<ProductoTicketRequest> productos, List<PagoTicketRequest> pagos, out string TipoFactura, out decimal MontoTotal, out decimal MontoIvaTotal, out decimal MontoVuelto)
        {
            AbrirTicket();
            productos.ForEach(x => AgregarItemTicket(x.Codigo, x.Nombre, x.Cantidad, x.Monto, x.IVA));
            productos.ForEach(x => {
                if (x.Descuento > 0)
                    DescuentosTicket(x.Nombre, x.Descuento * x.Cantidad, x.IVA);

                if (x.CFT > 0)
                    RecargosTicket(x.Nombre, x.CFT * x.Cantidad, x.IVA);
            });

            SubtotalTicket();

            pagos.ForEach(x => PagarTicket(x.TipoPago, x.NumeroCuotas, x.Neto(PorcentajeFacturacion)));

            return CerrarTicket(out TipoFactura, out MontoTotal, out MontoIvaTotal, out MontoVuelto);
        }

        public int ObtenerNumeroNotaCretido(List<ProductoTicketRequest> productos, List<PagoTicketRequest> pagos)
        {
            AbrirNotaCredito();
            productos.ForEach(x => AgregarItemNotaCredito(x.Codigo, x.Nombre, x.Cantidad, x.Monto, x.IVA));
            productos.ForEach(x => {
                if (x.Descuento > 0)
                    DescuentosNotaCredito(x.Nombre, x.Descuento, x.IVA);

                if (x.CFT > 0)
                    RecargosNotaCredito(x.Nombre, x.CFT, x.IVA);
            });

            SubtotalNotaCredito();

            return CerrarNotaCredito();
        }

        // Funcion que Abre un Tique.
        public void AbrirTicket()
        {
            var commands = new List<string>();

            commands.Add(EpsonTMT900FACommand.AbrirTicket.Cmd);
            commands.Add(EpsonTMT900FACommand.AbrirTicket.CmdExt);
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
            commands.Add(LineaRemitoAsociados3);
            commands.Add("");
            SendData(commands);
        }

        // Funcion que Abre una Nota de Credito.
        public void AbrirNotaCredito()
        {
            var commands = new List<string>();

            commands.Add(EpsonTMT900FACommand.AbrirNotaCredito.Cmd);
            commands.Add(EpsonTMT900FACommand.AbrirNotaCredito.CmdExt);
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
            commands.Add(LineaRemitoAsociados3);
            commands.Add(ComprabanteOriginal);
            SendData(commands);
        }


        // Funcion que Cierra un Tique.
        public int CerrarTicket(out string TipoFactura, out decimal MontoTotal, out decimal MontoIvaTotal, out decimal MontoVuelto)
        {
            var commands = new List<string>();

            commands.Add(EpsonTMT900FACommand.CerraTicket.Cmd);
            commands.Add(EpsonTMT900FACommand.CerraTicket.CmdExt);
            commands.Add("1");
            commands.Add(ColaRemplazo1);
            commands.Add("2");
            commands.Add(ColaRemplazo2);
            commands.Add("3");
            commands.Add(ColaRemplazo3);
            SendData(commands/*, false*/);
            int numeroTicket = int.Parse(GetExtraField(1));
            TipoFactura = GetExtraField(2);
            MontoTotal = FormatearPrecio(GetExtraField(3));
            MontoIvaTotal = FormatearPrecio(GetExtraField(4));
            MontoVuelto = FormatearPrecio(GetExtraField(5));
            return numeroTicket;
        }

        // Funcion que Cierra un Tique.
        public int CerrarNotaCredito()
        {
            var commands = new List<string>();

            commands.Add(EpsonTMT900FACommand.CerraNotaCredito.Cmd);
            commands.Add(EpsonTMT900FACommand.CerraNotaCredito.CmdExt);
            commands.Add("1");
            commands.Add(ColaRemplazo1);
            commands.Add("2");
            commands.Add(ColaRemplazo2);
            commands.Add("3");
            commands.Add(ColaRemplazo3);
            commands.Add("");
            SendData(commands/*, false*/);
            return int.Parse(GetExtraField(1));
        }

        // Funcion que obtiene el subtotal de un Tique.
        public void SubtotalTicket()
        {
            //var commands = new List<string>();

            //commands.Add(EpsonTMT900FACommand.SubtotalTicket.Cmd);
            //commands.Add(EpsonTMT900FACommand.SubtotalTicket.CmdExt);
            //SendData(commands/*, false*/);
        }

        // Funcion que obtiene el subtotal de una Nota de Credito.
        public void SubtotalNotaCredito()
        {
            //var commands = new List<string>();

            //commands.Add(EpsonTMT900FACommand.SubtotalNotaCredito.Cmd);
            //commands.Add(EpsonTMT900FACommand.SubtotalNotaCredito.CmdExt);
            //SendData(commands/*, false*/);
        }

        // Funcion que Agrega descuentos.
        public void DescuentosTicket(string descripcion, decimal descuento, decimal iva)
        {
            var commands = new List<string>();

            commands.Add(EpsonTMT900FACommand.DescuentoTicket.Cmd);
            commands.Add(EpsonTMT900FACommand.DescuentoTicket.CmdExt);
            commands.Add(ReemplazarCaracteres(descripcion));
            commands.Add(FormatearPrecio(descuento, 2));
            commands.Add(FormatearIVA(iva));
            commands.Add("0");
            commands.Add(GRAVADO);
            SendData(commands/*, false*/);
        }

        // Funcion que Agrega recargo.
        public void RecargosTicket(string descripcion, decimal recargo, decimal iva)
        {
            var commands = new List<string>();

            commands.Add(EpsonTMT900FACommand.RecargoTicket.Cmd);
            commands.Add(EpsonTMT900FACommand.RecargoTicket.CmdExt);
            commands.Add(ReemplazarCaracteres(descripcion));
            commands.Add(FormatearPrecio(recargo, 2));
            commands.Add(FormatearIVA(iva));
            commands.Add("0");
            commands.Add(GRAVADO);
            SendData(commands/*, false*/);
        }

        // Funcion que Agrega descuentos a la nota de credito.
        public void DescuentosNotaCredito(string descripcion, decimal descuento, decimal iva)
        {
            var commands = new List<string>();

            commands.Add(EpsonTMT900FACommand.DescuentoNotaCredito.Cmd);
            commands.Add(EpsonTMT900FACommand.DescuentoNotaCredito.CmdExt);
            commands.Add(ReemplazarCaracteres(descripcion));
            commands.Add(FormatearPrecio(descuento, 2));
            commands.Add(FormatearIVA(iva));
            commands.Add("0");
            commands.Add(GRAVADO);
            SendData(commands/*, false*/);
        }

        // Funcion que Agrega recargo.
        public void RecargosNotaCredito(string descripcion, decimal recargo, decimal iva)
        {
            var commands = new List<string>();

            commands.Add(EpsonTMT900FACommand.RecargoNotaCredito.Cmd);
            commands.Add(EpsonTMT900FACommand.RecargoNotaCredito.CmdExt);
            commands.Add(ReemplazarCaracteres(descripcion));
            commands.Add(FormatearPrecio(recargo, 2));
            commands.Add(FormatearIVA(iva));
            commands.Add("0");
            commands.Add(GRAVADO);
            SendData(commands/*, false*/);
        }

        // Funcion que Paga un Tique.
        public void PagarTicket(TipoPago TipoPago, int cantidadCuotas, decimal MontoPago)
        {
            var commands = new List<string>();

            commands.Add(EpsonTMT900FACommand.Pago.Cmd);
            commands.Add(EpsonTMT900FACommand.Pago.CmdExt);
            commands.Add(cantidadCuotas > 0? cantidadCuotas.ToString(): "");
            commands.Add("");
            commands.Add("");
            commands.Add("");
            commands.Add("");
            commands.Add(ObtenerCodigoFormaPago(TipoPago));
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
                commands.Add(EpsonTMT900FACommand.ItemTicket.Cmd);
                commands.Add(EpsonTMT900FACommand.ItemTicket.CmdExt);
            }
            else
            {
                commands.Add(EpsonTMT900FACommand.ItemTicketRetorno.Cmd);
                commands.Add(EpsonTMT900FACommand.ItemTicketRetorno.CmdExt);
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
            commands.Add("");
            commands.Add("");
            commands.Add(ReemplazarCaracteres(codigoItem));
            commands.Add(POR_UNIDAD);
            commands.Add(GRAVADO);
            SendData(commands/*, false*/);
        }

        // Funcion que Agrega un item a una Nota de Credito.
        public void AgregarItemNotaCredito(string codigoItem, string descripcion, int cantidad, decimal precioUnitario, decimal iva)
        {
            decimal precioUnitarioTipoCliente = ObtenerMontoSegunTipoDeCliente(precioUnitario, iva);
            var commands = new List<string>();

            if (cantidad >= 0)
            {
                commands.Add(EpsonTMT900FACommand.ItemNotaCredito.Cmd);
                commands.Add(EpsonTMT900FACommand.ItemNotaCredito.CmdExt);
            }
            else
            {
                commands.Add(EpsonTMT900FACommand.ItemNotaCreditoRetorno.Cmd);
                commands.Add(EpsonTMT900FACommand.ItemNotaCreditoRetorno.CmdExt);
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
            commands.Add("");
            commands.Add("");
            commands.Add(codigoItem);
            commands.Add(POR_UNIDAD);
            commands.Add(SIN_CONDICION_IVA);
            SendData(commands/*, false*/);
        }

        // Funcion que emite el Cierre X en la controladora
        public void CierreX()
        {
            var commands = new List<string>();

            commands.Add(EpsonTMT900FACommand.CierreDeCaja.Cmd);
            commands.Add(EpsonTMT900FACommand.CierreDeCaja.CmdExt);
            SendData(commands);
        }

        // Funcion que emite el Cierre Z en la controladora
        public void CierreZ()
        {
            var commands = new List<string>();

            commands.Add(EpsonTMT900FACommand.CierreZ.Cmd);
            commands.Add(EpsonTMT900FACommand.CierreZ.CmdExt);
            SendData(commands);
        }

        public void CierreZPorRangoDeFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            var commands = new List<string>();

            //Inicio el reporte
            commands.Add(EpsonTMT900FACommand.CierrZPorRangoDeFecha.Cmd);
            commands.Add(EpsonTMT900FACommand.CierrZPorRangoDeFecha.CmdExt);
            commands.Add(fechaDesde.ToString("ddMMyy"));
            commands.Add(fechaHasta.ToString("ddMMyy"));
            SendData(commands);

            //Fuerzo una continuacion
            commands.Clear();
            commands.Add(EpsonTMT900FACommand.CierrZContinuarReporte.Cmd);
            commands.Add(EpsonTMT900FACommand.CierrZContinuarReporte.CmdExt);
            SendData(commands);

            //Cierro la ejecucion
            commands.Clear();
            commands.Add(EpsonTMT900FACommand.CierrZFinalizarReporte.Cmd);
            commands.Add(EpsonTMT900FACommand.CierrZFinalizarReporte.CmdExt);
            SendData(commands);
        }

        public void CierreZPorRangoDeJornada(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta)
        {
            var commands = new List<string>();

            //Inicio el reporte
            commands.Add(EpsonTMT900FACommand.CierrZPorRangoDeJornadaFiscal.Cmd);
            commands.Add(EpsonTMT900FACommand.CierrZPorRangoDeJornadaFiscal.CmdExt);
            commands.Add(controladorFiscalJornadaDesde.ToString());
            commands.Add(controladorFiscalJornadaHasta.ToString());
            SendData(commands);

            //Fuerzo una continuacion
            commands.Clear();
            commands.Add(EpsonTMT900FACommand.CierrZContinuarReporte.Cmd);
            commands.Add(EpsonTMT900FACommand.CierrZContinuarReporte.CmdExt);
            SendData(commands);

            //Cierro la ejecucion
            commands.Clear();
            commands.Add(EpsonTMT900FACommand.CierrZFinalizarReporte.Cmd);
            commands.Add(EpsonTMT900FACommand.CierrZFinalizarReporte.CmdExt);
            SendData(commands);

        }

        public void CintaTestigoDigitalPorFecha(DateTime fechaDesde, DateTime fechaHasta, out string nombreArchivo, out StringBuilder datos)
        {
            var commands = new List<string>();

            //Inicio el reporte
            commands.Add(EpsonTMT900FACommand.CintaTestigoDigitalPorRangoDeFecha.Cmd);
            commands.Add(EpsonTMT900FACommand.CintaTestigoDigitalPorRangoDeFecha.CmdExt);
            commands.Add(fechaDesde.ToString("ddMMyy"));
            commands.Add(fechaHasta.ToString("ddMMyy"));
            SendData(commands);
            nombreArchivo = GetExtraField(1);
            datos = ObtenerDatosReporte();
        }

        public void CintaTestigoDigitalPorJornada(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta, out string nombreArchivo, out StringBuilder datos)
        {
            var commands = new List<string>();

            //Inicio el reporte
            commands.Add(EpsonTMT900FACommand.CintaTestigoDigitalPorRangoDeJornadaFiscal.Cmd);
            commands.Add(EpsonTMT900FACommand.CintaTestigoDigitalPorRangoDeJornadaFiscal.CmdExt);
            commands.Add(controladorFiscalJornadaDesde.ToString());
            commands.Add(controladorFiscalJornadaHasta.ToString());
            SendData(commands);
            nombreArchivo = GetExtraField(1);
            datos = ObtenerDatosReporte();
        }

        public void DuplicadosDocumentosTipoAPorFecha(DateTime fechaDesde, DateTime fechaHasta, out string nombreArchivo, out StringBuilder datos)
        {
            var commands = new List<string>();

            //Inicio el reporte
            commands.Add(EpsonTMT900FACommand.DuplicadosDocumentosTipoAPorRangoDeFecha.Cmd);
            commands.Add(EpsonTMT900FACommand.DuplicadosDocumentosTipoAPorRangoDeFecha.CmdExt);
            commands.Add(fechaDesde.ToString("ddMMyy"));
            commands.Add(fechaHasta.ToString("ddMMyy"));
            SendData(commands);
            nombreArchivo = GetExtraField(1);
            datos = ObtenerDatosReporte();
        }

        public void DuplicadosDocumentosTipoAPorJornada(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta, out string nombreArchivo, out StringBuilder datos)
        {
            var commands = new List<string>();

            //Inicio el reporte
            commands.Add(EpsonTMT900FACommand.DuplicadosDocumentosTipoAPorRangoDeJornadaFiscal.Cmd);
            commands.Add(EpsonTMT900FACommand.DuplicadosDocumentosTipoAPorRangoDeJornadaFiscal.CmdExt);
            commands.Add(controladorFiscalJornadaDesde.ToString());
            commands.Add(controladorFiscalJornadaHasta.ToString());
            SendData(commands);
            nombreArchivo = GetExtraField(1);
            datos = ObtenerDatosReporte();
        }

        public void ResumenTotalesPorRangoDeFecha(DateTime fechaDesde, DateTime fechaHasta, out string nombreArchivo, out StringBuilder datos)
        {
            var commands = new List<string>();

            //Inicio el reporte
            commands.Add(EpsonTMT900FACommand.ResumenTotalesPorRangoDeFecha.Cmd);
            commands.Add(EpsonTMT900FACommand.ResumenTotalesPorRangoDeFecha.CmdExt);
            commands.Add(fechaDesde.ToString("ddMMyy"));
            commands.Add(fechaHasta.ToString("ddMMyy"));
            SendData(commands);
            nombreArchivo = GetExtraField(1);
            datos = ObtenerDatosReporte();
        }

        public void ResumenTotalesPorRangoDeJornadaFiscal(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta, out string nombreArchivo, out StringBuilder datos)
        {
            var commands = new List<string>();

            //Inicio el reporte
            commands.Add(EpsonTMT900FACommand.ResumenTotalesPorRangoDeJornadaFiscal.Cmd);
            commands.Add(EpsonTMT900FACommand.ResumenTotalesPorRangoDeJornadaFiscal.CmdExt);
            commands.Add(controladorFiscalJornadaDesde.ToString());
            commands.Add(controladorFiscalJornadaHasta.ToString());
            SendData(commands);
            nombreArchivo = GetExtraField(1);
            datos = ObtenerDatosReporte();
        }

        public void ObtenerMemoriaTransacciones(out int cintaTestigoDigitalDisponiblesDesde, out int cintaTestigoDigitalDisponiblesHasta, out int descargarDuplicadosTipoADisponiblesDesde, out int descargarDuplicadosTipoADisponiblesHasta, out int resumenTotalesDisponiblesDesde, out int resumenTotalesDisponiblesHasta, out int jornadasDescargadasCompletamenteDesde, out int jornadasDescargadasCompletamenteHasta, out int jornadasBorradasDesde, out int jornadasBorradasHasta)
        {
            var commands = new List<string>();

            commands.Add(EpsonTMT900FACommand.InformacionMemoriaTransacciones.Cmd);
            commands.Add(EpsonTMT900FACommand.InformacionMemoriaTransacciones.CmdExt);
            SendData(commands);

            cintaTestigoDigitalDisponiblesDesde = int.Parse(GetExtraField(1));
            cintaTestigoDigitalDisponiblesHasta = int.Parse(GetExtraField(2));
            descargarDuplicadosTipoADisponiblesDesde = int.Parse(GetExtraField(3));
            descargarDuplicadosTipoADisponiblesHasta = int.Parse(GetExtraField(4));
            resumenTotalesDisponiblesDesde = int.Parse(GetExtraField(5));
            resumenTotalesDisponiblesHasta = int.Parse(GetExtraField(6));
            jornadasDescargadasCompletamenteDesde = int.Parse(GetExtraField(7));
            jornadasDescargadasCompletamenteHasta = int.Parse(GetExtraField(8));
            jornadasBorradasDesde = int.Parse(GetExtraField(9));
            jornadasBorradasHasta = int.Parse(GetExtraField(10));
        }

        public void BorradoJornadasMemoriaTransacciones(int borradasJornadasHasta)
        {
            var commands = new List<string>();

            commands.Add(EpsonTMT900FACommand.BorradoJornadasMemoriaTransacciones.Cmd);
            commands.Add(EpsonTMT900FACommand.BorradoJornadasMemoriaTransacciones.CmdExt);
            commands.Add(borradasJornadasHasta.ToString());
            SendData(commands);
        }

        public void Informacionjornada()
        {
            var commands = new List<string>();

            commands.Add(EpsonTMT900FACommand.Informacionjornada.Cmd);
            commands.Add(EpsonTMT900FACommand.Informacionjornada.CmdExt);
            SendData(commands);
        }

        public void ObtenerEstados()
        {
            var commands = new List<string>();

            commands.Add(EpsonTMT900FACommand.ObtenerEstadoImpresora.Cmd);
            commands.Add(EpsonTMT900FACommand.ObtenerEstadoImpresora.CmdExt);
            SendData(commands);
        }

        private string obtenerComprobanteOriginal(CondicionIVA condicionIvaOriginal, string puntoVentaOriginal, string comprabanteOriginal)
        {
            string codigoDocumento = string.Empty;
            if (condicionIvaOriginal == CondicionIVA.Responsable_Inscripto)
                codigoDocumento = "081"; //Documento Factura A
            else
                codigoDocumento = "082"; //Documento Factura B

            return $"{codigoDocumento}-{puntoVentaOriginal.PadLeft(5, '0')}-{comprabanteOriginal.PadLeft(8, '0')}";
        }

        private StringBuilder ObtenerDatosReporte()
        {
            List<string> commands = new List<string>();
            StringBuilder datos = new StringBuilder();

            string hayMasDatos = string.Empty;
            datos = new StringBuilder();

            try
            {
                do
                {
                    commands.Clear();
                    commands.Add(EpsonTMT900FACommand.ContinuarDescargaReporte.Cmd);
                    commands.Add(EpsonTMT900FACommand.ContinuarDescargaReporte.CmdExt);
                    SendData(commands);

                    datos.Append(GetExtraField(1));
                    hayMasDatos = GetExtraField(2);

                } while (hayMasDatos == "S");
            }
            catch
            {
                commands.Clear();
                commands.Add(EpsonTMT900FACommand.CancelarDescargaReporte.Cmd);
                commands.Add(EpsonTMT900FACommand.CancelarDescargaReporte.CmdExt);
                SendData(commands);
                throw;
            }

            commands.Clear();
            commands.Add(EpsonTMT900FACommand.FinalizarDescargaReporte.Cmd);
            commands.Add(EpsonTMT900FACommand.FinalizarDescargaReporte.CmdExt);
            SendData(commands);

            return datos;
        }
    }
}
