namespace ReadWriteFileDemo;

public class Movie
{
    public string Name { get; set; }  = string.Empty;
    public double Length { get; set; }
    public string Description { get; set; } = string.Empty;
    public IEnumerable<Genres> Genres { get; set; } = new List<Genres>();

    //Overridar implementationen för ToString på Movie, alltså hur objekt av typen Movie beskrivs som text när man tex. gör Console.WriteLine(pulpFiction);
    public override string ToString()
    {
        var output = string.Empty;
        output += $"Name: {Name}\n";
        output += $"Length: {Length} hours\n";
        output += $"Description: {Description}\n";
        output += $"Genres: ";
        foreach (var genre in Genres)
        {
            output += $"{genre},";
        }
        output += "\n";
        return output;
    }
}