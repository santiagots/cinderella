
using Common.Core.Model;
using System.Collections.Generic;

namespace Common.Core.Interfaces
{
    public interface IIVARepository
    {
        IList<IVA> Obtener();
        IVA Obtener(decimal porcentaje);
    }
}
