using System.ComponentModel.DataAnnotations;

namespace FootballPlayersCatalog.models;

public class UpdatePlayerModel
{
    [Required]
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Gender { get; set; }
    public string BirthDate { get; set; }
    public string TeemName { get; set; }
    public string Country { get; set; }
}