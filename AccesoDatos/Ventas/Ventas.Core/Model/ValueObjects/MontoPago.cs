﻿using Common.Core.ValueObjects;

namespace Ventas.Core.Model.ValueObjects
{
    public class MontoPago : ValueObjects<MontoPago>
    {
        public decimal Monto { get; private set; }
        public decimal Descuento { get; private set; }
        public decimal CFT { get; private set; }
        public decimal IVA { get; private set; }
        public decimal Total { get { return Monto - Descuento + CFT + IVA; } }

        public MontoPago(decimal monto, decimal descuento, decimal cft, decimal iva)
        {
            Monto = monto;
            Descuento = descuento;
            CFT = cft;
            IVA = iva;
        }

        public static MontoPago operator +(MontoPago a, MontoPago b)
        {
            return new MontoPago(a.Monto + b.Monto, a.Descuento + b.Descuento, a.CFT + b.CFT, a.IVA + b.IVA);
        }

        protected override bool EqualsCore(MontoPago other)
        {
            return Monto == other.Monto &&
                Descuento == other.Descuento &&
                CFT == other.CFT &&
                IVA == other.IVA;
        }

        protected override int GetHashCodeCore()
        {
            return (Monto + Descuento + CFT + IVA + Total).GetHashCode();
        }
    }
}
