using Common.Core.Enum;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Core.Model.ChequeAggregate;
using Ventas.Core.Model.VentaAggregate;

namespace Ventas.Core.Interfaces
{
    public interface IChequeRepository
    {
        IEnumerable<Cheque> Buscar(int idSucursal, bool? facturado, string cliente, string librador, DateTime? fechaIngresoDesde, DateTime? fechaIngresoHasta, DateTime? fechaDepositoDesde, DateTime? fechaDepositoHasta, DateTime? fechaVencimientoDesde, DateTime? fechaVencimientoHasta, DateTime? fechaSalidaDesde, DateTime? fechaSalidaHasta, IEnumerable<EstadoCheque> estado, IEnumerable<DestinoSalidaCheque> destinoSalida, decimal? montoDesde, decimal? montoHasta, int? numero, int? idBanco);
        void Actualizar(Cheque cheque);
        void Alta(Cheque cheque);
        Cheque Obtener(long idCheque);
        decimal TotalCartera(int idSucursal);
        int UltimoNumeroDeOrden(int idSucursal);
    }
}
