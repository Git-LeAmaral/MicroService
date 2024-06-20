using Microservice.Service.OrderAPI.Models.Dto;

namespace Microservices.Service.OrderAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
