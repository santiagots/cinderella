﻿using Common.Data.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Ventas.Core.Enum;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.VentaAggregate;

namespace Ventas.Data.Repository
{
    public class ReservaRepository : BaseRepository<VentaContext>, IReservaRepository
    {
        public ReservaRepository(VentaContext ventaContext) : base(ventaContext)
        {
        }

        public void Guardar(Reserva reserva)
        {
            if (_context.Reserva.Any(x => x.Id == reserva.Id))
            {
                reserva.VentaReserva.VentaItems.ToList().ForEach(x => x.Producto = null); //pongo null la Producto porque sino entra en conflicto cuando varios productos tiene la misma Producto
                reserva.VentaEntrega.VentaItems.ToList().ForEach(x => x.Producto = null); //pongo null la Producto porque sino entra en conflicto cuando varios productos tiene la misma Producto
                _context.Entry(reserva).State = EntityState.Modified;
            }
            else
            {
                _context.Entry(reserva.VentaReserva).State = EntityState.Unchanged;
                _context.Reserva.Add(reserva);
            }

            _context.SaveChanges();
        }

        public IEnumerable<Reserva> Buscar(int idSucursal, bool entregada, string nombre, DateTime? fechaAlta, DateTime? fechaRetiro, ReservaMetodoEntrega? metodoEntrega)
        {
            IQueryable<Reserva> resultado = _context.Reserva.Where(x => x.IdSucursal == idSucursal &&  x.Entregada == entregada);

            if (!string.IsNullOrEmpty(nombre))
                resultado = resultado.Where(x => x.Nombre.Contains(nombre) || x.Apellido.Contains(nombre));

            if (fechaAlta.HasValue)
                resultado = resultado.Where(x => DbFunctions.TruncateTime(x.FechaAlta).Value >= DbFunctions.TruncateTime(fechaAlta).Value);

            if (fechaRetiro.HasValue)
                resultado = resultado.Where(x => DbFunctions.TruncateTime(x.FechaEstimadaRetiro).Value >= DbFunctions.TruncateTime(fechaRetiro).Value);

            if (metodoEntrega.HasValue)
                resultado = resultado.Where(x => x.MetodoEntrega == metodoEntrega);

            return resultado.ToList();
        }

        public Reserva ObtenerPorIdVenta(long idVenta)
        {
            return _context.Reserva
                .Include(x => x.VentaReserva.Pagos)
                .Include(x => x.VentaReserva.VentaItems)
                .Include(x => x.VentaReserva.ClienteMayorista)
                .Include(x => x.VentaReserva.Encargado)
                .Include(x => x.VentaReserva.Vendedor)
                .Include(x => x.VentaReserva.Factura.NumeroFactura)
                .Include(x => x.VentaReserva.NotaCredito.NumeroNotaCredito)
                .Where(x => x.IdVentaEntrega == idVenta || x.IdVentaReserva == idVenta).FirstOrDefault();
        }

        public Reserva Obtener(long idReserva)
        {
            return _context.Reserva
                .Include(x => x.VentaReserva.Pagos)
                .Include(x => x.VentaReserva.VentaItems)
                .Include(x => x.VentaReserva.VentaItems.Select(y => y.Producto.SubCategoria.IVA))
                .Include(x => x.VentaReserva.ClienteMayorista)
                .Include(x => x.VentaReserva.Encargado)
                .Include(x => x.VentaReserva.Vendedor)
                .Include(x => x.VentaReserva.Factura.NumeroFactura)
                .Include(x => x.VentaReserva.NotaCredito.NumeroNotaCredito)
                .Where(x=> x.Id == idReserva).FirstOrDefault();
        }

        public void Eliminar(long id)
        {
            Reserva reserva = _context.Reserva.Find(id);
            _context.Reserva.Remove(reserva);
            _context.SaveChanges();
        }
    }
}
