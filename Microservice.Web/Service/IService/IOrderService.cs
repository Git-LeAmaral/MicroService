using Microservice.Web.Models;
using Microservices.Web.Models;

namespace Microservice.Web.Service.IService
{
    public interface IOrderService
    {
        Task<ResponseDto?> CreateOrder(CartDto cartDto);
    }
}
