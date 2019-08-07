﻿using Common.Core.Exceptions;
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

        public void Abir(int idUsuarioAbrir)
        {
            IdUsuarioAbre = idUsuarioAbrir;
            Estado = CierreCajaEstado.Abierta;
            Abierta = true;
            Borrado = false;
            FechaEdicion = DateTime.Now;            
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

            if (montoFisico == montoRegistrado)
            {
                Situacion = CierreCajaSituacion.SinDiferencia;
                Diferencia = 0;
            }
            else if (montoFisico > montoRegistrado)
            {
                Situacion = CierreCajaSituacion.SobranteDinero;
                Comentarios = "Sobrante de dinero en el cierre de caja.";
                Diferencia = montoFisico.Value - montoRegistrado;
            }
            else
            {
                Situacion = CierreCajaSituacion.FaltanteDinero;
                Comentarios = "Faltante de dinero en el cierre de caja.";
                Diferencia = montoRegistrado - montoFisico.Value;
            }
        }
    }
}
