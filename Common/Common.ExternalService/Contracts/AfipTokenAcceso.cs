using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ExternalService.Contracts
{
    public class AfipTokenAcceso
    {
        public UInt32 UniqueId { get; private set; }
        public DateTime FechaGeneracion { get; private set; }
        public DateTime FechaExpiracion { get; private set; }
        public string Firma { get; private set; }
        public string Token { get; private set; }

        public AfipTokenAcceso()
        {
            FechaGeneracion = DateTime.Now;
            FechaExpiracion = DateTime.Now;
        }

        public AfipTokenAcceso(UInt32 uniqueId, DateTime fechaGeneracion, DateTime fechaExpiracion, string firma, string token)
        {
            UniqueId = uniqueId;
            FechaGeneracion = fechaGeneracion;
            FechaExpiracion = fechaExpiracion;
            Firma = firma;
            Token = token;
        }
    }
}
