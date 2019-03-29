using Common.Core.Constants;
using Common.Core.Enum;
using Common.Core.Exceptions;
using EpsonFPHostControlX;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace Common.Device.Printer
{
    public class EpsonFP
    {
        private static string TASA_IVA = "2100";
        public static string TIPO_CONEXION = "USB";

        //TIPOS RESPONSABILIDAD IVA
        private static string RESPONSABLE_INSCRIPTO = "I";
        private static string NO_RESPONSABLE = "N";
        private static string MONOTRIBUTISTA = "M";
        private static string EXENTO = "E";
        private static string NO_CATEGORIZADO = "U";
        private static string CONSUMIDOR_FINAL = "F";
        private static string MONOTIBUTISTA_SOCIAL = "T";
        private static string CONTRIBUYENTE_EVENTUAL = "C";
        private static string CONTRIBUYENTE_EVENTUAL_SOCIAL = "V";
        private static string IMPUESTOINTERNOFIJO = "0";
        private static string IMPUESTOINTERNOPORCENTUAL = "0";

        //TIPOS DOCUMENTOS
        private static string DNI = "D";
        private static string CUIT = "T";
        private static string CUIL = "L";
        private static string CEDULA_IDENTIDAD = "C";
        private static string PASAPORTE = "P";
        private static string LIBRETA_CIVICA = "V";
        private static string LIBRETA_ENROLAMIENTO = "E";

        private static string DescripcionExtra1 = "";
        private static string DescripcionExtra2 = "";
        private static string DescripcionExtra3 = "";
        private static string DescripcionExtra4 = "";
        private static string ColaRemplazo1 = "Gracias por su compra.";
        private static string ColaRemplazo2 = "";
        private static string ColaRemplazo3 = "";
        private static string LineaRemitoAsociados1 = ".";
        private static string LineaRemitoAsociados2 = "";
        private EpsonFPHostControl oEpsonFP;

        private string NombreComprador1;
        private string NombreComprador2;
        private string DomicilioComprador1;
        private string DomicilioComprador2;
        private string DomicilioComprador3;
        private string DescripcionPrincipal;
        private string Cantidad;
        private string PrecioUnitario;
        private string TasaIva;
        private string TipoDocumentoComprador;
        private string NumeroDocumentoComprador;
        private string ResponsableIvaComprador;
        private string ComprabanteOriginal;
        private TipoCliente TipoCliente;
        private decimal PorcentajeFacturacion;

        public EpsonFP(TipoCliente tipoCliente, CondicionIVA condicionesIVA, decimal porcentajeFacturacion, string nombreYApellido, string direccion, string localidad, string cuit)
        {
            switch (condicionesIVA)
            {
                case CondicionIVA.Consumidor_Final:
                    NombreComprador1 = "";
                    NombreComprador2 = "";
                    TipoDocumentoComprador = "";
                    NumeroDocumentoComprador = "";
                    DomicilioComprador1 = "";
                    DomicilioComprador2 = "";
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

            oEpsonFP = new EpsonFPHostControl();
            Initialize();

        }

        // Funcion que Abre un Tique.
        public void AbrirTicket()
        {
            var commands = new List<string>();

            commands.Add(EpsonFPCommand.AbrirTicket.Cmd);
            commands.Add(EpsonFPCommand.AbrirTicket.CmdExt);
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

            commands.Add(EpsonFPCommand.AbrirNotaCredito.Cmd);
            commands.Add(EpsonFPCommand.AbrirNotaCredito.CmdExt);
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

            commands.Add(EpsonFPCommand.CerraTicket.Cmd);
            commands.Add(EpsonFPCommand.CerraTicket.CmdExt);
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

            commands.Add(EpsonFPCommand.CerraNotaCredito.Cmd);
            commands.Add(EpsonFPCommand.CerraNotaCredito.CmdExt);
            commands.Add("1");
            commands.Add(ColaRemplazo1);
            commands.Add("2");
            commands.Add(ColaRemplazo2);
            commands.Add("3");
            commands.Add(ColaRemplazo3);
            SendData(commands, false);
            return int.Parse(GetExtraField(1));
        }

        // Funcion que obtiene el subtotal de un Tique.
        public void SubtotalTicket()
        {
            var commands = new List<string>();

            commands.Add(EpsonFPCommand.SubtotalTicket.Cmd);
            commands.Add(EpsonFPCommand.SubtotalTicket.CmdExt);
            SendData(commands, false);
        }

        // Funcion que obtiene el subtotal de una Nota de Credito.
        public decimal SubtotalNotaCredito()
        {
            var commands = new List<string>();

            commands.Add(EpsonFPCommand.SubtotalTicket.Cmd);
            commands.Add(EpsonFPCommand.SubtotalTicket.CmdExt);
            SendData(commands);
            return int.Parse(GetExtraField(1));
        }

        // Funcion que Agrega descuentos.
        public void DescuentosTicket(string descripcion, decimal descuento)
        {
            var commands = new List<string>();

            commands.Add(EpsonFPCommand.DescuentoTicket.Cmd);
            commands.Add(EpsonFPCommand.DescuentoTicket.CmdExt);
            commands.Add(descripcion);
            commands.Add(FormatearPrecio(descuento * PorcentajeFacturacion, 2));
            SendData(commands, false);
        }

        // Funcion que Agrega recargo.
        public void RecargosTicket(string descripcion, decimal recargo)
        {
            var commands = new List<string>();

            commands.Add(EpsonFPCommand.RecargoTicket.Cmd);
            commands.Add(EpsonFPCommand.RecargoTicket.CmdExt);
            commands.Add(descripcion);
            commands.Add(FormatearPrecio(recargo * PorcentajeFacturacion, 2));
            SendData(commands, false);
        }

        // Funcion que Agrega descuentos a la nota de credito.
        public decimal DescuentosNotaCredito(string descripcion, decimal descuento)
        {
            var commands = new List<string>();

            commands.Add(EpsonFPCommand.DescuentoNotaCredito.Cmd);
            commands.Add(EpsonFPCommand.DescuentoNotaCredito.CmdExt);
            commands.Add(descripcion);
            commands.Add(FormatearPrecio(descuento, 2));
            SendData(commands);
            return int.Parse(GetExtraField(1));
        }

        // Funcion que Agrega recargo.
        public decimal RecargosNotaCredito(string descripcion, decimal recargo)
        {
            var commands = new List<string>();

            commands.Add(EpsonFPCommand.RecargoNotaCredito.Cmd);
            commands.Add(EpsonFPCommand.RecargoNotaCredito.CmdExt);
            commands.Add(descripcion);
            commands.Add(FormatearPrecio(recargo, 2));
            SendData(commands);
            return int.Parse(GetExtraField(1));
        }

        // Funcion que Paga un Tique.
        public void PagarTicket(string TipoPago, decimal MontoPago)
        {
            var commands = new List<string>();

            commands.Add(EpsonFPCommand.Pago.Cmd);
            commands.Add(EpsonFPCommand.Pago.CmdExt);
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

            commands.Add(EpsonFPCommand.ItemTicket.Cmd);
            commands.Add(EpsonFPCommand.ItemTicket.CmdExt);
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
            var commands = new List<string>();

            commands.Add(EpsonFPCommand.ItemNotaCredito.Cmd);
            commands.Add(EpsonFPCommand.ItemNotaCredito.CmdExt);
            commands.Add(DescripcionExtra1);
            commands.Add(DescripcionExtra2);
            commands.Add(DescripcionExtra3);
            commands.Add(DescripcionExtra4);
            commands.Add(ReemplazarCaracteres(descripcion));
            commands.Add(FormatearCantidad(cantidad));
            commands.Add(FormatearPrecio(precioUnitario));
            commands.Add(TasaIva);
            commands.Add(IMPUESTOINTERNOFIJO);
            commands.Add(IMPUESTOINTERNOPORCENTUAL);
            SendData(commands);
        }

        // Funcion que emite el Cierre X en la controladora
        public void CierreX()
        {
            var commands = new List<string>();

            commands.Add(EpsonFPCommand.CierreDeCaja.Cmd);
            commands.Add(EpsonFPCommand.CierreDeCaja.CmdExt);
            SendData(commands);
        }

        // Funcion que emite el Cierre Z en la controladora
        public void CierreZ()
        {
            var commands = new List<string>();

            commands.Add(EpsonFPCommand.CierreDeDia.Cmd);
            commands.Add(EpsonFPCommand.CierreDeDia.CmdExt);
            SendData(commands);
        }

        public void CierreZPorRangoDeFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            var commands = new List<string>();

            commands.Add(EpsonFPCommand.CierreDeDiaPorFecha.Cmd);
            commands.Add(EpsonFPCommand.CierreDeDiaPorFecha.CmdExt);
            commands.Add(fechaDesde.ToString("ddMMyy"));
            commands.Add(fechaHasta.ToString("ddMMyy"));
            SendData(commands);
        }

        public void Informacionjornada()
        {
            var commands = new List<string>();

            commands.Add(EpsonFPCommand.Informacionjornada.Cmd);
            commands.Add(EpsonFPCommand.Informacionjornada.CmdExt);
            SendData(commands);
        }

        public void ObtenerEstados()
        {
            var commands = new List<string>();

            commands.Add(EpsonFPCommand.ObtenerEstadoImpresora.Cmd);
            commands.Add(EpsonFPCommand.ObtenerEstadoImpresora.CmdExt);
            SendData(commands);
        }

        private void SendData(IEnumerable<object> data, bool reconnect = true)
        {
            try
            {
                if (reconnect)
                {
                    this.Connect();
                }

                foreach (var field in data)
                {
                    this.AddDataField(field.ToString());
                }

                this.Send();
            }
            catch (Exception ex)
            {
                throw new NegocioException();
            }
        }

        private void AddDataField(string value)
        {
            if (!oEpsonFP.AddDataField(value))
            {
                throw new InvalidOperationException();
            }
        }

        internal string GetExtraField(int fieldNumber)
        {
            return oEpsonFP.GetExtraField(fieldNumber);
        }

        private void Connect()
        {
            oEpsonFP.ClosePort();

            this.WaitForProcess();
            this.Initialize();

            if (oEpsonFP.OpenPort())
            {
                this.WaitForProcess();
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        private void Initialize()
        {
            if (TIPO_CONEXION == "USB")
                oEpsonFP.CommPort = TxCommPort.USB;
            else
            {
                oEpsonFP.CommPort = TxCommPort.Com1;
                oEpsonFP.BaudRate = TxBaudRate.br9600;
            }

            oEpsonFP.ProtocolType = TxProtocolType.protocol_Extended;
        }

        private void Send()
        {
            if (!oEpsonFP.SendCommand())
            {
                throw new InvalidOperationException();
            }
            this.WaitForProcess();
        }

        private void WaitForProcess()
        {
            while (oEpsonFP.State == TxFiscalState.EFP_S_Busy)
            {
                Thread.Sleep(100);
            }
        }

        private string PrinterStatus()
        {
            return oEpsonFP.PrinterStatus.ToString("X").PadLeft(4, '0');
        }

        private string FiscalStatus()
        {
            return oEpsonFP.FiscalStatus.ToString("X").PadLeft(4, '0');
        }

        private string ReturnCode()
        {
            return oEpsonFP.ReturnCode.ToString("X").PadLeft(4, '0');
        }

        private string ReemplazarCaracteres(string Cadena)
        {
            string CadenaFinal = "";
            CadenaFinal = Cadena.ToLower();                  // Paso a minuscula todo el string.
            CadenaFinal = CadenaFinal.Replace("í", "¡");    // Reemplazo i.
            CadenaFinal = CadenaFinal.Replace("ó", "¢");    // Reemplazo ó.
            CadenaFinal = CadenaFinal.Replace("á", " ");    // Reemplazo á.
            CadenaFinal = CadenaFinal.Replace("é", "‚");    // Reemplazo é.
            CadenaFinal = CadenaFinal.Replace("ú", "£");    // Reemplazo ú.
            CadenaFinal = CadenaFinal.Replace("ñ", "¤");    // Reemplazo ñ.
            return CadenaFinal;
        }

        private string FormatearCantidad(int contidad)
        {
            return (contidad * 10000).ToString();
        }

        private string FormatearPrecio(decimal monto, int potencia = 4)
        {
            string SinComas, SinPuntos;
            double montoAux;
            montoAux = (double)Math.Round(monto, potencia);
            montoAux = (montoAux * (Math.Pow(10, potencia)));
            SinComas = montoAux.ToString().Replace(",", "");
            SinPuntos = montoAux.ToString().Replace(".", "");
            return SinPuntos;
        }

        private string ObtenerResponsableIvaComprador(CondicionIVA condicionesIVA)
        {
            switch (condicionesIVA)
            {
                case CondicionIVA.Consumidor_Final:
                    return CONSUMIDOR_FINAL;
                case CondicionIVA.Monotributo:
                    return MONOTRIBUTISTA;
                case CondicionIVA.Responsable_Inscripto:
                    return RESPONSABLE_INSCRIPTO;
                case CondicionIVA.Exento:
                    return EXENTO;
                default:
                    throw new InvalidOperationException($"Error al realizar la facturación. No se pudo obtener la responsabilidad ante IVA, valor de IVA {condicionesIVA.ToString()}");
            }
        }

        private decimal ObtenerMontoSegunTipoDeCliente(decimal monto)
        {
            switch (TipoCliente)
            {
                case TipoCliente.Minorista:
                    return monto;
                case TipoCliente.Mayorista:
                    return Math.Round(monto * PorcentajeFacturacion * (1 + Constants.IVA), 2, MidpointRounding.ToEven);
                default:
                    throw new InvalidOperationException($"Error al realizar la facturación. Tipo de cliente no reconocido {TipoCliente.ToString()}");
            }
        }

    }
}
