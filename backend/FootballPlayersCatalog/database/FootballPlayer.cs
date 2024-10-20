namespace FootballPlayersCatalog.Entities;

public class FootballPlayer
{
    public int PlayerId { set; get; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Gender { get; set; }
    public string BirthDate { get; set; }
    public string TeemName { get; set; }
    public string Country { get; set; }
}