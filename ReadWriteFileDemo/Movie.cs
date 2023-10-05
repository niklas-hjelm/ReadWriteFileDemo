namespace ReadWriteFileDemo;

public record Movie : IEqualityComparer<Movie>
{
    public string Title { get; set; } = string.Empty;
    public double Length { get; set; }
    public string Description { get; set; } = string.Empty;
    public IEnumerable<Genres> Genres { get; set; } = new List<Genres>();

    //Overridar implementationen för ToString på Movie, alltså hur objekt av typen Movie beskrivs som text när man tex. gör Console.WriteLine(pulpFiction);
    public override string ToString()
    {
        var output = string.Empty;
        output += $"Title: {Title}\n";
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

    public bool Equals(Movie x, Movie y)
    {
        if (ReferenceEquals(x, y)) return true;
        if (ReferenceEquals(x, null)) return false;
        if (ReferenceEquals(y, null)) return false;
        if (x.GetType() != y.GetType()) return false;
        return x.Title == y.Title && x.Length.Equals(y.Length) && x.Description == y.Description && x.Genres.Equals(y.Genres);
    }

    public int GetHashCode(Movie obj)
    {
        return HashCode.Combine(obj.Title, obj.Length, obj.Description, obj.Genres);
    }
}