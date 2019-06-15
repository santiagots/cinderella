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
                .ForMember(des => des.NotaPedidoItems, opt => opt.MapFrom(src => src.VentaItems));

            CreateMap<NotaPedido, Venta>()
                .ForMember(des => des.VentaItems, opt => opt.MapFrom(src => src.NotaPedidoItems));

            CreateMap<VentaItem, NotaPedidoItem>();

            CreateMap<NotaPedidoItem, VentaItem>();
        }
    }
}
