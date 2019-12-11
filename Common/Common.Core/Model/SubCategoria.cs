namespace Common.Core.Model
{
    public class SubCategoria : Entity<int>
    {
        public int IdCategoria { get; private set; }
        public Categoria Categoria { get; private set; }
        public string Descripcion { get; protected set; }
        public bool Habilitado { get; protected set; }

        internal SubCategoria()
        { }
    }
}
