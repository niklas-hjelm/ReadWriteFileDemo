using ReadWriteFileDemo;

var movieDb = new MovieCollection();

//Path.Combine används för att bygga sökvägar på ett korrekt sätt.
//I Environment kan man hitta alla standard-mappar i en windowsdator. Tex. AppData, Desktop, MyDocuments mm.
var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Demo.txt");

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
}

if (File.Exists(path))
{
    string? line = "";
    //StreamReader används för att öppna en fil och läsa från den.
    //nyckelordet using används här för att på ett säkert sätt stänga den öppnade filen så den inte är låst efter operationen
    using StreamReader sr = new StreamReader(path);
    //ReadLine() läser nästa rad i filen
    while ((line = sr.ReadLine()) != null)
    {
        Console.WriteLine(line);
    }
}