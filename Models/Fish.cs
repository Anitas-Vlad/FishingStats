using System.ComponentModel.DataAnnotations;
using FishingStats.Models.Enums;

namespace FishingStats.Models;

public class Fish
{
    public int Id { get; set; }
    [Required] public double Lenght { get; set; }
    [Required] public FishBreed Breed { get; set; }
}