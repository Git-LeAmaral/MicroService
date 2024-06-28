using Microservices.Service.RewardAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Microservices.Service.RewardAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Rewards> Rewards { get; set; }

    }
}
