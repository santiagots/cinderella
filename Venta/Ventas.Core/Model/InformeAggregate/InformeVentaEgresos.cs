namespace Ventas.Core.Model.InformeAggregate
{
    public class InformeVentaEgresos
    {
        public string Nombre { get; internal set; }
        public decimal Monto { get; internal set; }

        protected InformeVentaEgresos()
        { }

        public InformeVentaEgresos(string nombre, decimal monto)
        {
            Nombre = nombre;
            Monto = monto;
        }

    }
}
