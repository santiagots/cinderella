using Common.Core.ValueObjects;

namespace Ventas.Core.Model.ValueObjects
{
    public class CostoProducto : ValueObjects<CostoProducto>
    {
        public int Cantidad { get; private set; }
        public MontoProducto MontoProducto { get; private set; }
        public MontoProducto Total { get { return MontoProducto * Cantidad; } }

        public CostoProducto(int cantidad, MontoProducto precio)
        {
            Cantidad = cantidad;
            MontoProducto = precio;
        }
        public static CostoProducto operator +(CostoProducto a, CostoProducto b)
        {
            CostoProducto item = new CostoProducto(a.Cantidad + a.Cantidad, a.MontoProducto + a.MontoProducto);
            return item;
        }

        protected override bool EqualsCore(CostoProducto other)
        {
            return
                Cantidad == other.Cantidad &&
                MontoProducto == other.MontoProducto;
        }

        protected override int GetHashCodeCore()
        {
            return Total.GetHashCode();
        }
    }
}
