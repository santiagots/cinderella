using System;
using Xunit;
using Ventas.Core.Model.VentaAggregate;
using Common.Core.Exceptions;
using System.Collections.Generic;
using Ventas.Core.Model.ValueObjects;

namespace Ventas.Test
{
    public class PagoTest
    {
        //[Fact]
        //public void Instanciar_PagoEfectivo_Sin_Monto()
        //{
        //    Pago pago;

        //    Action act = () => pago = new PagoEfectivo(null);

        //    Assert.Throws<NegocioException>(act);
        //}

        //[Fact]
        //public void Instanciar_PagoCheque_Sin_Monto()
        //{
        //    Pago pago;

        //    Action act = () => pago = new PagoCheque(null);

        //    Assert.Throws<NegocioException>(act);
        //}

        //[Fact]
        //public void Instanciar_PagoCredito_Sin_Monto()
        //{
        //    Pago pago;

        //    Action act = () => pago = new PagoCredito(new Banco("banco"), 1, null);

        //    Assert.Throws<NegocioException>(act);
        //}

        //[Fact]
        //public void Instanciar_PagoCredito_Sin_Banco()
        //{
        //    Pago pago;

        //    Action act = () => pago = new PagoCredito(null, 1, new MontoPago(1,1,1,1));

        //    Assert.Throws<NegocioException>(act);
        //}

        //[Theory]
        //[InlineData(0)]
        //[InlineData(-11)]
        //public void Instanciar_PagoCredito_Cuota_Invalida(int numeroCuota)
        //{
        //    Pago pago;

        //    Action act = () => pago = new PagoCredito(null, numeroCuota, new MontoPago(1, 1, 1, 1));

        //    Assert.Throws<NegocioException>(act);
        //}

        //[Fact]
        //public void Instanciar_PagoDeposito_Sin_Monto()
        //{
        //    Pago pago;

        //    Action act = () => pago = new PagoDeposito(null);

        //    Assert.Throws<NegocioException>(act);
        //}

        //[Fact]
        //public void Instanciar_PagoDebito_Sin_Monto()
        //{
        //    Pago pago;

        //    Action act = () => pago = new PagoDebito(new Banco("banco"), null);

        //    Assert.Throws<NegocioException>(act);
        //}

        //[Fact]
        //public void Instanciar_PagoDebito_Sin_Banco()
        //{
        //    Pago pago;

        //    Action act = () => pago = new PagoDebito(null, new MontoPago(1, 1, 1, 1));

        //    Assert.Throws<NegocioException>(act);
        //}
    }
}
