using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Core.Model.VentaAggregate;

namespace Ventas.Core.Interfaces
{
    public interface ICostoFinancieroRepository
    {
        IEnumerable<CostoFinanciero> Obtener(int idTarjeta);
    }
}
