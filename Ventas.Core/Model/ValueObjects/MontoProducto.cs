using Common.Core.ValueObjects;
using System;

namespace Ventas.Core.Model.ValueObjects
{
    public class MontoProducto: ValueObjects<MontoProducto>
    {
        public decimal Valor { get; private set; }
        public decimal Iva { get; private set; }

        protected MontoProducto()
        {
        }

        public MontoProducto(decimal valor, decimal iva)
        {
            Valor = Math.Round(valor, 1);
            Iva = Math.Round(iva, 1);
        }

        public decimal toDecimal()
        {
            return Valor + Iva;
        }

        public static MontoProducto operator +(MontoProducto a, MontoProducto b)
        {
            return new MontoProducto(a.Valor + b.Valor, a.Iva + b.Iva);
        }

        public static MontoProducto operator -(MontoProducto a, MontoProducto b)
        {
            return new MontoProducto(a.Valor - b.Valor, a.Iva - b.Iva);
        }

        public static MontoProducto operator *(MontoProducto a, decimal b)
        {
            return new MontoProducto(a.Valor * b, a.Iva * b);
        }

        public static bool operator >(MontoProducto a, MontoProducto b)
        {
            return a.Valor + a.Iva > b.Valor + b.Iva;
        }

        public static bool operator <(MontoProducto a, MontoProducto b)
        {
            return a.Valor + a.Iva < b.Valor + b.Iva;
        }

        protected override bool EqualsCore(MontoProducto other)
        {
            return Valor == Valor && Iva == Iva;
        }

        protected override int GetHashCodeCore()
        {
            return (Valor + Iva).GetHashCode();
        }
    }
}
