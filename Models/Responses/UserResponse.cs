using System.ComponentModel.DataAnnotations;

namespace FishingStats.Models.Responses;

public class UserResponse
{
    public int Id { get; set; }
    [Required] public string UserName { get; set; }
}