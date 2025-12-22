using Common.Core.Enum;
using System;

namespace Common.Core.Model
{
    public class Percepcion : Entity<int>
    {
        public TipoCliente TipoCliente { get; protected set; }
        public CondicionIVA CondicionIVA { get; protected set; }
        public TipoPercepcionFactura TipoPercepcion { get; protected set; }
        public int? IdProvincia { get; protected set; }
        public Provincia Provincia { get; protected set; }
        public string Comcepto { get; protected set; }
        public decimal MontoDesde { get; protected set; }
        public decimal Alicuota { get; protected set; }
        public bool Habilitado { get; protected set; }

        protected Percepcion()
        {
        }

        public Percepcion(int id, TipoCliente tipoCliente, CondicionIVA condicionIVA, TipoPercepcionFactura tipoPercepcion, Provincia provincia, string comcepto, decimal montoDesde, decimal alicuota, bool habilitado)
        {
            TipoCliente = tipoCliente;
            CondicionIVA = condicionIVA;
            TipoPercepcion = tipoPercepcion;
            IdProvincia = provincia?.Id;
            Comcepto = comcepto;
            MontoDesde = montoDesde;
            Alicuota = alicuota;
            Habilitado = habilitado;
            if (id > 0)
            {
                Id = id;
                EstadoEntidad = EstadoEntidad.Modificado;
            }
            else
            {
                EstadoEntidad = EstadoEntidad.Nuevo;
            }
        }
    }
}
