namespace Common.Core.Model
{
    public class Distrito : Entity<int>
    {
        public string Descripcion { get; internal set; }
        public bool Habilitado { get; internal set; }
    }
}
