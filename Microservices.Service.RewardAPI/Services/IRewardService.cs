using Microservices.Service.RewardAPI.Message;

namespace Microservices.Service.RewardAPI.Services
{
    public interface IRewardService
    {
        Task UpdateRewards(RewardsMessage rewardsMessage);
    }
}
