using System;
using Common.Core.Exceptions;

namespace Common.Core.Model
{
    public class SubCategoria : Entity<int>
    {
        public int IdCategoria { get; private set; }
        public virtual Categoria Categoria { get; private set; }
        public int IdIVA { get; private set; }
        public virtual IVA IVA { get; private set; }
        public string Descripcion { get; protected set; }
        public bool Habilitado { get; protected set; }

        internal SubCategoria()
        { }

        public SubCategoria(string descripcion, IVA iva, bool habilitado, Categoria categoria): base(true)
        {
            ActualizarDatos(descripcion, iva, habilitado, categoria);
        }

        public void ActualizarDatos(string descripcion, IVA iva, bool habilitado, Categoria categoria)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
                throw new NegocioException("Error al generar la subcategoría. La descripción no puede estar vacía.");

            Descripcion = descripcion;
            IVA = iva ?? throw new NegocioException("Error al generar la subcategoría. El IVA no puede esta vacía.");
            IdIVA = iva.Id;
            Habilitado = habilitado;
            Categoria = categoria ?? throw new NegocioException("Error al generar la subcategoría. La categoria no puede esta vacía.");
            IdCategoria = categoria.Id;
        }
    }
}
