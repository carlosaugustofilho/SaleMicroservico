using AutoMapper;
using Vendas.API.Data.VelueObjects;

namespace Vendas.API.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps() 
        {
            var mappinConfig = new MapperConfiguration(config => { 
                config.CreateMap<ItemPedidoVO, ItemPedido>();
                config.CreateMap<ItemPedido, ItemPedidoVO>();
            });
            return mappinConfig;
        }
    }
}
