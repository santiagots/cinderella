namespace Common.Core.Model
{
    public class Domicilio : Entity<int>
    {
        public string Direccion { get; set; }
        public int IdProvincia { get; set; }
        public Provincia Provincia { get; set; }
        public int IdDistrito { get; set; }
        public Distrito Distrito { get; set; }
        public int IdLocalidad { get; set; }
        public Localidad Localidad { get; set; }
        public string Telefono { get; set; }
        public string CodigoPostal { get; set; }
        public string Email { get; set; }
    }
}
