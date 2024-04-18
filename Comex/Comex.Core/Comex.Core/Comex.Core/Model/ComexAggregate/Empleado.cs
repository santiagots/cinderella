using Common.Core.Enum;
using Common.Core.Model;

namespace Comex.Core.Model.ComexAggregate
{
    public class Empleado : Entity<int>
    {
        public string Apellido { get; private set; }
        public string Nombre { get; private set; }
        public bool Habilitado { get; private set; }
        public TipoEmpleado Tipo { get; private set; }
        public string ApellidoYNombre { get { return $"{Apellido} {Nombre}"; } }

        protected Empleado() : base(false)
        {
        }
    }
}
