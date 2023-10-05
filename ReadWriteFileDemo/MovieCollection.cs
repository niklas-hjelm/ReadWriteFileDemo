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
        _movies = new List<Movie>()
        {
            new Movie()
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
            },
            new ()
            {
                Title = "The Martian",
                Description = "An astronaut becomes stranded on Mars after his team assume him dead, and must rely on his ingenuity to find a way to signal to Earth that he is alive and can survive until a potential rescue.",
                Length = 2.24,
                Genres = new List<Genres>()
                {
                    Genres.Adventure,
                    Genres.SciFi,
                    Genres.Drama
                }
            },
            new ()
            {
                Title = "Barbie",
                Description = "Barbie suffers a crisis that leads her to question her world and her existence.",
                Length = 1.54,
                Genres = new List<Genres>()
                {
                    Genres.Adventure,
                    Genres.Comedy,
                    Genres.Fantasy
                }
            },
            new ()
            {
                Title = "I am legend",
                Description = "Years after a plague kills most of humanity and transforms the rest into monsters, the sole survivor in New York City struggles valiantly to find a cure.",
                Length = 1.41,
                Genres = new List<Genres>()
                {
                    Genres.Action,
                    Genres.Drama,
                    Genres.Horror
                }
            },
            new ()
            {
                Title = "Superpower",
                Description = "Follows the events happening in Ukraine and the truth about Russia's invasion of the country.",
                Length = 1.55,
                Genres = new List<Genres>()
                {
                    Genres.Documentary
                }
            },
            new ()
            {
                Title = "The deepest breath",
                Description = "A champion and expert safety diver seemed destined for one another. Despite different paths taken, they meet at the pinnacle of the free-diving world, experiencing the thrilling rewards and inescapable risks of chasing dreams through the depths of the ocean.",
                Length = 1.48,
                Genres = new List<Genres>()
                {
                    Genres.Documentary
                }
            }
        };
    }
}