using Common.Core.Exceptions;
using Common.Core.Model;
using Ventas.Core.Model.ValueObjects;

namespace Ventas.Core.Model.VentaAggregate
{
    public class VentaItem: Entity<long>
    {
        public Producto Producto { get; private set; }
        public CostoProducto Costo { get; private set; }
        public decimal PorcentajeBonificacion { get; private set; }

        private decimal _PorcentajePago;
        public decimal PorcentajePago
        {
            get { return _PorcentajePago; }
            private set
            {
                if(value > 1 && value < 0)
                    throw new NegocioException("Error el porcentaje de pago debe ser mayor o igual a cero y menor o igual a uno.");
                _PorcentajePago = value;
            }
        }

        public VentaItem(Producto producto, CostoProducto costoProducto, decimal porcentajeBonificacion, decimal porcentajePago)
        {
            Producto = producto;
            Costo = costoProducto;
            PorcentajeBonificacion = porcentajeBonificacion;
            PorcentajePago = porcentajePago;
        }

        public decimal Pagar(decimal monto)
        {
            decimal pendientePago = 0;

            if (PorcentajePago == 0)
                pendientePago = Costo.Total.toDecimal();
            else
                pendientePago = ObtenerPendientePago().toDecimal();

            if (pendientePago > monto)
            {
                PorcentajePago = (ObtenerTotalPago().toDecimal() + monto) / Costo.Total.toDecimal();
                return 0;
            }
            else
            {
                PorcentajePago = 1;
                return monto - pendientePago ;
            }
        }

        public MontoProducto ObtenerPendientePago()
        {
            return Costo.Total * (1 - PorcentajePago);
        }

        public MontoProducto ObtenerTotalPago()
        {
            return Costo.Total * PorcentajePago;
        }
    }

}
