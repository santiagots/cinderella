using Factura.Service.NotaCredito.Contracts;

namespace Common.Service.NotaCredito
{
    internal class NotaCreditoManualStrategy : INotaCreditoStrategy
    {
        public ObtenerNumeroNotaCretidoResponse ObtenerNumeroNotaCretido(ObtenerNumeroNotaCretidoRequest request)
        {
            return new ObtenerNumeroNotaCretidoResponse();
        }
    }
}