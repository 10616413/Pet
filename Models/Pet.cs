namespace Pet.Models;

public class Pet
{
    public int Id {get; set;}
    public string? name {get; set;}
    public string? owner { get; set; }
    public string? breed { get; set; }
    public DateOnly dob {get; set;}
    public string? urlToImage {get; set;}

}