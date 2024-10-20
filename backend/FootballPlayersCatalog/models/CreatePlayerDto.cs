using System.ComponentModel.DataAnnotations;

namespace FootballPlayersCatalog.models;

public class CreatePlayerDto
{
    [Required]
    public string Name { get; set; }
    [Required]
    public string Surname { get; set; }
    [Required]
    public string Gender { get; set; }
    [Required]
    public string BirthDate { get; set; }
    [Required]
    public string TeemName { get; set; }
    [Required]
    public string Country { get; set; }
}