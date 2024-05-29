using Microservices.Service.ShoppingCartAPI.Models.Dto;
using Microservices.Service.ShoppingCartAPI.Service.IService;
using Newtonsoft.Json;

namespace Microservices.Service.ShoppingCartAPI.Service
{
    public class CouponService : ICouponService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CouponService(IHttpClientFactory clientFactory)
        {
            _httpClientFactory = clientFactory;
        }

        public async Task<CouponDto> GetCoupon(string couponCode)
        {
            var client = _httpClientFactory.CreateClient("Coupon");
            var response = await client.GetAsync($"/api/coupon/GetByCode/{couponCode}");
            
           /* if (!response.IsSuccessStatusCode)
            {
                var errorMessage = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Falha em pegar o coupon. status code: {response.StatusCode}, Message: {errorMessage}");
                return new CouponDto();
            }*/

            var apiContent = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"Response Content: {apiContent}");
            var resp = JsonConvert.DeserializeObject<ResponseDto>(apiContent);
            if (resp.IsSuccess)
            {
                return JsonConvert.DeserializeObject<CouponDto>(Convert.ToString(resp.Result));
            }
            Console.WriteLine("Response was not succesful or was null");
            return new CouponDto();
        }
    }
}
