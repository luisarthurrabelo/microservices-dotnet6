using AutoMapper;
using GeekShopping_ProductAPI.Data.ValueObjects;
using GeekShopping_ProductAPI.Model;

namespace GeekShopping_ProductAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductVO, Product>();
                config.CreateMap<Product, ProductVO>();
            });

            return mappingConfig;
        }
    }
}
