Imports AutoMapper
Imports Common.Core.Model
Imports Common.Core.Enum

Namespace Formularios.Cliente

    Public Class MapperProfile
        Inherits Profile

        Public Sub New()
            CreateMap(Of ClienteMayorista, ClienteMayoristaDetalleViewModel)() _
                .ForMember(Function(des) des.ListaPreciosSaleccionada, Sub(opt) opt.MapFrom(Function(src) New KeyValuePair(Of Integer?, String)(src.ListaPrecio, ""))) _
                .ForMember(Function(des) des.CondicionesIVASaleccionada, Sub(opt) opt.MapFrom(Function(src) New KeyValuePair(Of CondicionIVA?, String)(src.CondicionIVA, src.CondicionIVA.ToString()))) _
                .ForPath(Function(des) des.FacturacionId, Sub(opt) opt.MapFrom(Function(src) src.IdDomicilioFacturacion)) _
                .ForPath(Function(des) des.FacturacionId, Sub(opt) opt.MapFrom(Function(src) src.DomicilioFacturacion.Id)) _
                .ForPath(Function(des) des.FacturacionProvinciasSaleccionada, Sub(opt) opt.MapFrom(Function(src) src.DomicilioFacturacion.Provincia)) _
                .ForPath(Function(des) des.FacturacionProvinciasSaleccionada.Id, Sub(opt) opt.MapFrom(Function(src) src.DomicilioFacturacion.IdProvincia)) _
                .ForPath(Function(des) des.FacturacionDistritosSaleccionada, Sub(opt) opt.MapFrom(Function(src) src.DomicilioFacturacion.Distrito)) _
                .ForPath(Function(des) des.FacturacionDistritosSaleccionada.Id, Sub(opt) opt.MapFrom(Function(src) src.DomicilioFacturacion.IdDistrito)) _
                .ForPath(Function(des) des.FacturacionLocalidadesSaleccionada, Sub(opt) opt.MapFrom(Function(src) src.DomicilioFacturacion.Localidad)) _
                .ForPath(Function(des) des.FacturacionLocalidadesSaleccionada.Id, Sub(opt) opt.MapFrom(Function(src) src.DomicilioFacturacion.IdLocalidad)) _
                .ForPath(Function(des) des.FacturacionTelefono, Sub(opt) opt.MapFrom(Function(src) src.DomicilioFacturacion.Telefono)) _
                .ForPath(Function(des) des.FacturacionMail, Sub(opt) opt.MapFrom(Function(src) src.DomicilioFacturacion.Email)) _
                .ForPath(Function(des) des.FacturacionCodigoPostal, Sub(opt) opt.MapFrom(Function(src) src.DomicilioEntrega.CodigoPostal)) _
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
                    .ForMember(Function(des) des.ListaPrecio, Sub(opt) opt.MapFrom(Function(src) src.ListaPreciosSaleccionada.Key)) _
                    .ForMember(Function(des) des.CondicionIVA, Sub(opt) opt.MapFrom(Function(src) src.CondicionesIVASaleccionada.Key))

        End Sub
    End Class
End Namespace