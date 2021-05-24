using System;

namespace Common.Core.Model
{
    public class Usuario : Entity<int>
    {
        public string UsuarioNombre { get; private set; }
        public string Password { get; private set; }
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public string Mail { get; private set; }
        public DateTime Fecha { get; private set; }
        public bool Habilitado { get; private set; }
        public int IdPerfil { get; private set; }
    }
}
