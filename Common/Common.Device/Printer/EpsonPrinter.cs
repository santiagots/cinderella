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
    public class EpsonPrinter
    {
        private IEpsonTM epsonTM;
        public static ModeloControladoraFiscal MODELO_CONTROLADORA_FISCAL = ModeloControladoraFiscal.TM_U220FII;

        public EpsonPrinter(TipoCliente tipoCliente, CondicionIVA condicionesIVA, decimal porcentajeFacturacion, string nombreYApellido, string direccion, string localidad, string cuit)
        {
            if (MODELO_CONTROLADORA_FISCAL == ModeloControladoraFiscal.TM_U220FII)
            {
                epsonTM = new EpsonTMU220FII(tipoCliente, condicionesIVA, porcentajeFacturacion, nombreYApellido, direccion, localidad, cuit);
            }
            else
            {

            }
        }

        public EpsonPrinter(TipoCliente tipoCliente, CondicionIVA condicionesIVA, decimal porcentajeFacturacion, string nombreYApellido, string direccion, string localidad, string cuit, string comprabanteOriginal)
        {
            if (MODELO_CONTROLADORA_FISCAL == ModeloControladoraFiscal.TM_U220FII)
            {
                epsonTM = new EpsonTMU220FII(tipoCliente, condicionesIVA, porcentajeFacturacion, nombreYApellido, direccion, localidad, cuit, comprabanteOriginal);
            }
            else
            {

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

        public void PagarTicket(string TipoPago, decimal MontoPago)
        {
            epsonTM.PagarTicket(TipoPago, MontoPago);
        }

        public void AgregarItemTicket(string descripcion, int cantidad, decimal precioUnitario)
        {
            epsonTM.AgregarItemTicket(descripcion, cantidad, precioUnitario);
        }

        public void AgregarItemNotaCredito(string descripcion, int cantidad, decimal precioUnitario)
        {
            epsonTM.AgregarItemNotaCredito(descripcion, cantidad, precioUnitario);
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

        public void Informacionjornada()
        {
            epsonTM.Informacionjornada();
        }

        public void ObtenerEstados()
        {
            epsonTM.ObtenerEstados();
        }
    }
}
