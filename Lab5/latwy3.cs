Dictionary<string, int> ceny = new Dictionary<string, int>
{
    { "Mikstura", 15 },
    { "Pochodnia", 5 },
    { "Miecz", 40 }
};

Console.WriteLine($"Liczba pozycji {ceny.Count}");
Console.WriteLine("\nCennik:");

foreach (KeyValuePair<string, int> para in ceny)
{
    Console.WriteLine($"{para.Key}: {para.Value}");
}

Console.Write("\nPodaj nazwę przedmiotu: ");
string przedmiotUzytkownika=Console.ReadLine()!;
if (ceny.ContainsKey(przedmiotUzytkownika))
{
    Console.WriteLine($"Cena: {ceny[przedmiotUzytkownika]} sztuk złota");
}
else
{
    Console.WriteLine("Nie ma takiego przedmiotu.");
}

ceny["Mikstura"]=12;

Console.WriteLine("\nCennik:");

foreach (KeyValuePair<string, int> para in ceny)
{
    Console.WriteLine($"{para.Key}: {para.Value}");
}

