using Common.Core.Enum;
using Common.Core.Model;

namespace Factura.Device.Contracts
{
    public class TributoTicketRequest
    {
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }

        public TributoTicketRequest(string descripcion, decimal monto)
        {
            Descripcion = descripcion;
            Monto = monto;
        }
    }
}
