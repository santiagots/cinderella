Imports AutoMapper
Imports Model = Ventas.Core.Model

Namespace Comunes

    Public Class MapperProfile
        Inherits Profile

        Public Sub New()
            CreateMap(Of Model.VentaAggregate.Venta, VentaDetalleViewModel)() _
                .ForMember(Function(des) des.Fecha, Sub(opt) opt.MapFrom(Function(src) src.Fecha)) _
                .ForMember(Function(des) des.NombreClienteMayorista, Sub(opt) opt.MapFrom(Function(src) src.ClienteMayorista.RazonSocial)) _
                .ForMember(Function(des) des.NombreEncargado, Sub(opt) opt.MapFrom(Function(src) src.Encargado.ApellidoYNombre)) _
                .ForMember(Function(des) des.NombreVendedor, Sub(opt) opt.MapFrom(Function(src) src.Vendedor.ApellidoYNombre)) _
                .ForMember(Function(des) des.Sucursal, Sub(opt) opt.MapFrom(Function(src) src.Sucursal.Nombre)) _
                .ForMember(Function(des) des.TipoCliente, Sub(opt) opt.MapFrom(Function(src) src.TipoCliente)) _
                .ForMember(Function(des) des.PorcentajeFacturacion, Sub(opt) opt.MapFrom(Function(src) src.PorcentajeFacturacion)) _
                .AfterMap(Sub(src, des)
                              Dim VentaItemViewModel As VentaItemViewModel = New VentaItemViewModel() With {
                                .Nombre = "Total",
                                .Cantidad = src.CantidadTotal,
                                .Iva = src.MontoTotal.Iva,
                                .Monto = src.MontoTotal.Valor,
                                .Total = src.MontoTotal.toDecimal()
                                }
                              des.TotalVentaItem.Add(VentaItemViewModel)

                              Dim PagoViewModel As PagoViewModel = New PagoViewModel() With {
                                .CFT = src.PagoTotal.CFT,
                                .IVA = src.PagoTotal.IVA,
                                .Descuento = src.PagoTotal.Descuento,
                                .Monto = src.PagoTotal.Monto,
                                .Total = src.PagoTotal.Total,
                                .Descripcion = "Total"
                                }
                              des.TotalPago.Add(PagoViewModel)
                          End Sub)

            CreateMap(Of Model.VentaAggregate.VentaItem, VentaItemViewModel)() _
                .ForMember(Function(des) des.Cantidad, Sub(opt) opt.MapFrom(Function(src) src.Cantidad)) _
                .ForMember(Function(des) des.Codigo, Sub(opt) opt.MapFrom(Function(src) src.Producto.Codigo)) _
                .ForMember(Function(des) des.Iva, Sub(opt) opt.MapFrom(Function(src) src.MontoProducto.Iva)) _
                .ForMember(Function(des) des.Monto, Sub(opt) opt.MapFrom(Function(src) src.MontoProducto.Valor)) _
                .ForMember(Function(des) des.Nombre, Sub(opt) opt.MapFrom(Function(src) src.Producto.Nombre)) _
                .ForMember(Function(des) des.PorcentajeBonificacion, Sub(opt) opt.MapFrom(Function(src) src.PorcentajeBonificacion)) _
                .ForMember(Function(des) des.PorcentajePago, Sub(opt) opt.MapFrom(Function(src) src.PorcentajePago)) _
                .ForMember(Function(des) des.Facturar, Sub(opt) opt.MapFrom(Function(src) src.Facturada)) _
                .ForMember(Function(des) des.Anulada, Sub(opt) opt.MapFrom(Function(src) src.Anulada)) _
                .ForMember(Function(des) des.Seleccionado, Sub(opt) opt.MapFrom(Function(src) src.Seleccionado)) _
                .ForMember(Function(des) des.Total, Sub(opt) opt.MapFrom(Function(src) src.Total().toDecimal()))

            CreateMap(Of Model.NotaPedidoAgreggate.NotaPedidoItem, VentaItemViewModel)() _
                .ForMember(Function(des) des.Cantidad, Sub(opt) opt.MapFrom(Function(src) src.Cantidad)) _
                .ForMember(Function(des) des.Codigo, Sub(opt) opt.MapFrom(Function(src) src.Producto.Codigo)) _
                .ForMember(Function(des) des.Iva, Sub(opt) opt.MapFrom(Function(src) src.MontoProducto.Iva)) _
                .ForMember(Function(des) des.Monto, Sub(opt) opt.MapFrom(Function(src) src.MontoProducto.Valor)) _
                .ForMember(Function(des) des.Nombre, Sub(opt) opt.MapFrom(Function(src) src.Producto.Nombre)) _
                .ForMember(Function(des) des.PorcentajeBonificacion, Sub(opt) opt.MapFrom(Function(src) src.PorcentajeBonificacion)) _
                .ForMember(Function(des) des.Total, Sub(opt) opt.MapFrom(Function(src) src.Total().toDecimal()))

            CreateMap(Of VentaItemViewModel, Model.VentaAggregate.VentaItem)() _
                 .ForMember(Function(des) des.Cantidad, Sub(opt) opt.MapFrom(Function(src) src.Cantidad)) _
                 .ForPath(Function(des) des.Producto.Codigo, Sub(opt) opt.MapFrom(Function(src) src.Codigo)) _
                 .ForPath(Function(des) des.MontoProducto.Iva, Sub(opt) opt.MapFrom(Function(src) src.Iva)) _
                 .ForPath(Function(des) des.MontoProducto.Valor, Sub(opt) opt.MapFrom(Function(src) src.Monto)) _
                 .ForPath(Function(des) des.Producto.Nombre, Sub(opt) opt.MapFrom(Function(src) src.Nombre)) _
                 .ForMember(Function(des) des.PorcentajeBonificacion, Sub(opt) opt.MapFrom(Function(src) src.PorcentajeBonificacion)) _
                 .ForMember(Function(des) des.PorcentajePago, Sub(opt) opt.MapFrom(Function(src) src.PorcentajePago))

            CreateMap(Of Model.VentaAggregate.VentaPago, PagoViewModel)() _
                 .ForMember(Function(des) des.CFT, Sub(opt) opt.MapFrom(Function(src) src.MontoPago.CFT)) _
                 .ForMember(Function(des) des.Descripcion, Sub(opt) opt.MapFrom(Function(src) src.ToString())) _
                 .ForMember(Function(des) des.Descuento, Sub(opt) opt.MapFrom(Function(src) src.MontoPago.Descuento)) _
                 .ForMember(Function(des) des.Id, Sub(opt) opt.MapFrom(Function(src) src.Id)) _
                 .ForMember(Function(des) des.IVA, Sub(opt) opt.MapFrom(Function(src) src.MontoPago.IVA)) _
                 .ForMember(Function(des) des.Monto, Sub(opt) opt.MapFrom(Function(src) src.MontoPago.Monto)) _
                 .ForMember(Function(des) des.Total, Sub(opt) opt.MapFrom(Function(src) src.MontoPago.Total)) _
                 .ForMember(Function(des) des.Resto, Sub(opt) opt.MapFrom(Function(src) src.MontoRestante)) _
                 .ForMember(Function(des) des.Habilitado, Sub(opt) opt.MapFrom(Function(src) src.Habilitado))
        End Sub
    End Class
End Namespace
