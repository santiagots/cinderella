using Factura.Service.NotaCredito.Contracts;

namespace Common.Service.NotaCredito
{
    public interface INotaCreditoStrategy
    {
        ObtenerNumeroNotaCretidoResponse ObtenerNumeroNotaCretido(ObtenerNumeroNotaCretidoRequest request);
    }
}
