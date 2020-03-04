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

namespace Factura.Device.Printer
{
    internal abstract class EpsonTMBase
    {
        internal const string TASA_IVA = "2100";
        internal const string SIN_TASA_IVA = "0000";

        internal static List<KeyValuePair<string, string>> MensajesError = new List<KeyValuePair<string, string>>();

        //TIPOS RESPONSABILIDAD IVA
        internal const string RESPONSABLE_INSCRIPTO = "I";
        internal const string NO_RESPONSABLE = "N";
        internal const string MONOTRIBUTISTA = "M";
        internal const string EXENTO = "E";
        internal const string NO_CATEGORIZADO = "U";
        internal const string CONSUMIDOR_FINAL = "F";
        internal const string MONOTIBUTISTA_SOCIAL = "T";
        internal const string CONTRIBUYENTE_EVENTUAL = "C";
        internal const string CONTRIBUYENTE_EVENTUAL_SOCIAL = "V";
        internal const string IMPUESTOINTERNOFIJO = "";
        internal const string IMPUESTOINTERNOPORCENTUAL = "";

        //CONDICION ANTE IVA
        internal const string GRAVADO = "7";
        internal const string EXCENTO = "2";
        internal const string NO_GRABADO = "1";
        internal const string NO_CORRESPONDE = "0";
        internal const string SIN_CONDICION_IVA = "";


        //UNIDADES MEDIDA
        internal const string POR_UNIDAD = "7";

        //TIPOS DOCUMENTOS
        internal const string DNI = "D";
        internal const string CUIT = "T";
        internal const string CUIL = "L";
        internal const string CEDULA_IDENTIDAD = "C";
        internal const string PASAPORTE = "P";
        internal const string LIBRETA_CIVICA = "V";
        internal const string LIBRETA_ENROLAMIENTO = "E";


        internal static string DescripcionExtra1 = "";
        internal static string DescripcionExtra2 = "";
        internal static string DescripcionExtra3 = "";
        internal static string DescripcionExtra4 = "";
        internal static string ColaRemplazo1 = "Gracias por su compra.";
        internal static string ColaRemplazo2 = "";
        internal static string ColaRemplazo3 = "";
        internal static string LineaRemitoAsociados1 = "";
        internal static string LineaRemitoAsociados2 = "";
        internal static string LineaRemitoAsociados3 = "";
        private EpsonFPHostControl oEpsonFP;

        internal string NombreComprador1;
        internal string NombreComprador2;
        internal string DomicilioComprador1;
        internal string DomicilioComprador2;
        internal string DomicilioComprador3;
        internal string TasaIva;
        internal string TipoDocumentoComprador;
        internal string NumeroDocumentoComprador;
        internal string ResponsableIvaComprador;
        internal string ComprabanteOriginal;
        internal TipoCliente TipoCliente;
        internal decimal PorcentajeFacturacion;

        static EpsonTMBase()
        {
            MensajesError = ObtenerMensajesError();
        }

