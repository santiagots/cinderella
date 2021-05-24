namespace Common.Core.Model
{
    public class Banco : Entity<int>
    {
        public string Nombre { get; protected set; }
        public bool Habilitado { get; protected set; }

        public Banco()
        {
        }
    }
}
