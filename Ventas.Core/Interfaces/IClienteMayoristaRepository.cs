using Ventas.Core.Model.BaseAgreggate;

namespace Ventas.Core.Interfaces
{
    public interface IClienteMayoristaRepository
    {
        ClienteMayorista Obtener(int id);
    }
}
