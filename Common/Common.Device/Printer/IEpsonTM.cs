
using Common.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Device.Printer
{
    interface IEpsonTM: IDisposable
    {
        void AbrirTicket();
        void AbrirNotaCredito();
        int CerrarTicket();
        int CerrarNotaCredito();
        void SubtotalTicket();
        void SubtotalNotaCredito();
        void DescuentosTicket(string descripcion, decimal descuento);
        void RecargosTicket(string descripcion, decimal recargo);
        void DescuentosNotaCredito(string descripcion, decimal descuento);
        void RecargosNotaCredito(string descripcion, decimal recargo);
        void PagarTicket(TipoPago TipoPago, int numeroCuotas, decimal montoPago);
        void AgregarItemTicket(string codigoItem, string descripcion, int cantidad, decimal precioUnitario);
        void AgregarItemNotaCredito(string codigoItem, string descripcion, int cantidad, decimal precioUnitario);
        void CierreX();
        void CierreZ();
        void CierreZPorRangoDeFecha(DateTime fechaDesde, DateTime fechaHasta);
        void Informacionjornada();
        void ObtenerEstados();
    }
}
