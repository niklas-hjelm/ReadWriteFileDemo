using ReadWriteFileDemo;

var movieDb = new MovieCollection();

//Path.Combine används för att bygga sökvägar på ett korrekt sätt.
//I Environment kan man hitta alla standard-mappar i en windowsdator. Tex. AppData, Desktop, MyDocuments mm.
var directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "NiklasNet23");
Directory.CreateDirectory(directory);
var path = Path.Combine(directory, "Demo.txt");

//File.Exists kan användas för att kontrollera ifall en fil finns på en given sökväg
if (!File.Exists(path))
{
    //StreamWriter används för att öppna en fil och skriva till den.
    //nyckelordet using används här för att på ett säkert sätt stänga den öppnade filen så den inte är låst efter operationen
    using StreamWriter sw = new StreamWriter(path);
    foreach (var movie in movieDb.Movies)
    {
        //WriteLine används för att skriva en ny rad.
        sw.WriteLine(movie);
    }
    sw.Close();
}

if (File.Exists(path))
{
    List<Movie> movieList = new List<Movie>();
    string? line = "";

    string title = "";
    string length = "";
    string description = "";
    string genres = "";

    //StreamReader används för att öppna en fil och läsa från den.
    //nyckelordet using används här för att på ett säkert sätt stänga den öppnade filen så den inte är låst efter operationen
    using StreamReader sr = new StreamReader(path);
    //ReadLine() läser nästa rad i filen
    while ((line = sr.ReadLine()) != null)
    {
        if (line.StartsWith("Title: "))
        {
            title = line.Substring(7);
        }
        else if (line.StartsWith("Length: "))
        {
            length = line.Substring(8);
        }
        else if (line.StartsWith("Description: "))
        {
            description = line.Substring(13);
        }
        else if (line.StartsWith("Genres: "))
        {
            genres = line.Substring(8);
        }
        else
        {
            Movie tempMovie = new Movie();
            tempMovie.Title = title;
            tempMovie.Description = description;

            string lengthText = length.Split(' ')[0];
            tempMovie.Length = double.Parse(lengthText);

            tempMovie.Genres = new List<Genres>(); // Fixa
        }
    }
}