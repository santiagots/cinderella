using Common.Core.Exceptions;
using Factura.Service.NotaCredito.Contracts;

namespace Common.Service.NotaCredito
{
    internal class NotaCreditoElectrinicaStrategy : INotaCreditoStrategy
    {
        public ObtenerNumeroNotaCretidoResponse ObtenerNumeroNotaCretido(ObtenerNumeroNotaCretidoRequest request)
        {
            throw new NegocioException("El metodo de generacion de nota de crédito electrónico no se encuentra implementado");
        }
    }
}