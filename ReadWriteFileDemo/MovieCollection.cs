namespace ReadWriteFileDemo;

public class MovieCollection
{
    private List<Movie> _movies;

    public List<Movie> Movies => _movies;

    public MovieCollection()
    {
        PopulateMovies();
    }

    private void PopulateMovies()
    {
        _movies = new()
        {
            new ()
            {
                Title = "Scream",
                Description = "A year after the murder of her mother, a teenage girl is terrorized by a new killer, " +
                              "who targets the girl and her friends by using horror films as part of a deadly game.",
                Length = 1.85,
                Genres = new List<Genres>()
                {
                    Genres.Horror
                }
            },
            new ()
            {
                Title = "Event Horizon",
                Description = "A rescue crew investigates a spaceship that disappeared into a black hole and has now returned..." +
                              "with someone or something new on-board.",
                Length = 1.6,
                Genres = new List<Genres>()
                {
                    Genres.SciFi,
                    Genres.Horror,
                    Genres.Thriller
                }
            },
            new ()
            {
                Title = "Awakenings",
                Description = "The victims of an encephalitis epidemic many years ago have been catatonic " +
                              "ever since, but now a new drug offers the prospect of reviving them.",
                Length = 2.017,
                Genres = new List<Genres>()
                {
                    Genres.Drama
                }
            },
            new ()
            {
                Title = "Constantine",
                Description = "Supernatural exorcist and demonologist John Constantine helps a policewoman " +
                              "prove her sister's death was not a suicide, but something more.",
                Length = 2.017,
                Genres = new List<Genres>()
                {
                    Genres.Action,
                    Genres.Fantasy,
                    Genres.Horror
                }
            },
            new ()
            {
                Title = "Don't Look Up",
                Description = "Two low-level astronomers must go on a giant media tour to warn humankind of an approaching comet that will destroy planet Earth.",
                Length = 2.3,
                Genres = new List<Genres>()
                {
                    Genres.Drama,
                    Genres.SciFi,
                    Genres.Comedy
                }
            }
        };
    }
}