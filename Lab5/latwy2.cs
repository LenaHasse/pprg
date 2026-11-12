List<string> plecak = new List<string>
{
    "Miecz",
    "Mikstura",
    "Pochodnia"
};

const int maksPojemnosc = 6;

Console.WriteLine($"Plecak ({plecak.Count}/{maksPojemnosc}):");

for (int i = 0; i < plecak.Count; i++)
{
    Console.WriteLine($"{i + 1}. {plecak[i]}");
}

Console.WriteLine();

Console.Write("Znaleziony przedmiot: ");
string znalezionyPrzedmiot = Console.ReadLine()!;

if (plecak.Count < maksPojemnosc)
{
    plecak.Add(znalezionyPrzedmiot);
    Console.WriteLine($"Dodano: {znalezionyPrzedmiot}");
}

if (plecak.Remove("Mikstura"))
{
    Console.WriteLine("Użyto mikstury.");
}

Console.WriteLine();
Console.WriteLine($"Plecak ({plecak.Count}/{maksPojemnosc}):");

for (int i = 0; i < plecak.Count; i++)
{
    Console.WriteLine($"{i + 1}. {plecak[i]}");
}