using FishingStats.Models;
using FishingStats.Models.Responses;
using FishingStats.Services.Interfaces;

namespace FishingStats.Services.Mappers;

public class UserMapper : IUserMapper
{
    public UserResponse Map(User user)
        => new()
        {
            Id = user.Id,
            UserName = user.Username
        };

    public List<UserResponse> Map(List<User> users) 
        => users.Select(user => Map(user)).ToList();
}