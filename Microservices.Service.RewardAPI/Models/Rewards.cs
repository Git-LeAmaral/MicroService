namespace Microservices.Service.RewardAPI.Models
{
    public class Rewards
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTime RewardsDate { get; set; }
        public int RewardActivity { get; set; }
        public int OrderId { get; set; }
    }
}
