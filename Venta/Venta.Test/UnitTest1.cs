using System;
using System.Collections.Generic;
using Common.Core.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio;
using Ventas.Core.Model.InformeAggregate;
using Ventas.Data;
using Ventas.Data.Repository;
using Producto.Core.Model.ProductoAgreggate;
using Common.ExternalService;
using Common.ExternalService.Contracts;
using Common.Core.Model;
using Common.Core.Helper;

namespace Venta.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestObtenerPorTipoVenta()
        {
            InformeVentaRepository repository = new InformeVentaRepository(new VentaContext());
            var informeVenta = repository.InformeVentaPorTipoVenta(new List<int>() { 2, 27, 30, 32, 33, 34, 41, 42, 43, 44 },
                                                            new DateTime(1990, 1, 1),
                                                            new DateTime(2030, 1, 1));
        }

        [TestMethod]
        public void TestObtenerObtenerPorTipoPago()
        {
            InformeVentaRepository repository = new InformeVentaRepository(new VentaContext());
            var informeVenta = repository.InformeVentaPorTipoPago(new List<int>() { 2, 27, 30, 32, 33, 34, 41, 42, 43, 44 },
                                                            new DateTime(1990, 1, 1),
                                                            new DateTime(2030, 1, 1));
        }

        [TestMethod]
        public void TestObtenerObtenerObtenerPorFecha()
        {
            int cantidad = 0;
            InformeVentaRepository repository = new InformeVentaRepository(new VentaContext());
            var informeVenta = repository.InformeVentaPorFecha(new List<int>() { 2, 27, 30, 32, 33, 34, 41, 42, 43, 44 },
                                                            new DateTime(1990, 1, 1),
                                                            new DateTime(2030, 1, 1),
                                                            "Fecha",
                                                            OrdenadoDireccion.DESC,
                                                            10,
                                                            2,
                                                            out cantidad);
        }

        [TestMethod]
        public void TestObtenerCostos()
        {
            InformeVentaRepository repository = new InformeVentaRepository(new VentaContext());
            var informeVenta = repository.InformeCostos(new List<int>() { 2, 27, 30, 32, 33, 34, 41, 42, 43, 44 },
                                                            new DateTime(1990, 1, 1),
                                                            new DateTime(2030, 1, 1));
        }

        [TestMethod]
        public void TestObtenerGastos()
        {
            InformeVentaRepository repository = new InformeVentaRepository(new VentaContext());
            var informeVenta = repository.InformeGastos(new List<int>() { 2, 27, 30, 32, 33, 34, 41, 42, 43, 44 },
                                                            new DateTime(1990, 1, 1),
                                                            new DateTime(2030, 1, 1));
        }

        [TestMethod]
        public void TestObtenerMercaderia()
        {
            int cantidad = 0;
            InformeVentaRepository repository = new InformeVentaRepository(new VentaContext());
            var informeVenta = repository.InformeMercaderia(new List<int>() { 2, 27, 30, 32, 33, 34, 41, 42, 43, 44 },
                                                            new DateTime(1990, 1, 1),
                                                            new DateTime(2030, 1, 1),"Cantidad",OrdenadoDireccion.DESC,10,1, out cantidad);
        }

        [TestMethod]
        public void TestObtenerAfipToken()
        {
            AfipTokenAcces response = Common.ExternalService.AfipTokenAccesService.Obtener("wsfe", "c:\\cinderella.p12", "cinderella");
        }

        [TestMethod]
        public void TestObtenerFechaVenciamiento()
        {
            DateTime fecha = CertificadosX509.ObtenerVencimiento("c:\\cinderella.p12", "cinderella");
        }


        [TestMethod]
        public void TestFacturacionAElectronica()
        {
            Common.ExternalService.AfipFacturacionElectronicaService.ObtenerCEA(TipoCliente.Mayorista,
                                                                                TipoDocumentoFiscal.Factura,
                                                                                CondicionIVA.Responsable_Inscripto,
                                                                                100,
                                                                                "20111111112");
        }

        [TestMethod]
        public void TestFacturacionBElectronica()
        {
            Common.ExternalService.AfipFacturacionElectronicaService.ObtenerCEA(TipoCliente.Minorista,
                                                                                TipoDocumentoFiscal.Factura,
                                                                                CondicionIVA.Consumidor_Final,
                                                                                100,
                                                                                "20111111112");
        }
    }
}
