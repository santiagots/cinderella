using Common.Core.Enum;
using Common.Core.Model;

namespace Ventas.Core.Model.BaseAgreggate
{
    public class Sucursal: Entity<int>
    {
        public string Nombre { get; private set; }
        public string CodigoVenta { get; private set; }
        public decimal PorcentajeComisionMinoristaVendedor { get; private set; }
        public decimal PorcentajeComisionMinoristaEncargado { get; private set; }
        public decimal PorcentajeComisionMayoristaVendedor { get; private set; }
        public decimal PorcentajeComisionMayoristEncargado { get; private set; }
        public decimal PorcentajeComisionMinoristaVendedorFeriado { get; private set; }
        public decimal PorcentajeComisionMinoristaEncargadoFeriado { get; private set; }

        public void ObtenerPorcentajeComision(bool esFeriado, TipoCliente tipoCliente, out decimal porcentajeComisionVendedor, out decimal porcentajeComisionEncargado)
        {
            if (tipoCliente == TipoCliente.Minorista)
            {
                if (esFeriado)
                {
                    porcentajeComisionVendedor = PorcentajeComisionMinoristaVendedorFeriado;
                    porcentajeComisionEncargado = PorcentajeComisionMinoristaEncargadoFeriado;
                }
                else
                {
                    porcentajeComisionVendedor = PorcentajeComisionMinoristaVendedor;
                    porcentajeComisionEncargado = PorcentajeComisionMinoristaEncargado;
                }
            }
            else
            {
                porcentajeComisionVendedor = PorcentajeComisionMayoristaVendedor;
                porcentajeComisionEncargado = PorcentajeComisionMayoristEncargado;
            }
        }
    }
}
