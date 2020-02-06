
using Factura.Core.Model.AfipAgreggate;
using System;

namespace Factura.Core.Interfaces
{
    public interface IAfipTokenAccesRepository
    {
        AfipTokenAcces Obtener(DateTime fechaGeneracion);
        void Guardar(AfipTokenAcces afipTokenAcces);
    }
}
