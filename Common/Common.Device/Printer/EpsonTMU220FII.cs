﻿using Common.Core.Constants;
using Common.Core.Enum;
using Common.Core.Exceptions;
using EpsonFPHostControlX;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace Common.Device.Printer
{
    internal class EpsonTMU220FII : EpsonTMBase, IEpsonTM
    {
        internal EpsonTMU220FII(TipoCliente tipoCliente, CondicionIVA condicionesIVA, decimal porcentajeFacturacion, string nombreYApellido, string direccion, string localidad, string cuit)
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

        public EpsonTMU220FII(TipoCliente tipoCliente, CondicionIVA condicionesIVA, decimal porcentajeFacturacion, string nombreYApellido, string direccion, string localidad, string cuit, string comprabanteOriginal)
            : this(tipoCliente, condicionesIVA, porcentajeFacturacion, nombreYApellido, direccion, localidad, cuit)
        {
            ComprabanteOriginal = comprabanteOriginal;
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
        public int CerrarTicket()
        {
            var commands = new List<string>();

            commands.Add(EpsonTMU220FIICommand.CerraTicket.Cmd);
            commands.Add(EpsonTMU220FIICommand.CerraTicket.CmdExt);
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

            commands.Add(EpsonTMU220FIICommand.CerraNotaCredito.Cmd);
            commands.Add(EpsonTMU220FIICommand.CerraNotaCredito.CmdExt);
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

            commands.Add(EpsonTMU220FIICommand.SubtotalTicket.Cmd);
            commands.Add(EpsonTMU220FIICommand.SubtotalTicket.CmdExt);
            SendData(commands, false);
        }

        // Funcion que obtiene el subtotal de una Nota de Credito.
        public void SubtotalNotaCredito()
        {
            var commands = new List<string>();

            commands.Add(EpsonTMU220FIICommand.SubtotalNotaCredito.Cmd);
            commands.Add(EpsonTMU220FIICommand.SubtotalNotaCredito.CmdExt);
            SendData(commands, false);
        }

        // Funcion que Agrega descuentos.
        public void DescuentosTicket(string descripcion, decimal descuento)
        {
            var commands = new List<string>();

            commands.Add(EpsonTMU220FIICommand.DescuentoTicket.Cmd);
            commands.Add(EpsonTMU220FIICommand.DescuentoTicket.CmdExt);
            commands.Add(descripcion);
            commands.Add(FormatearPrecio(descuento * PorcentajeFacturacion, 2));
            SendData(commands, false);
        }

        // Funcion que Agrega recargo.
        public void RecargosTicket(string descripcion, decimal recargo)
        {
            var commands = new List<string>();

            commands.Add(EpsonTMU220FIICommand.RecargoTicket.Cmd);
            commands.Add(EpsonTMU220FIICommand.RecargoTicket.CmdExt);
            commands.Add(descripcion);
            commands.Add(FormatearPrecio(recargo * PorcentajeFacturacion, 2));
            SendData(commands, false);
        }

        // Funcion que Agrega descuentos a la nota de credito.
        public void DescuentosNotaCredito(string descripcion, decimal descuento)
        {
            var commands = new List<string>();

            commands.Add(EpsonTMU220FIICommand.DescuentoNotaCredito.Cmd);
            commands.Add(EpsonTMU220FIICommand.DescuentoNotaCredito.CmdExt);
            commands.Add(descripcion);
            commands.Add(FormatearPrecio(descuento * PorcentajeFacturacion, 2));
            SendData(commands, false);
        }

        // Funcion que Agrega recargo.
        public void RecargosNotaCredito(string descripcion, decimal recargo)
        {
            var commands = new List<string>();

            commands.Add(EpsonTMU220FIICommand.RecargoNotaCredito.Cmd);
            commands.Add(EpsonTMU220FIICommand.RecargoNotaCredito.CmdExt);
            commands.Add(descripcion);
            commands.Add(FormatearPrecio(recargo * PorcentajeFacturacion, 2));
            SendData(commands, false);
        }

        // Funcion que Paga un Tique.
        public void PagarTicket(string TipoPago, decimal MontoPago)
        {
            var commands = new List<string>();

            commands.Add(EpsonTMU220FIICommand.Pago.Cmd);
            commands.Add(EpsonTMU220FIICommand.Pago.CmdExt);
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

            commands.Add(EpsonTMU220FIICommand.ItemTicket.Cmd);
            commands.Add(EpsonTMU220FIICommand.ItemTicket.CmdExt);
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

            commands.Add(EpsonTMU220FIICommand.ItemNotaCredito.Cmd);
            commands.Add(EpsonTMU220FIICommand.ItemNotaCredito.CmdExt);
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

            commands.Add(EpsonTMU220FIICommand.CierreDeCaja.Cmd);
            commands.Add(EpsonTMU220FIICommand.CierreDeCaja.CmdExt);
            SendData(commands);
        }

        // Funcion que emite el Cierre Z en la controladora
        public void CierreZ()
        {
            var commands = new List<string>();

            commands.Add(EpsonTMU220FIICommand.CierreDeDia.Cmd);
            commands.Add(EpsonTMU220FIICommand.CierreDeDia.CmdExt);
            SendData(commands);
        }

        public void CierreZPorRangoDeFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            var commands = new List<string>();

            commands.Add(EpsonTMU220FIICommand.CierreDeDiaPorFecha.Cmd);
            commands.Add(EpsonTMU220FIICommand.CierreDeDiaPorFecha.CmdExt);
            commands.Add(fechaDesde.ToString("ddMMyy"));
            commands.Add(fechaHasta.ToString("ddMMyy"));
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