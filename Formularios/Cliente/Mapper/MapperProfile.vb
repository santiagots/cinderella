﻿Imports AutoMapper
Imports Common.Core.Model
Imports Common.Core.Enum
Imports CuentaCorrienteModelo = CuentaCorriente.Core.Model.CuentaCorrienteAggregate
Imports Ventas.Core.Model.CuentaCorrienteAggregate

Namespace Formularios.Cliente

    Public Class MapperProfile
        Inherits Profile

        Public Sub New()
            CreateMap(Of ClienteMayorista, ClienteMayoristaDetalleViewModel)() _
                .ForMember(Function(des) des.ListaPreciosSaleccionada, Sub(opt) opt.MapFrom(Function(src) New KeyValuePair(Of ListaPrecio, String)(src.ListaPrecio, src.ListaPrecio.Nombre))) _
                .ForMember(Function(des) des.CondicionesIVASaleccionada, Sub(opt) opt.MapFrom(Function(src) New KeyValuePair(Of CondicionIVA?, String)(src.CondicionIVA, src.CondicionIVA.ToString()))) _
                .ForPath(Function(des) des.FacturacionId, Sub(opt) opt.MapFrom(Function(src) src.IdDomicilioFacturacion)) _
                .ForPath(Function(des) des.FacturacionId, Sub(opt) opt.MapFrom(Function(src) src.DomicilioFacturacion.Id)) _
                .ForPath(Function(des) des.FacturacionDireccion, Sub(opt) opt.MapFrom(Function(src) src.DomicilioFacturacion.Direccion)) _
                .ForPath(Function(des) des.FacturacionProvinciasSaleccionada, Sub(opt) opt.MapFrom(Function(src) src.DomicilioFacturacion.Provincia)) _
                .ForPath(Function(des) des.FacturacionProvinciasSaleccionada.Id, Sub(opt) opt.MapFrom(Function(src) src.DomicilioFacturacion.IdProvincia)) _
                .ForPath(Function(des) des.FacturacionDistritosSaleccionada, Sub(opt) opt.MapFrom(Function(src) src.DomicilioFacturacion.Distrito)) _
                .ForPath(Function(des) des.FacturacionDistritosSaleccionada.Id, Sub(opt) opt.MapFrom(Function(src) src.DomicilioFacturacion.IdDistrito)) _
                .ForPath(Function(des) des.FacturacionLocalidadesSaleccionada, Sub(opt) opt.MapFrom(Function(src) src.DomicilioFacturacion.Localidad)) _
                .ForPath(Function(des) des.FacturacionLocalidadesSaleccionada.Id, Sub(opt) opt.MapFrom(Function(src) src.DomicilioFacturacion.IdLocalidad)) _
                .ForPath(Function(des) des.FacturacionTelefono, Sub(opt) opt.MapFrom(Function(src) src.DomicilioFacturacion.Telefono)) _
                .ForPath(Function(des) des.FacturacionMail, Sub(opt) opt.MapFrom(Function(src) src.DomicilioFacturacion.Email)) _
                .ForPath(Function(des) des.FacturacionCodigoPostal, Sub(opt) opt.MapFrom(Function(src) src.DomicilioFacturacion.CodigoPostal)) _
                .ForPath(Function(des) des.EntregaId, Sub(opt) opt.MapFrom(Function(src) src.IdDomicilioEntrega)) _
                .ForPath(Function(des) des.EntregaId, Sub(opt) opt.MapFrom(Function(src) src.DomicilioEntrega.Id)) _
                .ForPath(Function(des) des.EntregaDireccion, Sub(opt) opt.MapFrom(Function(src) src.DomicilioEntrega.Direccion)) _
                .ForPath(Function(des) des.EntregaProvinciasSaleccionada, Sub(opt) opt.MapFrom(Function(src) src.DomicilioEntrega.Provincia)) _
                .ForPath(Function(des) des.EntregaProvinciasSaleccionada.Id, Sub(opt) opt.MapFrom(Function(src) src.DomicilioEntrega.IdProvincia)) _
                .ForPath(Function(des) des.EntregaDistritosSaleccionada, Sub(opt) opt.MapFrom(Function(src) src.DomicilioEntrega.Distrito)) _
                .ForPath(Function(des) des.EntregaDistritosSaleccionada.Id, Sub(opt) opt.MapFrom(Function(src) src.DomicilioEntrega.IdDistrito)) _
                .ForPath(Function(des) des.EntregaLocalidadesSaleccionada, Sub(opt) opt.MapFrom(Function(src) src.DomicilioEntrega.Localidad)) _
                .ForPath(Function(des) des.EntregaLocalidadesSaleccionada.Id, Sub(opt) opt.MapFrom(Function(src) src.DomicilioEntrega.IdLocalidad)) _
                .ForPath(Function(des) des.EntregaCodigoPostal, Sub(opt) opt.MapFrom(Function(src) src.DomicilioEntrega.CodigoPostal)) _
                .ReverseMap() _
                    .ForMember(Function(des) des.IdListaPrecio, Sub(opt) opt.MapFrom(Function(src) src.ListaPreciosSaleccionada.Key.Id)) _
                    .ForMember(Function(des) des.ListaPrecio, Sub(opt) opt.MapFrom(Function(src) src.ListaPreciosSaleccionada.Key)) _
                    .ForMember(Function(des) des.CondicionIVA, Sub(opt) opt.MapFrom(Function(src) src.CondicionesIVASaleccionada.Key))

            CreateMap(Of DocumentoDePagoPago, ClienteMayoristaDocumentoPagoItem)() _
                .ForMember(Function(des) des.Id, Sub(opt) opt.MapFrom(Function(src) src.Id)) _
                .ForMember(Function(des) des.Descripcion, Sub(opt) opt.MapFrom(Function(src) src.ToString())) _
                .ForMember(Function(des) des.Monto, Sub(opt) opt.MapFrom(Function(src) src.MontoPago.Monto)) _
                .ForMember(Function(des) des.Cft, Sub(opt) opt.MapFrom(Function(src) src.MontoPago.CFT)) _
                .ForMember(Function(des) des.Total, Sub(opt) opt.MapFrom(Function(src) src.MontoPago.Total))
        End Sub
    End Class
End Namespace