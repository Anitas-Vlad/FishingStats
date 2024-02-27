using FishingStats.Models.Requests;

namespace FishingStats.Services.Interfaces;

public interface IAuthService
{
    Task<string> Login(LoginRequest request);
}