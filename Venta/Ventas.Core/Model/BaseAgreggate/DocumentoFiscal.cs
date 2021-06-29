using Common.Core.Enum;
using Common.Core.Model;
using System;

namespace Ventas.Core.Model.BaseAgreggate
{
    public abstract class DocumentoFiscal : Entity<long>
    {
        public int PuntoVenta { get; protected set; }
        public TipoFactura TipoFactura { get; protected set; }
        public CondicionIVA CondicionIVA { get; protected set; }
        public string NombreYApellido { get; protected set; }
        public string Direccion { get; protected set; }
        public string Localidad { get; protected set; }
        public string CUIT { get; protected set; }
        public decimal SubTotal { get; protected set; }
        public decimal Iva { get; protected set; }
        public decimal Total { get; protected set; }
        public DateTime Fecha { get; protected set; }
        public string CAE { get; protected set; }
        public DateTime? FechaVencimientoCAE { get; protected set; }

        public DocumentoFiscal() : base()
        { }

        public DocumentoFiscal(bool GenerarId) : base(GenerarId)
        { }
        internal DocumentoFiscal(long idVenta, int puntoVenta, TipoFactura tipoFactura, CondicionIVA condicionIVA, string nombreYApellido, string direccion, string localidad, string cuit, string cae, DateTime? fechaVencimeintoCae, decimal subTotal, decimal iva, decimal total) : base()
        {
            Id = idVenta;
            PuntoVenta = puntoVenta;
            TipoFactura = tipoFactura;
            CondicionIVA = condicionIVA;
            NombreYApellido = nombreYApellido;
            Direccion = direccion;
            Localidad = localidad;
            CUIT = cuit;
            CAE = cae;
            FechaVencimientoCAE = fechaVencimeintoCae;
            SubTotal = subTotal;
            Iva = iva;
            Total = total;
            Fecha = DateTime.Now;
        }
    }
}
