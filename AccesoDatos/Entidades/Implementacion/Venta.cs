using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Entidades
{
    public class Venta: IEntity
    {
        public Int64 id_Venta { get; set; }
        public int id_Sucursal { get; set; }
        public int id_Empleado { get; set; }
        public int id_Encargado { get; set; }
        public int id_TipoVenta { get; set; }
        public int id_Cliente { get; set; }
        public Int64 id_ClienteMinorista { get; set; }
        public int id_ListaPrecio { get; set; }
        public decimal PorcentajeFacturacion { get; set; }
        public DateTime Fecha { get; set; }
        public int Habilitado { get; set; }
        public bool Anulado { get; set; }
        public bool Facturado { get; set; }
        public string DescripcionAnulado { get; set; }
        public DateTime FechaAnulado { get; set; }
        public string Numero { get; set; }
        public bool Senia { get; set; }
        public DateTime Fecha_Edicion { get; set; }
    }
}
