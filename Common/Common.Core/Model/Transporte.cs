namespace Common.Core.Model
{
    public class Transporte : Entity<int>
    {
        public string RazonSocial { get; set; }
        public string Cuit { get; set; }
        public bool Habilitado { get; set; }
        public int? IdDomicilio { get; set; }
        public Domicilio Domicilio { get; set; }

        public Transporte()
        { }

        public Transporte(int id, string razonSocial, string cuit, bool habilitado, Domicilio domicilio)
        {
            Id = id;
            RazonSocial = razonSocial;
            Cuit = cuit;
            Habilitado = habilitado;
            IdDomicilio = domicilio.Id;
            Domicilio = domicilio;
        }
    }
}
