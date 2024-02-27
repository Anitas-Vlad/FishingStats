using FishingStats.Models;

namespace FishingStats.Services.Interfaces;

public interface IJwtService
{
    string CreateToken(User user);
}