﻿using Common.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Device.Printer
{
    internal class EpsonTMT900FA : EpsonTMBase, IEpsonTM
    {
        internal EpsonTMT900FA(TipoCliente tipoCliente, CondicionIVA condicionesIVA, decimal porcentajeFacturacion, string nombreYApellido, string direccion, string localidad, string cuit)
        {
            switch (condicionesIVA)
            {
                case CondicionIVA.Consumidor_Final:
                    NombreComprador1 = nombreYApellido;
                    NombreComprador2 = "";
                    TipoDocumentoComprador = DNI;
                    NumeroDocumentoComprador = cuit;
                    DomicilioComprador1 = direccion;
                    DomicilioComprador2 = localidad;
                    DomicilioComprador3 = "";
                    ResponsableIvaComprador = CONSUMIDOR_FINAL;
                    TasaIva = TASA_IVA;
                    break;
                case CondicionIVA.Monotributo:
                case CondicionIVA.Responsable_Inscripto:
                case CondicionIVA.Exento:
                default:
                    NombreComprador1 = nombreYApellido;
                    NombreComprador2 = "";
                    TipoDocumentoComprador = CUIT;
                    NumeroDocumentoComprador = cuit;
                    DomicilioComprador1 = direccion;
                    DomicilioComprador2 = localidad;
                    DomicilioComprador3 = "";
                    ResponsableIvaComprador = ObtenerResponsableIvaComprador(condicionesIVA);
                    TasaIva = TASA_IVA;
                    break;
            }

            TipoCliente = tipoCliente;
            PorcentajeFacturacion = porcentajeFacturacion;

            Initialize();
        }

        public EpsonTMT900FA(TipoCliente tipoCliente, CondicionIVA condicionesIVA, decimal porcentajeFacturacion, string nombreYApellido, string direccion, string localidad, string cuit, string comprabanteOriginal)
            : this(tipoCliente, condicionesIVA, porcentajeFacturacion, nombreYApellido, direccion, localidad, cuit)
        {
            ComprabanteOriginal = comprabanteOriginal;
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
            commands.Add(ComprabanteOriginal);
            SendData(commands);
        }


        // Funcion que Cierra un Tique.
        public int CerrarTicket()
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
            SendData(commands, false);
            return int.Parse(GetExtraField(1));
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
            SendData(commands, false);
            return int.Parse(GetExtraField(1));
        }

        // Funcion que obtiene el subtotal de un Tique.
        public void SubtotalTicket()
        {
            var commands = new List<string>();

            commands.Add(EpsonTMT900FACommand.SubtotalTicket.Cmd);
            commands.Add(EpsonTMT900FACommand.SubtotalTicket.CmdExt);
            SendData(commands, false);
        }

        // Funcion que obtiene el subtotal de una Nota de Credito.
        public void SubtotalNotaCredito()
        {
            var commands = new List<string>();

            commands.Add(EpsonTMT900FACommand.SubtotalNotaCredito.Cmd);
            commands.Add(EpsonTMT900FACommand.SubtotalNotaCredito.CmdExt);
            SendData(commands, false);
        }

        // Funcion que Agrega descuentos.
        public void DescuentosTicket(string descripcion, decimal descuento)
        {
            var commands = new List<string>();

            commands.Add(EpsonTMT900FACommand.DescuentoTicket.Cmd);
            commands.Add(EpsonTMT900FACommand.DescuentoTicket.CmdExt);
            commands.Add(descripcion);
            commands.Add(FormatearPrecio(descuento * PorcentajeFacturacion, 2));
            SendData(commands, false);
        }

        // Funcion que Agrega recargo.
        public void RecargosTicket(string descripcion, decimal recargo)
        {
            var commands = new List<string>();

            commands.Add(EpsonTMT900FACommand.RecargoTicket.Cmd);
            commands.Add(EpsonTMT900FACommand.RecargoTicket.CmdExt);
            commands.Add(descripcion);
            commands.Add(FormatearPrecio(recargo * PorcentajeFacturacion, 2));
            SendData(commands, false);
        }

        // Funcion que Agrega descuentos a la nota de credito.
        public void DescuentosNotaCredito(string descripcion, decimal descuento)
        {
            var commands = new List<string>();

            commands.Add(EpsonTMT900FACommand.DescuentoNotaCredito.Cmd);
            commands.Add(EpsonTMT900FACommand.DescuentoNotaCredito.CmdExt);
            commands.Add(descripcion);
            commands.Add(FormatearPrecio(descuento * PorcentajeFacturacion, 2));
            SendData(commands, false);
        }

        // Funcion que Agrega recargo.
        public void RecargosNotaCredito(string descripcion, decimal recargo)
        {
            var commands = new List<string>();

            commands.Add(EpsonTMT900FACommand.RecargoNotaCredito.Cmd);
            commands.Add(EpsonTMT900FACommand.RecargoNotaCredito.CmdExt);
            commands.Add(descripcion);
            commands.Add(FormatearPrecio(recargo * PorcentajeFacturacion, 2));
            SendData(commands, false);
        }

        // Funcion que Paga un Tique.
        public void PagarTicket(string TipoPago, decimal MontoPago)
        {
            var commands = new List<string>();

            commands.Add(EpsonTMT900FACommand.Pago.Cmd);
            commands.Add(EpsonTMT900FACommand.Pago.CmdExt);
            commands.Add("");
            commands.Add(ReemplazarCaracteres(TipoPago));
            commands.Add(FormatearPrecio(ObtenerMontoSegunTipoDeCliente(MontoPago), 2));
            SendData(commands, false);
        }

        // Funcion que Agrega un item a un Tique.
        public void AgregarItemTicket(string descripcion, int cantidad, decimal precioUnitario)
        {
            decimal precioUnitarioTipoCliente = ObtenerMontoSegunTipoDeCliente(precioUnitario);
            var commands = new List<string>();

            commands.Add(EpsonTMT900FACommand.ItemTicket.Cmd);
            commands.Add(EpsonTMT900FACommand.ItemTicket.CmdExt);
            commands.Add(DescripcionExtra1);
            commands.Add(DescripcionExtra2);
            commands.Add(DescripcionExtra3);
            commands.Add(DescripcionExtra4);
            commands.Add(ReemplazarCaracteres(descripcion));
            commands.Add(FormatearCantidad(cantidad));
            commands.Add(FormatearPrecio(precioUnitarioTipoCliente));
            commands.Add(TasaIva);
            commands.Add(IMPUESTOINTERNOFIJO);
            commands.Add(IMPUESTOINTERNOPORCENTUAL);
            SendData(commands, false);
        }

        // Funcion que Agrega un item a una Nota de Credito.
        public void AgregarItemNotaCredito(string descripcion, int cantidad, decimal precioUnitario)
        {
            decimal precioUnitarioTipoCliente = ObtenerMontoSegunTipoDeCliente(precioUnitario);
            var commands = new List<string>();

            commands.Add(EpsonTMT900FACommand.ItemNotaCredito.Cmd);
            commands.Add(EpsonTMT900FACommand.ItemNotaCredito.CmdExt);
            commands.Add(DescripcionExtra1);
            commands.Add(DescripcionExtra2);
            commands.Add(DescripcionExtra3);
            commands.Add(DescripcionExtra4);
            commands.Add(ReemplazarCaracteres(descripcion));
            commands.Add(FormatearCantidad(cantidad));
            commands.Add(FormatearPrecio(precioUnitarioTipoCliente));
            commands.Add(TasaIva);
            commands.Add(IMPUESTOINTERNOFIJO);
            commands.Add(IMPUESTOINTERNOPORCENTUAL);
            SendData(commands, false);
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

            commands.Add(EpsonTMT900FACommand.CierreDeDia.Cmd);
            commands.Add(EpsonTMT900FACommand.CierreDeDia.CmdExt);
            SendData(commands);
        }

        public void CierreZPorRangoDeFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            var commands = new List<string>();

            commands.Add(EpsonTMT900FACommand.CierreDeDiaPorFecha.Cmd);
            commands.Add(EpsonTMT900FACommand.CierreDeDiaPorFecha.CmdExt);
            commands.Add(fechaDesde.ToString("ddMMyy"));
            commands.Add(fechaHasta.ToString("ddMMyy"));
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
    }
}
