using Common.Core.Enum;
using Common.Core.Exceptions;
using Common.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using Ventas.Core.Model.ValueObjects;
using Ventas.Core.Model.VentaAggregate;

namespace Ventas.Core.Model.RemitoAgreggate
{
    public class Remito : Entity<long>
    {
        public long IdVenta { get; protected set; }
        public Venta Venta { get; protected set; }
        public int Numero { get; protected set; }
        public CondicionIVA CondicionIVA { get; protected set; }
        public string NombreYApellido { get; protected set; }
        public string CUIT { get; protected set; }
        public string Direccion { get; protected set; }
        public string Localidad { get; protected set; }
        public string RazonSocialTransporte { get; protected set; }
        public string DireccionTransporte { get; protected set; }
        public string LocalidadTransporte { get; protected set; }
        public int CantidadBultos { get; protected set; }
        public bool IncluyeFactura { get; protected set; }
        public string DespachoImportacion { get; protected set; }
        public virtual List<RemitoItem> RemitoItems { get; protected set; } = new List<RemitoItem>();
        public new MontoProducto MontoTotal => RemitoItems.Count > 0 ? RemitoItems.Select(x => x.Monto).Aggregate((x, y) => x + y) : new MontoProducto(0, 0);
        public DateTime FechaEdicion { get; protected set; }
        public bool Borrado { get; protected set; }

        internal Remito() { }

        public Remito(Venta venta, int numero, CondicionIVA condicionIVA, string nombreYApellido, string cuit, string direccion, string localidad, string razonSocialTransporte, string direccionTransporte, string localidadTransporte, int cantidadBultos, bool incluyeFactura, string despachoImportacion, List<RemitoItem> remitoItems) : base(true)
        {
            if (numero <= 0)
            {
                throw new NegocioException("Error al crear el remito. Debe ingresar un numero de remito.");
            }

            if (string.IsNullOrWhiteSpace(nombreYApellido))
            {
                throw new NegocioException("Error al crear el remito. Debe ingresar un nombre.");
            }

            if (string.IsNullOrWhiteSpace(cuit))
            {
                throw new NegocioException("Error al crear el remito. Debe ingresar un CUIT.");
            }

            if (string.IsNullOrWhiteSpace(direccion))
            {
                throw new NegocioException("Error al crear el remito. Debe ingresar una dirección.");
            }

            if (string.IsNullOrWhiteSpace(localidad))
            {
                throw new NegocioException("Error al crear el remito. Debe ingresar una localidad.");
            }

            if (string.IsNullOrWhiteSpace(razonSocialTransporte))
            {
                throw new NegocioException("Error al crear el remito. Debe ingresar una razón social en la sección de transporte.");
            }

            if (string.IsNullOrWhiteSpace(direccionTransporte))
            {
                throw new NegocioException("Error al crear el remito. Debe ingresar una dirección en la sección de transporte.");
            }

            if (string.IsNullOrWhiteSpace(localidadTransporte))
            {
                throw new NegocioException("Error al crear el remito. Debe ingresar una localidad en la sección de transporte.");
            }

            Venta = venta;
            IdVenta = venta.Id;
            Numero = numero;
            CondicionIVA = condicionIVA;
            NombreYApellido = nombreYApellido;
            CUIT = cuit;
            Direccion = direccion;
            Localidad = localidad;
            RazonSocialTransporte = razonSocialTransporte;
            DireccionTransporte = direccionTransporte;
            LocalidadTransporte = localidadTransporte;
            CantidadBultos = cantidadBultos;
            IncluyeFactura = incluyeFactura;
            DespachoImportacion = despachoImportacion != null? despachoImportacion : string.Empty;
            RemitoItems = remitoItems;
            FechaEdicion = DateTime.Now;
            EstadoEntidad = EstadoEntidad.Nuevo;
        }

        public Remito(long idRemito, Venta venta, int numero, CondicionIVA condicionIVA, string nombreYApellido, string cuit, string direccion, string localidad, string razonSocialTransporte, string direccionTransporte, string localidadTransporte, int cantidadBultos, bool incluyeFactura, string despachoImportacion, List<RemitoItem> remitoItems) 
            : this(venta, numero, condicionIVA, nombreYApellido, cuit, direccion, localidad, razonSocialTransporte, direccionTransporte, localidadTransporte, cantidadBultos, incluyeFactura, despachoImportacion, remitoItems)
        {
            Id = idRemito;
            EstadoEntidad = EstadoEntidad.Modificado;
        }
    }
}
