using Common.Core.Enum;

namespace Ventas.Core.Model.VentaAggregate
{
    public class PercepcionFactura: Percepcion
    {
        public long IdFactura { get; set; }
        public virtual Factura Factura { get; protected set; }

        protected PercepcionFactura()
        {
        }

        public PercepcionFactura(long idFactura, TipoPercepcionFactura tipo, string comcepto, decimal alicuota, decimal monto) : base(tipo, comcepto, alicuota, monto)
        {
            IdFactura = idFactura;
            EstadoEntidad = EstadoEntidad.Nuevo;
        }
    }
}
