
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Device.Printer
{
    interface IEpsonTM
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
        void PagarTicket(string TipoPago, decimal MontoPago);
        void AgregarItemTicket(string descripcion, int cantidad, decimal precioUnitario);
        void AgregarItemNotaCredito(string descripcion, int cantidad, decimal precioUnitario);
        void CierreX();
        void CierreZ();
        void CierreZPorRangoDeFecha(DateTime fechaDesde, DateTime fechaHasta);
        void Informacionjornada();
        void ObtenerEstados();
    }
}
