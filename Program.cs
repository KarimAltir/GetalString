using Eigenshappen;

string getal;

List<GetalString> getalString = new List<GetalString>();

Console.Write("Geef de tekst in:");
getal = Console.ReadLine();

GetalString getalInstance = new GetalString(getal);
getalString.Add(getalInstance);

foreach (GetalString getalStringInstance in getalString)
{
    Console.WriteLine(getalStringInstance.ToString());
}
