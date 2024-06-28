using Microservice.Services.EmailAPI.Model.Dto;
using Microservices.Service.EmailAPI.Message;

namespace Microservices.Service.EmailAPI.Services
{
    public interface IEmailService
    {
        Task EmailCartAndLog(CartDto cartDto);
        Task RegisterUserEmailAndLog(string email);
        Task LogOrderPlaced(RewardsMessage rewardDto);
    }
}
