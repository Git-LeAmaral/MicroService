using Microservices.Service.ShoppingCartAPI.Models.Dto;

namespace Microservices.Service.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
