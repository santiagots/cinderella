using System.Collections.Generic;

namespace Common.Core.Model
{
    public class Categoria : Entity<int>
    {
        public string Descripcion { get; protected set; }
        public virtual IList<SubCategoria> SubCategorias { get; protected set; }
        public bool Habilitado { get; protected set; }

        internal Categoria()
        { }
    }
}
