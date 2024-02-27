using FishingStats.Models;
using FishingStats.Models.Responses;

namespace FishingStats.Services.Interfaces;

public interface IUserMapper
{
    UserResponse Map(User user);
    List<UserResponse> Map(List<User> users);
}