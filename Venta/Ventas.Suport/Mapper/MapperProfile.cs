using AutoMapper;
using Ventas.Core.Model.NotaPedidoAgreggate;
using Ventas.Core.Model.VentaAggregate;

namespace Ventas.Suport.Mapper
{
    public class MapperProfile: Profile
    {
        public MapperProfile()
        {
            CreateMap<Venta, NotaPedido>()
                .ForMember(des => des.NotaPedidoItems, opt => opt.MapFrom(src => src.VentaItems))
                .ForMember(des => des.Numero, opt => opt.Ignore());

            CreateMap<NotaPedido, Venta>()
                .ForMember(des => des.VentaItems, opt => opt.MapFrom(src => src.NotaPedidoItems))
                .ForMember(des => des.Numero, opt => opt.Ignore());

            CreateMap<VentaItem, NotaPedidoItem>();

            CreateMap<NotaPedidoItem, VentaItem>();
        }
    }
}
