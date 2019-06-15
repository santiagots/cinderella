using EpsonFPHostControlX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Device
{
    class ControladorFiscal
    {
    //    public EpsonFPHostControl oEpsonFP;

    //    // Constructor.
    //    public ControladorFiscal(string TipoConexion)
    //    {
    //        oEpsonFP = new EpsonFPHostControl();

    //        if ((TipoConexion == "USB"))
    //            oEpsonFP.CommPort = TxCommPort.USB;
    //        else
    //        {
    //            oEpsonFP.CommPort = TxCommPort.Com1;
    //            oEpsonFP.BaudRate = TxBaudRate.br9600;
    //        }

    //        oEpsonFP.ProtocolType = TxProtocolType.protocol_Extended;
    //    }

    //    // Funcion que Abre un Tique.
    //    public bool AbrirTicket(Entidades.ControladorFiscal Control)
    //    {
    //        bool bAnswer = false;
    //        bAnswer = oEpsonFP.AddDataField(Strings.Chr(0xB) + Strings.Chr(0x1));
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Strings.Chr(0x0) + Strings.Chr(0x0));
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.NCOMP1);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.NCOMP2);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.DCOMP1);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.DCOMP2);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.DCOMP3);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.CUIT);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.NCUIT);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.RI);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.LREMITO1);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.LREMITO2);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField("");
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.SendCommand();
    //        FPDelay();
    //        return bAnswer;
    //    }

    //    // Funcion que Abre una Nota de Credito.
    //    public bool AbrirNotaCredito(Entidades.ControladorFiscal Control)
    //    {
    //        bool bAnswer = false;
    //        bAnswer = oEpsonFP.AddDataField(Strings.Chr(0xD) + Strings.Chr(0x1));
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Strings.Chr(0x0) + Strings.Chr(0x0));
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.NCOMP1);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.NCOMP2);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.DCOMP1);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.DCOMP2);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.DCOMP3);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.CUIT);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.NCUIT);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.RI);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.LREMITO1);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.LREMITO2);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.COMPROBANTEORIGEN);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.SendCommand();
    //        FPDelay();
    //        return bAnswer;
    //    }


    //    // Funcion que Cierra un Tique.
    //    public void CerrarTicket(Entidades.ControladorFiscal Control)
    //    {
    //        bool bAnswer = false;
    //        bAnswer = oEpsonFP.AddDataField(Strings.Chr(0xB) + Strings.Chr(0x6));
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Strings.Chr(0x0) + Strings.Chr(0x3));
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField("1");
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.COLAR1);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField("2");
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.COLAR2);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField("3");
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.COLAR3);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.SendCommand();
    //        FPDelay();
    //        if (oEpsonFP.GetExtraField(1) == "")
    //            return 0;
    //        else
    //            return oEpsonFP.GetExtraField(1);
    //    }

    //    // Funcion que Cierra un Tique.
    //    public void CerrarNotaCredito(Entidades.ControladorFiscal Control)
    //    {
    //        bool bAnswer = false;
    //        bAnswer = oEpsonFP.AddDataField(Strings.Chr(0xD) + Strings.Chr(0x6));
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Strings.Chr(0x0) + Strings.Chr(0x3));
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField("1");
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.COLAR1);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField("2");
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.COLAR2);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField("3");
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.COLAR3);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField("");
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.SendCommand();
    //        FPDelay();
    //        if (oEpsonFP.GetExtraField(1) == "")
    //            return 0;
    //        else
    //            return oEpsonFP.GetExtraField(1);
    //    }

    //    // Funcion que obtiene el subtotal de un Tique.
    //    public void SubtotalTicket()
    //    {
    //        string sSubtotal = "";
    //        bool bAnswer = false;

    //        // Get Subtotal
    //        bAnswer = oEpsonFP.AddDataField(Strings.Chr(0xB) + Strings.Chr(0x3));
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Strings.Chr(0x0) + Strings.Chr(0x8));
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.SendCommand();
    //        FPDelay();
    //        sSubtotal = oEpsonFP.GetExtraField(1);
    //        FPDelay();
    //        return sSubtotal;
    //    }

    //    // Funcion que obtiene el subtotal de una Nota de Credito.
    //    public void SubtotalNotaCredito()
    //    {
    //        string sSubtotal = "";
    //        bool bAnswer = false;

    //        // Get Subtotal
    //        bAnswer = oEpsonFP.AddDataField(Strings.Chr(0xD) + Strings.Chr(0x3));
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Strings.Chr(0x0) + Strings.Chr(0x1));
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.SendCommand();
    //        FPDelay();
    //        sSubtotal = oEpsonFP.GetExtraField(1);
    //        FPDelay();
    //        return sSubtotal;
    //    }

    //    // Funcion que Agrega descuentos.
    //    public void DescuentosTicket(string descrip, string descuento)
    //    {
    //        bool bAnswer = false;

    //        bAnswer = oEpsonFP.AddDataField(Strings.Chr(0xB) + Strings.Chr(0x4));
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Strings.Chr(0x0) + Strings.Chr(0x0));
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(descrip);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(descuento);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.SendCommand();
    //        FPDelay();
    //        return bAnswer;
    //    }

    //    // Funcion que Agrega descuentos.
    //    public void RecargosTicket(string descrip, string descuento)
    //    {
    //        bool bAnswer = false;

    //        bAnswer = oEpsonFP.AddDataField(Strings.Chr(0xB) + Strings.Chr(0x4));
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Strings.Chr(0x0) + Strings.Chr(0x1));
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(descrip);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(descuento);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.SendCommand();
    //        FPDelay();
    //        return bAnswer;
    //    }

    //    // Funcion que Agrega descuentos a la nota de credito.
    //    public void DescuentosNotaCredito(string descrip, string descuento)
    //    {
    //        bool bAnswer = false;

    //        bAnswer = oEpsonFP.AddDataField(Strings.Chr(0xD) + Strings.Chr(0x4));
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Strings.Chr(0x0) + Strings.Chr(0x0));
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(descrip);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(descuento);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.SendCommand();
    //        FPDelay();
    //        return bAnswer;
    //    }

    //    // Funcion que Agrega descuentos.
    //    public void RecargosNotaCredito(string descrip, string descuento)
    //    {
    //        bool bAnswer = false;

    //        bAnswer = oEpsonFP.AddDataField(Strings.Chr(0xD) + Strings.Chr(0x4));
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Strings.Chr(0x0) + Strings.Chr(0x1));
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(descrip);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(descuento);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.SendCommand();
    //        FPDelay();
    //        return bAnswer;
    //    }

    //    // Funcion que Paga un Tique.
    //    public void PagarTicket(string TipoPago, string MontoPago)
    //    {
    //        bool bAnswer = false;
    //        // Send Payment
    //        bAnswer = oEpsonFP.AddDataField(Strings.Chr(0xB) + Strings.Chr(0x5));
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Strings.Chr(0x0) + Strings.Chr(0x0));
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField("");
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(TipoPago);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(MontoPago);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.SendCommand();
    //        FPDelay();
    //        return bAnswer;
    //    }

    //    // Funcion que Agrega un item a un Tique.
    //    public void AgregarItemTicket(Entidades.ControladorFiscal Control)
    //    {
    //        bool bAnswer = false;
    //        bAnswer = oEpsonFP.AddDataField(Strings.Chr(0xB) + Strings.Chr(0x2));
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Strings.Chr(0x0) + Strings.Chr(0x18));
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.DE1);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.DE2);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.DE3);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.DE4);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.DPPAL);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.CANTIDAD);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.PUNITARIO);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.TIVA);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.IIF);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.IIP);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.SendCommand();
    //        FPDelay();
    //        return bAnswer;
    //    }

    //    // Funcion que Agrega un item a una Nota de Credito.
    //    public void AgregarItemNotaCredito(Entidades.ControladorFiscal Control)
    //    {
    //        bool bAnswer = false;
    //        bAnswer = oEpsonFP.AddDataField(Strings.Chr(0xD) + Strings.Chr(0x2));
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Strings.Chr(0x0) + Strings.Chr(0x18));
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.DE1);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.DE2);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.DE3);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.DE4);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.DPPAL);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.CANTIDAD);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.PUNITARIO);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.TIVA);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.IIF);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Control.IIP);
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.SendCommand();
    //        FPDelay();
    //        return bAnswer;
    //    }

    //    // Funcion que emite el Cierre X en la controladora
    //    public void CierreX()
    //    {
    //        bool bAnswer = false;
    //        bAnswer = oEpsonFP.AddDataField(Strings.Chr(0x8) + Strings.Chr(0x2));
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Strings.Chr(0x0) + Strings.Chr(0x1));
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.SendCommand();
    //        FPDelay();
    //    }

    //    // Funcion que emite el Cierre Z en la controladora
    //    public void CierreZ()
    //    {
    //        bool bAnswer = false;
    //        bAnswer = oEpsonFP.AddDataField(Strings.Chr(0x8) + Strings.Chr(0x1));
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Strings.Chr(&H) + Strings.Chr(0x0));
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.SendCommand();
    //        FPDelay();
    //    }

    //    public void CierreZPorRangoDeFecha(DateTime fechaDesde, DateTime fechaHasta)
    //    {
    //        bool bAnswer = false;
    //        bAnswer = oEpsonFP.AddDataField(Strings.Chr(0x8) + Strings.Chr(0x10));
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Strings.Chr(0x0) + Strings.Chr(0x1));
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(fechaDesde.ToString("ddMMyy"));
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(fechaHasta.ToString("ddMMyy"));
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.SendCommand;
    //        FPDelay();
    //    }

    //    public void Informacionjornada()
    //    {
    //        bool bAnswer = false;
    //        bAnswer = oEpsonFP.AddDataField(Strings.Chr(0x8) + Strings.Chr(0x3));
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.AddDataField(Strings.Chr(&H) + Strings.Chr(0x0));
    //        if (bAnswer)
    //            bAnswer = oEpsonFP.SendCommand();
    //        FPDelay();
    //    }

    //    // Funcion que abre los puertos de la impresora.
    //    public bool AbrirPuerto()
    //    {
    //        bool state = false;
    //        if ((oEpsonFP.OpenPort == true))
    //            state = true;
    //        else
    //            state = false;
    //        return state;
    //    }

    //    // Funcion que abre cerrar los puertos de la impresora.
    //    public void CerrarPuerto()
    //    {
    //        oEpsonFP.ClosePort();
    //    }

    //    public void PrinterStatus()
    //    {
    //        return Hex(oEpsonFP.PrinterStatus).PadLeft(4, '0');
    //    }

    //    public void FiscalStatus()
    //    {
    //        return Hex(oEpsonFP.FiscalStatus).PadLeft(4, '0');
    //    }

    //    public void ReturnCode()
    //    {
    //        return Hex(oEpsonFP.ReturnCode).PadLeft(4, '0');
    //    }

    //    public void FPDelay()
    //    {
    //        while ((oEpsonFP.State == TxFiscalState.EFP_S_Busy))
    //            DoEvents();
    //    }
    }
}
