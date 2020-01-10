
using Common.Core.Model;
using System;

namespace Common.Core.Interfaces
{
    public interface IAfipTokenAccesRepository
    {
        AfipTokenAcces Obtener(DateTime fechaGeneracion);
        void Guardar(AfipTokenAcces afipTokenAcces);
    }
}
