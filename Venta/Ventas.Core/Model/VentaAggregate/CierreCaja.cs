using Common.Core.Exceptions;
using Common.Core.Model;
using System;
using Ventas.Core.Enum;

namespace Ventas.Core.Model.VentaAggregate
{
    public class CierreCaja : Entity<long>
    {
        public int IdSucursal { get; protected set; }
        public int IdUsuarioCierre { get; protected set; }
        public int? IdUsuarioAbre { get; protected set; }
        public DateTime Fecha { get; protected set; }
        public decimal Monto { get; protected set; }
        public decimal Diferencia { get; protected set; }
        public decimal Total { get { return Monto + Diferencia; } }
        public CierreCajaEstado Estado { get; protected set; }
        public CierreCajaSituacion Situacion { get; protected set; }
        public string Comentarios { get; protected set; }
        public bool Abierta { get; protected set; }
        public bool Borrado { get; protected set; }
        public DateTime FechaEdicion { get; internal set; }

        protected CierreCaja()
        {
        }

        public CierreCaja(int idSucursal) : base(true)
        {
            IdSucursal = idSucursal;
            Estado = CierreCajaEstado.Abierta;
            Situacion = CierreCajaSituacion.SinDiferencia;
        }

        public decimal ObtenerSobrante()
        {
            if (Situacion == CierreCajaSituacion.SobranteDinero)
                return Diferencia;
            else
                return 0;
        }

        public decimal ObtenerFaltante()
        {
            if (Situacion == CierreCajaSituacion.FaltanteDinero)
                return Diferencia;
            else
                return 0;
        }

        public void Abrir(int idUsuarioAbrir)
        {
            if(Estado != CierreCajaEstado.Cerrada)
                throw new NegocioException($"La caja no se puede abrir ya que su estado es {Estado}. Para abrir una caja su estado tiene que ser {CierreCajaEstado.Cerrada}.");

            IdUsuarioAbre = idUsuarioAbrir;
            Estado = CierreCajaEstado.Abierta;
            Situacion = CierreCajaSituacion.SinDiferencia;
            Monto = 0;
            Diferencia = 0;
            Abierta = true;
            Borrado = false;
            FechaEdicion = DateTime.Now;
            Comentarios = string.Empty;
        }

        public void Actualizar(int idUsuarioActualiza, decimal? monto, string comentario)
        {
            if (!monto.HasValue)
                throw new NegocioException("Por favor, para cerrar la caja diaria se debe ingresar el monto físico que se encuentra en la sucursal.");
            if (!string.IsNullOrWhiteSpace(comentario))
                throw new NegocioException("Por favor, para cerrar la caja diaria se debe ingresar un comentario.");

            IdUsuarioCierre = idUsuarioActualiza;
            Estado = CierreCajaEstado.Cerrada;
            Abierta = false;
            Borrado = false;
            FechaEdicion = DateTime.Now;
            Monto = monto.Value;
            Diferencia = 0;
            Situacion = CierreCajaSituacion.SinDiferencia;
            Comentarios = comentario;
        }

        public void Cerrar(int idUsuarioCierre, decimal? montoFisico, decimal montoRegistrado, bool abierta, DateTime fecha)
        {
            if (!montoFisico.HasValue)
                throw new NegocioException("Por favor, para cerrar la caja diaria se debe ingresar el monto físico que se encuentra en la sucursal.");

            IdUsuarioCierre = idUsuarioCierre;
            Fecha = fecha;
            Estado = CierreCajaEstado.Cerrada;
            Abierta = abierta;
            Borrado = false;
            FechaEdicion = Fecha;
            Monto = montoRegistrado;
            Diferencia = montoRegistrado - montoFisico.Value;

            if (Diferencia == 0)
            {
                Situacion = CierreCajaSituacion.SinDiferencia;
            }
            else if (Diferencia > 0)
            {
                Situacion = CierreCajaSituacion.SobranteDinero;
                Comentarios = "Sobrante de dinero en el cierre de caja.";
            }
            else
            {
                Situacion = CierreCajaSituacion.FaltanteDinero;
                Comentarios = "Faltante de dinero en el cierre de caja.";
            }
        }

        public void Cerrar(int idUsuarioCierre, decimal? monto, string comentario, bool abierta, DateTime fecha)
        {
            if (!monto.HasValue)
                throw new NegocioException("Por favor, para cerrar la caja diaria se debe ingresar el monto físico que se encuentra en la sucursal.");
            if (string.IsNullOrWhiteSpace(comentario))
                throw new NegocioException("Por favor, para cerrar la caja diaria se debe ingresar un comentario.");

            IdUsuarioCierre = idUsuarioCierre;
            Fecha = fecha;
            Estado = CierreCajaEstado.Cerrada;
            Abierta = abierta;
            Borrado = false;
            FechaEdicion = DateTime.Now;
            Monto = monto.Value;
            Diferencia = 0;
            Situacion = CierreCajaSituacion.SinDiferencia;
            Comentarios = comentario;
        }
    }
}
