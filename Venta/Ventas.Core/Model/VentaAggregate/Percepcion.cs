using Common.Core.Enum;
using Common.Core.Model;
using System;

namespace Ventas.Core.Model.VentaAggregate
{
    public class Percepcion: Entity<long>
    {
        public TipoPercepcionFactura Tipo { get; protected set; }
        public string Comcepto { get; protected set; }
        public decimal Alicuota { get; protected set; }
        public decimal Monto { get; protected set; }
        public DateTime FechaEdicion { get; internal set; }

        protected Percepcion()
        {
        }

        public Percepcion(TipoPercepcionFactura tipo, string comcepto, decimal alicuota, decimal monto) :base(true)
        {
            Tipo = tipo;
            Comcepto = comcepto;
            Alicuota = alicuota;
            Monto = monto;
            FechaEdicion = DateTime.Now;
        }
    }
}
