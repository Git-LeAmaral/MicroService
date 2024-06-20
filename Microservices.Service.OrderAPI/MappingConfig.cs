using AutoMapper;
using Microservice.Service.OrderAPI.Models.Dto;
using Microservices.Service.OrderAPI.Models;
using Microservices.Service.OrderAPI.Models.Dto;

namespace Microservices.Services.OrderAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<OrderHeaderDto, CartHeaderDto>()
                    .ForMember(dest => dest.CartTotal, u => u.MapFrom(src => src.OrderTotal)).ReverseMap();

                config.CreateMap<CartDetailsDto, OrderDetailsDto>()
                    .ForMember(dest => dest.ProductName, u => u.MapFrom(src => src.Product.Name))
                    .ForMember(dest => dest.Price, u => u.MapFrom(src => src.Product.Price));

                config.CreateMap<OrderHeader, OrderHeaderDto>().ReverseMap();
                config.CreateMap<OrderDetailsDto, OrderDetails>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
