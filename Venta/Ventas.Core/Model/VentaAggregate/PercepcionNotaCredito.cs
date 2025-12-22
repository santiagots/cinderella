using Common.Core.Model;
using Common.Core.Enum;

namespace Ventas.Core.Model.VentaAggregate
{
    public class PercepcionNotaCredito: Percepcion
    {
        public long IdNotaCredito { get; set; }
        public virtual NotaCredito NotaCredito { get; protected set; }

        protected PercepcionNotaCredito()
        {
        }

        public PercepcionNotaCredito(long idNotaCredito, TipoPercepcionFactura tipo, string comcepto, decimal alicuota, decimal monto) : base(tipo, comcepto, alicuota, monto)
        {
            IdNotaCredito = idNotaCredito;
            EstadoEntidad = EstadoEntidad.Nuevo;
        }
    }
}
