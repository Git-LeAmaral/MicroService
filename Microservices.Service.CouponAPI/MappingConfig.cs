using AutoMapper;
using Microservices.Service.CouponAPI.Models;
using Microservices.Service.CouponAPI.Models.Dto;

namespace Microservices.Service.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });
            return mappingConfig;
        }
    }
}
