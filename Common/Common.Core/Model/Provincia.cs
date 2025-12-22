namespace Common.Core.Model
{
    public class Provincia: Entity<int>
    {
        public string Descripcion { get; set; }
        public bool Habilitado { get; set; }
    }
}
