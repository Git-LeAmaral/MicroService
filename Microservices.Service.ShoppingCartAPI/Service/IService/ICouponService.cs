using Microservices.Service.ShoppingCartAPI.Models.Dto;

namespace Microservices.Service.ShoppingCartAPI.Service.IService
{
    public interface ICouponService
    {
        Task<CouponDto> GetCoupon(string couponCode);
    }
}
