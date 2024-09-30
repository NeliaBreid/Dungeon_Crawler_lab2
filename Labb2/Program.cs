

// sparar en textfil i mitt system
string textfile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Levels", "Level1.txt");



if (File.Exists(textfile)) //om filen finns, läser in filen.
{
    Console.WriteLine(File.ReadAllText(textfile)); // Läs in, skriv ut
}
