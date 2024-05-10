using Microseervices.Services.AuthAPI.Models;

namespace Microseervices.Services.AuthAPI.Service.IService
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationUser);
    }
}
