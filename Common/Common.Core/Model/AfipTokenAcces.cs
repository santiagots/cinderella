using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Core.Model
{
    public class AfipTokenAcces : Entity<long>
    {
        public DateTime FechaGeneracion { get; protected set; }
        public DateTime FechaExpiracion { get; protected set; }
        public string Firma { get; protected set; }
        public string Token { get; protected set; }

        internal AfipTokenAcces() { }

        public AfipTokenAcces(int id, DateTime fechaGeneracion, DateTime fechaExpiracion, string firma, string token)
        {
            Id = id;
            FechaGeneracion = fechaGeneracion;
            FechaExpiracion = fechaExpiracion;
            Firma = firma;
            Token = token;
        }

        public bool EsValido() => FechaExpiracion > DateTime.Now;
    }
}
