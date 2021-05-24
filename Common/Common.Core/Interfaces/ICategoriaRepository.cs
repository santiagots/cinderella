
using Common.Core.Model;
using System.Collections.Generic;

namespace Common.Core.Interfaces
{
    public interface ICategoriaRepository
    {
        IList<Categoria> Obtener();
    }
}
