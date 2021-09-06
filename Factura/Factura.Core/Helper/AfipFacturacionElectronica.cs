using Common.Core.Enum;
using Common.Core.Exceptions;
using Factura.Core.Enum;

namespace Factura.Core.Helper
{
    public class AfipFacturacionElectronica
    {
        public static int ObtenerTipoComprobante(CondicionIVA CondicionIVAVendedor, CondicionIVA condicionIVA, TipoDocumentoFiscal tipoDocumentoFiscal)
        {
            if (CondicionIVAVendedor == CondicionIVA.Monotributo)
            {
                switch (tipoDocumentoFiscal)
                {
                    case TipoDocumentoFiscal.Factura:
                        return AfipFacturacionElectronicaConstantes.FACTURA_C;

                    case TipoDocumentoFiscal.NotaCredito:
                        return AfipFacturacionElectronicaConstantes.NOTA_CREDITO_C;
                    default:
                        throw new NegocioException($"Error al realizar la facturación. No se ha podido determinar un tipo de comprobante para el documento fiscal {tipoDocumentoFiscal}.");
                };
            }
            else
            {
                switch (condicionIVA)
                {
                    case CondicionIVA.Responsable_Inscripto when tipoDocumentoFiscal == TipoDocumentoFiscal.Factura:
                        return AfipFacturacionElectronicaConstantes.FACTURA_A;
                    case CondicionIVA.Responsable_Inscripto when tipoDocumentoFiscal == TipoDocumentoFiscal.NotaCredito:
                        return AfipFacturacionElectronicaConstantes.NOTA_CREDITO_A;
                    case CondicionIVA.Consumidor_Final when tipoDocumentoFiscal == TipoDocumentoFiscal.Factura:
                    case CondicionIVA.Monotributo when tipoDocumentoFiscal == TipoDocumentoFiscal.Factura:
                    case CondicionIVA.Exento when tipoDocumentoFiscal == TipoDocumentoFiscal.Factura:
                        return AfipFacturacionElectronicaConstantes.FACTURA_B;
                    case CondicionIVA.Consumidor_Final when tipoDocumentoFiscal == TipoDocumentoFiscal.NotaCredito:
                    case CondicionIVA.Monotributo when tipoDocumentoFiscal == TipoDocumentoFiscal.NotaCredito:
                    case CondicionIVA.Exento when tipoDocumentoFiscal == TipoDocumentoFiscal.NotaCredito:
                        return AfipFacturacionElectronicaConstantes.NOTA_CREDITO_B;
                    default:
                        throw new NegocioException($"Error al realizar la facturación. No se ha podido determinar un tipo de comprobante para el tipo de cliente {condicionIVA} y documento fiscal {tipoDocumentoFiscal}.");
                };
            }
        }

        public static int ObtenerTipoDocumento(CondicionIVA condicionesIVA)
        {
            switch (condicionesIVA)
            {
                case CondicionIVA.Consumidor_Final:
                    return AfipFacturacionElectronicaConstantes.DNI;
                default:
                    return AfipFacturacionElectronicaConstantes.CUIT;
            };
        }
    }
}
