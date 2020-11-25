namespace Common.Core.Model
{
    public class Localidad : Entity<int>
    {
        public int IdDepartamente { get; internal set; }
        public string Descripcion { get; internal set; }
        public bool Habilitado { get; internal set; }
    }
}
