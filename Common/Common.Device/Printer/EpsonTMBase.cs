using Common.Core.Constants;
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
    internal abstract class EpsonTMBase
    {
        internal static string TASA_IVA = "2100";
        public static string TIPO_CONEXION = "USB";

        //TIPOS RESPONSABILIDAD IVA
        internal static string RESPONSABLE_INSCRIPTO = "I";
        internal static string NO_RESPONSABLE = "N";
        internal static string MONOTRIBUTISTA = "M";
        internal static string EXENTO = "E";
        internal static string NO_CATEGORIZADO = "U";
        internal static string CONSUMIDOR_FINAL = "F";
        internal static string MONOTIBUTISTA_SOCIAL = "T";
        internal static string CONTRIBUYENTE_EVENTUAL = "C";
        internal static string CONTRIBUYENTE_EVENTUAL_SOCIAL = "V";
        internal static string IMPUESTOINTERNOFIJO = "";
        internal static string IMPUESTOINTERNOPORCENTUAL = "";

        //TIPOS DOCUMENTOS
        internal static string DNI = "D";
        internal static string CUIT = "T";
        internal static string CUIL = "L";
        internal static string CEDULA_IDENTIDAD = "C";
        internal static string PASAPORTE = "P";
        internal static string LIBRETA_CIVICA = "V";
        internal static string LIBRETA_ENROLAMIENTO = "E";

        internal static string DescripcionExtra1 = "";
        internal static string DescripcionExtra2 = "";
        internal static string DescripcionExtra3 = "";
        internal static string DescripcionExtra4 = "";
        internal static string ColaRemplazo1 = "Gracias por su compra.";
        internal static string ColaRemplazo2 = "";
        internal static string ColaRemplazo3 = "";
        internal static string LineaRemitoAsociados1 = "";
        internal static string LineaRemitoAsociados2 = "";
        private EpsonFPHostControl oEpsonFP;

        internal string NombreComprador1;
        internal string NombreComprador2;
        internal string DomicilioComprador1;
        internal string DomicilioComprador2;
        internal string DomicilioComprador3;
        internal string DescripcionPrincipal;
        internal string Cantidad;
        internal string PrecioUnitario;
        internal string TasaIva;
        internal string TipoDocumentoComprador;
        internal string NumeroDocumentoComprador;
        internal string ResponsableIvaComprador;
        internal string ComprabanteOriginal;
        internal TipoCliente TipoCliente;
        internal decimal PorcentajeFacturacion;

        internal void SendData(IEnumerable<string> data, bool reconnect = true)
        {
            try
            {
                if (reconnect)
                {
                    this.Connect();
                }

                foreach (var field in data)
                {
                    string value = field ?? string.Empty;
                    this.AddDataField(value);
                }

                this.Send();
            }
            catch (Exception ex)
            {
                throw new NegocioException("Error al conectarse a la impresora fiscal. Verifique que la impresora se encuentre conectada.", ex);
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

        internal void Initialize()
        {
            oEpsonFP = new EpsonFPHostControl();

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

        internal string ReemplazarCaracteres(string Cadena)
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

        internal string FormatearCantidad(int contidad)
        {
            return (contidad * 10000).ToString();
        }

        internal string FormatearPrecio(decimal monto, int potencia = 4)
        {
            string SinComas, SinPuntos;
            double montoAux;
            montoAux = (double)Math.Round(monto, 1);
            montoAux = (montoAux * (Math.Pow(10, potencia)));
            SinComas = montoAux.ToString().Replace(",", "");
            SinPuntos = montoAux.ToString().Replace(".", "");
            return SinPuntos;
        }

        internal string ObtenerResponsableIvaComprador(CondicionIVA condicionesIVA)
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

        internal decimal ObtenerMontoSegunTipoDeCliente(decimal monto)
        {
            switch (TipoCliente)
            {
                case TipoCliente.Minorista:
                    return monto;
                case TipoCliente.Mayorista:
                    return Math.Round(monto * PorcentajeFacturacion * (1 + Constants.IVA), 1);
                default:
                    throw new InvalidOperationException($"Error al realizar la facturación. Tipo de cliente no reconocido {TipoCliente.ToString()}");
            }
        }
    }
}