        internal void SendData(IEnumerable<string> data)
        {
            try
            {
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

            if (ReturnCode() != "0000")
                TratarError();
        }

        private void TratarError()
        {
            KeyValuePair<string, string> error = MensajesError.FirstOrDefault(x => x.Key == ReturnCode());
            if(error.Value != null)
                throw new NegocioException(error.Value);
            else
                throw new NegocioException("Error no identificado.");

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

        internal void Initialize(string tipoConexionControladora)
        {
            oEpsonFP = new EpsonFPHostControl();

            if (tipoConexionControladora == "USB")
                oEpsonFP.CommPort = TxCommPort.USB;
            else
            {
                oEpsonFP.CommPort = TxCommPort.Com1;
                oEpsonFP.BaudRate = TxBaudRate.br9600;
            }

            oEpsonFP.ProtocolType = TxProtocolType.protocol_Extended;
            oEpsonFP.OpenPort();
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
            montoAux = (double)monto;
            montoAux = (montoAux * (Math.Pow(10, potencia)));
            SinComas = montoAux.ToString().Replace(",", "");
            SinPuntos = montoAux.ToString().Replace(".", "");
            return SinPuntos;
        }

        internal string FormatearIVA(decimal monto, int potencia = 4)
        {
            string SinComas, SinPuntos;
            double montoAux;
            montoAux = (double)monto;
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

        internal decimal ObtenerMontoSegunTipoDeCliente(decimal monto, decimal iva)
        {
            switch (TipoCliente)
            {
                case TipoCliente.Minorista:
                    return monto;
                case TipoCliente.Mayorista:
                    return Math.Round(monto * PorcentajeFacturacion * (1 + iva), 1, MidpointRounding.AwayFromZero);
                default:
                    throw new InvalidOperationException($"Error al realizar la facturación. Tipo de cliente no reconocido {TipoCliente.ToString()}");
            }
        }

        internal decimal ObtenerDescuentoRecargoSegunResponsabilidadIva(decimal monto, decimal iva)
        {
            switch (ResponsableIvaComprador)
            {
                case RESPONSABLE_INSCRIPTO:
                case CONSUMIDOR_FINAL:
                    return monto * PorcentajeFacturacion;
                case MONOTRIBUTISTA:
                case EXENTO:
                    return Math.Round(monto * PorcentajeFacturacion * (1 + iva), 1, MidpointRounding.AwayFromZero);
                default:
                    throw new InvalidOperationException($"Error al realizar la facturación. Tipo de cliente no reconocido {TipoCliente.ToString()}");
            }
        }

        internal string ObtenerCodigoFormaPago(TipoPago tipoPago)
        {
            switch (tipoPago)
            {
                case TipoPago.Bonificacion:
                    return "99";
                case TipoPago.Cheque:
                    return "3";
                case TipoPago.Deposito:
                    return "7";
                case TipoPago.Efectivo:
                    return "8";
                case TipoPago.TarjetaCrédito:
                    return "20";
                case TipoPago.TarjetaDébito:
                    return "21";
                default:
                    throw new InvalidOperationException($"Error al realizar la facturación. Tipo de forma de pago no reconocido {tipoPago.ToString()}");
            }
        }

        private static List<KeyValuePair<string, string>> ObtenerMensajesError()
        {
            List<KeyValuePair<string, string>> mensajesError = new List<KeyValuePair<string, string>>();
            mensajesError.Add(new KeyValuePair<string, string>("0001", "0001 - Error interno"));
            mensajesError.Add(new KeyValuePair<string, string>("0002", "0002 - Error de inicialización del equipo"));
            mensajesError.Add(new KeyValuePair<string, string>("0003", "0003 - Error de proceso interno"));
            mensajesError.Add(new KeyValuePair<string, string>("0101", "0101 - Comando inválido para el estado actual"));
            mensajesError.Add(new KeyValuePair<string, string>("0102", "0102 - Comando inválido para el documento actual"));
            mensajesError.Add(new KeyValuePair<string, string>("0103", "0103 - Comando sólo aceptado en modo técnico"));
            mensajesError.Add(new KeyValuePair<string, string>("0104", "0104 - Comando sólo aceptado sin Jumper de Servicio"));
            mensajesError.Add(new KeyValuePair<string, string>("0105", "0105 - Comando sólo aceptado con Jumper de Servicio"));
            mensajesError.Add(new KeyValuePair<string, string>("0106", "0106 - Comando sólo aceptado sin Jumper de Uso Interno"));
            mensajesError.Add(new KeyValuePair<string, string>("0107", "0107 - Comando sólo aceptado con Jumper de Uso Interno"));
            mensajesError.Add(new KeyValuePair<string, string>("0108", "0108 - Sub estado inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("0109", "0109 - Límite de intervenciones técnicas alcanzado"));
            mensajesError.Add(new KeyValuePair<string, string>("010C", "010C - Secuencia de descarga inválida"));
            mensajesError.Add(new KeyValuePair<string, string>("0201", "0201 - El frame no contiene el largo mínimo aceptado"));
            mensajesError.Add(new KeyValuePair<string, string>("0202", "0202 - Comando inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("0203", "0203 - Campos en exceso"));
            mensajesError.Add(new KeyValuePair<string, string>("0204", "0204 - Campos en defecto"));
            mensajesError.Add(new KeyValuePair<string, string>("0205", "0205 - Campo no opcional"));
            mensajesError.Add(new KeyValuePair<string, string>("0206", "0206 - Campo alfanumérico inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("0207", "0207 - Campo alfabético inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("0208", "0208 - Campo numérico inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("0209", "0209 - Campo binario inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("020A", "020A - Campo imprimible inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("020B", "020B - Campo hexadecimal inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("020C", "020C - Campo fecha inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("020D", "020D - Campo hora inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("020E", "020E - Campo fiscal rich text inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("020F", "020F - Campo booleano inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("0210", "0210 - Largo del campo inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("0211", "0211 - Extensión del comando inválida"));
            mensajesError.Add(new KeyValuePair<string, string>("0212", "0212 - Código de barra no permitido"));
            mensajesError.Add(new KeyValuePair<string, string>("0213", "0213 - Atributos de impresión no permitidos"));
            mensajesError.Add(new KeyValuePair<string, string>("0214", "0214 - Atributo de impresión inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("0215", "0215 - Código de barra incorrectamente definido"));
            mensajesError.Add(new KeyValuePair<string, string>("0216", "0216 - Combinación de la palabra ‘total’ no aceptada"));
            mensajesError.Add(new KeyValuePair<string, string>("0219", "0219 - Uno de dos campos es estrictamente opcional, nunca los dos juntos. Al enviar un ítem nunca pueden estar los dos campos: Código del item MTX y Código interno"));
            mensajesError.Add(new KeyValuePair<string, string>("0250", "0250 - Error al descargar el reporte de eventos"));
            mensajesError.Add(new KeyValuePair<string, string>("0251", "0251 - Secuencia de descarga del reporte de eventos inválida"));
            mensajesError.Add(new KeyValuePair<string, string>("0301", "0301 - Error de hardware"));
            mensajesError.Add(new KeyValuePair<string, string>("0302", "0302 - Impresora fuera de línea"));
            mensajesError.Add(new KeyValuePair<string, string>("0303", "0303 - Error de Impresión"));
            mensajesError.Add(new KeyValuePair<string, string>("0304", "0304 - Problemas de papel, no se encuentra en condiciones para realizar la acción requerida, verificar si hay papel en rollo, slip o validación al mismo tiempo"));
            mensajesError.Add(new KeyValuePair<string, string>("0305", "0305 - Poco papel disponible"));
            mensajesError.Add(new KeyValuePair<string, string>("0306", "0306 - Error en carga o expulsión de papel"));
            mensajesError.Add(new KeyValuePair<string, string>("0307", "0307 - Característica de impresora no soportada"));
            mensajesError.Add(new KeyValuePair<string, string>("0308", "0308 - Error de display"));
            mensajesError.Add(new KeyValuePair<string, string>("0309", "0309 - Secuencia de scan inválida"));
            mensajesError.Add(new KeyValuePair<string, string>("030A", "030A - Número de área de recorte (crop area) inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("030B", "030B - Scanner no preparado"));
            mensajesError.Add(new KeyValuePair<string, string>("030C", "030C - Resolución de logotipo de la empresa no permitida"));
            mensajesError.Add(new KeyValuePair<string, string>("030D", "030D - Imposible imprimir documento en estación térmica"));
            mensajesError.Add(new KeyValuePair<string, string>("0401", "0401 - Número de serie inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("0402", "0402 - Deben configurarse los datos de fiscalización"));
            mensajesError.Add(new KeyValuePair<string, string>("0404", "0404 - Aun no se realizó al menos uno de los dos tipo de descargas requeridas para las jornadas fiscales. Descarga completa o descarga de documentos tipo A"));
            mensajesError.Add(new KeyValuePair<string, string>("0405", "0405 - Las jornadas fiscales descargadas no se encuentran borradas"));
            mensajesError.Add(new KeyValuePair<string, string>("0430", "0430 - Secuencia de solicicitud de certificado digital inválida"));
            mensajesError.Add(new KeyValuePair<string, string>("0436", "0436 - Secuencia de carga de certificado digital inválida"));
            mensajesError.Add(new KeyValuePair<string, string>("0437", "0437 - No se puede generar archivo CSR"));
            mensajesError.Add(new KeyValuePair<string, string>("0438", "0438 - No se puede guardar archivo CRT"));
            mensajesError.Add(new KeyValuePair<string, string>("0439", "0439 - Error interno en validación de certificado digital"));
            mensajesError.Add(new KeyValuePair<string, string>("0440", "0440 - Certificado aún no vigente"));
            mensajesError.Add(new KeyValuePair<string, string>("043A", "043A - Tipo de certificado digital inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("043B", "043B - No se puede validar el certificado digital"));
            mensajesError.Add(new KeyValuePair<string, string>("043C", "043C - Certificado AFIP no encontrado"));
            mensajesError.Add(new KeyValuePair<string, string>("043D", "043D - Cadena de certificados no encontrada"));
            mensajesError.Add(new KeyValuePair<string, string>("043E", "043E - Certificado Digital CF aún válido(CF.:Controlador Fiscal)"));
            mensajesError.Add(new KeyValuePair<string, string>("043F", "043F - Certificado Digital CF vencido (CF.:Controlador Fiscal)"));
            mensajesError.Add(new KeyValuePair<string, string>("0441", "0441 - Secuencia de descarga SAF inválida"));
            mensajesError.Add(new KeyValuePair<string, string>("0442", "0442 - Falla al crear archivo SAF"));
            mensajesError.Add(new KeyValuePair<string, string>("0450", "0450 - Error en el XML"));
            mensajesError.Add(new KeyValuePair<string, string>("0451", "0451 - Número de bajas fiscales no coincide"));
            mensajesError.Add(new KeyValuePair<string, string>("0452", "0452 - Demasiados cambios de CUIT"));
            mensajesError.Add(new KeyValuePair<string, string>("0453", "0453 - Imposible descargar el archivo de solicitud de baja fiscal (SFB), ya que no existe una baja fiscal previamente"));
            mensajesError.Add(new KeyValuePair<string, string>("0454", "0454 - Ocurrió algún error al intentar descargar el archivo de solicitud de baja fiscal (SFB)"));
            mensajesError.Add(new KeyValuePair<string, string>("0455", "0455 - Imposible copiar certificado de cadena ya instalado al directorio temporal"));
            mensajesError.Add(new KeyValuePair<string, string>("0456", "0456 - Certificado/s de cadena no instalado/s"));
            mensajesError.Add(new KeyValuePair<string, string>("0501", "0501 - Fecha / Hora no configurada"));
            mensajesError.Add(new KeyValuePair<string, string>("0502", "0502 - Error en cambio de fecha"));
            mensajesError.Add(new KeyValuePair<string, string>("0503", "0503 - Fecha fuera de rango"));
            mensajesError.Add(new KeyValuePair<string, string>("0505", "0505 - Número de caja inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("0506", "0506 - CUIT inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("0507", "0507 - Responsabilidad frente al IVA inválida"));
            mensajesError.Add(new KeyValuePair<string, string>("0508", "0508 - Número de línea de Encabezado/Cola inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("0509", "0509 - Demasiadas fiscalizaciones"));
            mensajesError.Add(new KeyValuePair<string, string>("050A", "050A - Demasiados cambios de situación tributaria"));
            mensajesError.Add(new KeyValuePair<string, string>("050B", "050B - Demasiados cambios de datos de fiscalización"));
            mensajesError.Add(new KeyValuePair<string, string>("0513", "0513 - Logo de usuario inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("0514", "0514 - Secuencia de definición de logos de usuario inválida"));
            mensajesError.Add(new KeyValuePair<string, string>("0515", "0515 - Configuración de Display inválida"));
            mensajesError.Add(new KeyValuePair<string, string>("0516", "0516 - Tipo de letra de MICR inválida"));
            mensajesError.Add(new KeyValuePair<string, string>("0518", "0518 - Líneas de establecimiento no configuradas"));
            mensajesError.Add(new KeyValuePair<string, string>("0519", "0519 - Datos fiscales no configurados"));
            mensajesError.Add(new KeyValuePair<string, string>("0520", "0520 - Situación tributaria no configurada"));
            mensajesError.Add(new KeyValuePair<string, string>("0521", "0521 - Tasa de IVA estándar no configurada"));
            mensajesError.Add(new KeyValuePair<string, string>("0522", "0522 - Límite de tique-factura no configurado"));
            mensajesError.Add(new KeyValuePair<string, string>("0524", "0524 - Monto máximo de tique-factura no permitido"));
            mensajesError.Add(new KeyValuePair<string, string>("0525", "0525 - Largo del logotipo de la empresa no permitido"));
            mensajesError.Add(new KeyValuePair<string, string>("0526", "0526 - Posición del logotipo de la empresa inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("0527", "0527 - El tamaño del logotipo de la empresa excede el máximo"));
            mensajesError.Add(new KeyValuePair<string, string>("0550", "0550 - Identificador tributario ya estaba configurado"));
            mensajesError.Add(new KeyValuePair<string, string>("0555", "0555 - Cambio de horario de verano no permitido"));
            mensajesError.Add(new KeyValuePair<string, string>("0556", "0556 - Formato o rango, de la línea de inicio de actividades, inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("0601", "0601 - Memoria de transacciones llena"));
            mensajesError.Add(new KeyValuePair<string, string>("0604", "0604 - Rango de auditoría solicitado sin datos"));
            mensajesError.Add(new KeyValuePair<string, string>("0801", "0801 - Requiere período de actividades iniciado"));
            mensajesError.Add(new KeyValuePair<string, string>("0802", "0802 - Require un Cierre Z"));
            mensajesError.Add(new KeyValuePair<string, string>("0803", "0803 - Memoria fiscal llena"));
            mensajesError.Add(new KeyValuePair<string, string>("0804", "0804 - Requiere jornada fiscal abierta"));
            mensajesError.Add(new KeyValuePair<string, string>("0807", "0807 - Período auditado sin datos"));
            mensajesError.Add(new KeyValuePair<string, string>("0808", "0808 - Rango auditado inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("0809", "0809 - Restan datos por auditar/descargar"));
            mensajesError.Add(new KeyValuePair<string, string>("080A", "080A - No hay más datos a descargar"));
            mensajesError.Add(new KeyValuePair<string, string>("080B", "080B - No es posible abrir la jornada fiscal"));
            mensajesError.Add(new KeyValuePair<string, string>("080C", "080C - No es posible cerrar la jornada fiscal"));
            mensajesError.Add(new KeyValuePair<string, string>("0810", "0810 - Tipo de documento solicitado inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("0811", "0811 - Número de documento solicitado inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("0812", "0812 - Documento solicitado no existente"));
            mensajesError.Add(new KeyValuePair<string, string>("0813", "0813 - La copia del documento solicitado fue borrada"));
            mensajesError.Add(new KeyValuePair<string, string>("0814", "0814 - Tipo de documento no soportado"));
            mensajesError.Add(new KeyValuePair<string, string>("0815", "0815 - Registrado para emitir documentos ‘normales’"));
            mensajesError.Add(new KeyValuePair<string, string>("0816", "0816 - Registrado para emitir documentos ‘M’"));
            mensajesError.Add(new KeyValuePair<string, string>("0817", "0817 - Falta descargar jornadas previas"));
            mensajesError.Add(new KeyValuePair<string, string>("0818", "0818 - Sólo se puede imprimir el cambio una única vez dentro de la jornada"));
            mensajesError.Add(new KeyValuePair<string, string>("0819", "0819 - Requiere que se encuentre establecida la línea de inicio de actividades"));
            mensajesError.Add(new KeyValuePair<string, string>("0901", "0901 - Overflow"));
            mensajesError.Add(new KeyValuePair<string, string>("0902", "0902 - Underflow"));
            mensajesError.Add(new KeyValuePair<string, string>("0903", "0903 - Demasiados ítems involucrados en la transacción"));
            mensajesError.Add(new KeyValuePair<string, string>("0904", "0904 - Demasiadas tasas de impuesto utilizadas"));
            mensajesError.Add(new KeyValuePair<string, string>("0905", "0905 - Demasiados descuentos / ajustes sobre subtotal involucradas en la transacción"));
            mensajesError.Add(new KeyValuePair<string, string>("0906", "0906 - Demasiados pagos involucrados en la transacción"));
            mensajesError.Add(new KeyValuePair<string, string>("0907", "0907 - Item no encontrado"));
            mensajesError.Add(new KeyValuePair<string, string>("0908", "0908 - Pago no encontrado"));
            mensajesError.Add(new KeyValuePair<string, string>("0909", "0909 - El total debe ser mayor a cero"));
            mensajesError.Add(new KeyValuePair<string, string>("090A", "090A - Se permite sólo un tipo de impuestos internos"));
            mensajesError.Add(new KeyValuePair<string, string>("090B", "090B - Impuesto interno no aceptado"));
            mensajesError.Add(new KeyValuePair<string, string>("090F", "090F - Tasa de IVA no encontrada"));
            mensajesError.Add(new KeyValuePair<string, string>("0A01", "0A01 - No permitido luego de descuentos / ajustes sobre el subtotal"));
            mensajesError.Add(new KeyValuePair<string, string>("0A02", "0A02 - No permitido luego de iniciar la fase de pago"));
            mensajesError.Add(new KeyValuePair<string, string>("0A03", "0A03 - Tipo de ítem inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("0A04", "0A04 - Línea de descripción en blanco"));
            mensajesError.Add(new KeyValuePair<string, string>("0A05", "0A05 - Cantidad resultante menor que cero"));
            mensajesError.Add(new KeyValuePair<string, string>("0A06", "0A06 - Cantidad resultante mayor a lo permitido"));
            mensajesError.Add(new KeyValuePair<string, string>("0A07", "0A07 - Precio total del ítem mayor al permitido"));
            mensajesError.Add(new KeyValuePair<string, string>("0A0A", "0A0A - Fase de pago finalizada"));
            mensajesError.Add(new KeyValuePair<string, string>("0A0B", "0A0B - Monto de pago no permitido"));
            mensajesError.Add(new KeyValuePair<string, string>("0A0C", "0A0C - Monto de descuento / ajuste no permitido"));
            mensajesError.Add(new KeyValuePair<string, string>("0A0F", "0A0F - No permitido antes de un ítem"));
            mensajesError.Add(new KeyValuePair<string, string>("0A10", "0A10 - Demasiadas descripciones extras"));
            mensajesError.Add(new KeyValuePair<string, string>("0A31", "0A31 - Código de tipo de pago inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("0A32", "0A32 - Imposible aplicar el descuento/ajuste particular. No se encontró un ítem que corresponda a la misma tasa de IVA y código de condición frente al IVA"));
            mensajesError.Add(new KeyValuePair<string, string>("0A33", "0A33 - Operación no permitida luego de Otros tributos"));
            mensajesError.Add(new KeyValuePair<string, string>("0A34", "0A34 - Otros tributos del tipo percepciones no soportado en Tique y Tique Nota de Crédito"));
            mensajesError.Add(new KeyValuePair<string, string>("0910", "0910 - Tasa de IVA inválida"));
            mensajesError.Add(new KeyValuePair<string, string>("091E", "091E - Período descargado demasiado grande"));
            mensajesError.Add(new KeyValuePair<string, string>("0B01", "0B01 - Tipo de documento del comprador inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("0B02", "0B02 - Máximo valor aceptado fue superado"));
            mensajesError.Add(new KeyValuePair<string, string>("0B03", "0B03 - CUIT/CUIL inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("0B04", "0B04 - Tipo de otros tributo inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("0B05", "0B05 - Exceso en la cantidad de líneas de separación de la firma"));
            mensajesError.Add(new KeyValuePair<string, string>("0B06", "0B06 - Monto cero de otros tributos no permitido"));
            mensajesError.Add(new KeyValuePair<string, string>("0B07", "0B07 - Demasiados Otros Tributos involucradas en la transacción"));
            mensajesError.Add(new KeyValuePair<string, string>("0B08", "0B08 - Otro tributo no encontrado"));
            mensajesError.Add(new KeyValuePair<string, string>("0B09", "0B09 - Operación no permitida luego de Otros Tributos"));
            mensajesError.Add(new KeyValuePair<string, string>("0B0A", "0B0A - Exceso de operaciones dentro del documento con triplicado"));
            mensajesError.Add(new KeyValuePair<string, string>("0B0B", "0B0B - Tique factura del turista solo es aceptado en tique-factura B"));
            mensajesError.Add(new KeyValuePair<string, string>("0B0C", "0B0C - Datos del turista inválidos"));
            mensajesError.Add(new KeyValuePair<string, string>("0B0D", "0B0D - Número de documento inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("0B0E", "0B0E - Documento no soportado por el mecanismo de impresión"));
            mensajesError.Add(new KeyValuePair<string, string>("0B11", "0B11 - Tipo de documento asociado inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("0B12", "0B12 - Punto de venta de documento asociado inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("0B13", "0B13 - Número de documento asociado inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("0B14", "0B14 - Otros tributos no soportado en Donaciones y Remito X/R"));
            mensajesError.Add(new KeyValuePair<string, string>("0B15", "0B15 - Número (#) de otros tributos con valor cero no permitido"));
            mensajesError.Add(new KeyValuePair<string, string>("0B16", "0B16 - Número (#) de otros tributos inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("0B17", "0B17 - No existen otros tributos"));
            mensajesError.Add(new KeyValuePair<string, string>("0B18", "0B18 - Número de CUIT inválido para transportista, al emitir Remito X/R"));
            mensajesError.Add(new KeyValuePair<string, string>("0B19", "0B19 - Tipo de documento del tercero inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("0B1A", "0B1A - CUIT/CUIL del tercero inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("0B1B", "0B1B - Tipo de documento del beneficiario/chofer inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("0B1C", "0B1C - CUIT/CUIL del beneficiario/chofer inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("0B1D", "0B1D - Responsabilidad frente al IVA del tercero inválida"));
            mensajesError.Add(new KeyValuePair<string, string>("0E02", "0E02 - Exceso de código de barras dentro del documento"));
            mensajesError.Add(new KeyValuePair<string, string>("1003", "1003 - Error interno al sumar monto de importe en un DNFH"));
            mensajesError.Add(new KeyValuePair<string, string>("1004", "1004 - Pagos no soportado en DNFH Presupuesto X, Remito R/X"));
            mensajesError.Add(new KeyValuePair<string, string>("1005", "1005 - Tipo de ítem no soportado en DNFH Remito R/X, Recibo X o Donaciones "));
            mensajesError.Add(new KeyValuePair<string, string>("1006", "1006 - Descuentos/Recargos no permitido en DNFH Remito R/X, Recibo X o Donaciones"));
            mensajesError.Add(new KeyValuePair<string, string>("1007", "1007 - Solamente se soporta un único ítem en Donaciones"));
            mensajesError.Add(new KeyValuePair<string, string>("1008", "1008 - La cantidad del item debe ser uno en Donaciones y Recibo X"));
            mensajesError.Add(new KeyValuePair<string, string>("1014", "1014 - Otros tributos no soportado en Donaciones y Remito X/R"));
            mensajesError.Add(new KeyValuePair<string, string>("1015", "1015 - La razón social, el domicilio y el tipo y número de documento del beneficiario, son requeridos en Donaciones"));
            mensajesError.Add(new KeyValuePair<string, string>("2005", "2005 - Código de unidad de medida reservado"));
            mensajesError.Add(new KeyValuePair<string, string>("2006", "2006 - Código de condición frente al IVA inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("2007", "2007 - Sólo se permite una Condición frente al IVA del tipo Gravado (observar que la tasa de IVA es distinto de Cero)"));
            mensajesError.Add(new KeyValuePair<string, string>("2008", "2008 - Código de otros tributos inválido"));
            mensajesError.Add(new KeyValuePair<string, string>("2009", "2009 - Código de otros tributos no permitido"));
            mensajesError.Add(new KeyValuePair<string, string>("7001", "7001 - Cable de red desconectado"));
            mensajesError.Add(new KeyValuePair<string, string>("7002", "7002 - Dirección IP inválida"));
            mensajesError.Add(new KeyValuePair<string, string>("7003", "7003 - Máscara de red inválida"));
            mensajesError.Add(new KeyValuePair<string, string>("7004", "7004 - Dirección de puerta de enlace predeterminada inválida"));
            mensajesError.Add(new KeyValuePair<string, string>("7005", "7005 - Error en DHCP"));
            mensajesError.Add(new KeyValuePair<string, string>("7006", "7006 - Error al aplicar la configuración"));
            mensajesError.Add(new KeyValuePair<string, string>("FFFF", "FFFF - Error desconocido"));

            return mensajesError;
        }

        public void Dispose()
        {
            oEpsonFP.ClosePort();
            GC.SuppressFinalize(this);
        }
    }
}
