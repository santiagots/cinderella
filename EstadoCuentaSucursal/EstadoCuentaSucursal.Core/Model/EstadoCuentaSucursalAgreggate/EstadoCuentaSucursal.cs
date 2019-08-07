using Common.Core.Model;
using EstadoCuentaSucursal.Core.Model.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstadoCuentaSucursal.Core.Model.EstadoCuentaSucursalAgreggate
{
    public  class EstadoCuentaSucursal : Entity<long>
    {
        public Egregsos Egregsos { get; protected set; }
        public Ingresos Ingresos { get; protected set; }
        public Ventas Ventas { get; protected set; }

        public EstadoCuentaSucursal()
        {
        }

        public EstadoCuentaSucursal(Egregsos egregsos, Ingresos ingresos, Ventas ventas)
        {
            Egregsos = egregsos;
            Ingresos = ingresos;
            Ventas = ventas;
        }
    }
}
