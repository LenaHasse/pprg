List<string> przedmioty = new List<string>
{
    "Miecz",
    "Tarcza",
    "Mikstura",
    "Klucz"
};
for (int i = 0; i < przedmioty.Count; i++)
{
    Console.WriteLine((i+1)+". "+przedmioty[i]);
}

bool warunek = true;


do
{
    Console.Write($"Podaj numer przedmiotu (1-{przedmioty.Count}) lub wyjdź (0) do usuniecia: "); 
    bool poprawnaLiczba = int.TryParse(Console.ReadLine()!, out int wynik);
    if (poprawnaLiczba && wynik >= 1 && wynik <= 4)
    {
        Console.WriteLine("Usunięto "+przedmioty[wynik-1]);
        przedmioty.RemoveAt(wynik - 1);
    }
    else if (przedmioty.Count <= 1)
    {
        Console.WriteLine("Koniec - skonczyły się przedmioty");
        warunek = false;
    }
    else if (wynik == 0)
    {
        break;
    }
    else
    {
        Console.WriteLine($"Liczba musi należeć do zazkresu 1-{przedmioty.Count}");
    }
} while (warunek);
