using Microservice.Web.Models;

namespace Microservice.Web.Service.IService
{
    public interface ICartService
    {
        Task<ResponseDto?> GetCartByUserIdAsync(string userId);
        Task<ResponseDto?> UpsertCartAsync(CartDto cartDto);
        Task<ResponseDto?> RemoveCartAsync(int cartDetailId);
        Task<ResponseDto?> ApplyCouponAsync(CartDto cartDto);
    }
}
