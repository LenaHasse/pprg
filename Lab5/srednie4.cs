Console.Write("Ile wypraw chcesz zapisać (1-10)? ");
int liczbaWypraw = int.Parse(Console.ReadLine()!);

// check zakresu
while (liczbaWypraw < 1 || liczbaWypraw > 10)
{
    Console.Write("Podaj liczbę z przedziału 1-10: ");
    liczbaWypraw = int.Parse(Console.ReadLine()!);
}

int[] zdobyteZloto = new int[liczbaWypraw];

// wczytanie wynikow z wypraw
for (int numerTury = 0; numerTury < zdobyteZloto.Length; numerTury++)
{
    Console.Write($"Wynik tury {numerTury + 1}: ");
    zdobyteZloto[numerTury] = int.Parse(Console.ReadLine()!);

    while (zdobyteZloto[numerTury] < 0)
    {
        Console.Write("Wartość nie może być ujemna. Podaj ponownie: ");
        zdobyteZloto[numerTury] = int.Parse(Console.ReadLine()!);
    }
}

Console.WriteLine("\nWprowadzone dane:");

foreach (int wynik in zdobyteZloto)
{
    Console.WriteLine(wynik);
}

// obliczenie łącznej ilości złota
int laczneZloto = 0;

foreach (int wynik in zdobyteZloto)
{
    laczneZloto += wynik;
}

// wyszukiwanie min i max
int najmniej = zdobyteZloto[0];
int najwiecej = zdobyteZloto[0];

foreach (int wynik in zdobyteZloto)
{
    if (wynik < najmniej)
    {
        najmniej = wynik;
    }

    if (wynik > najwiecej)
    {
        najwiecej = wynik;
    }
}

// pierwsza tura z najlepszym wynikiem
int pierwszaNajlepszaTura = 0;

for (int i = 0; i < zdobyteZloto.Length; i++)
{
    if (zdobyteZloto[i] == najwiecej)
    {
        pierwszaNajlepszaTura = i + 1;
        break;
    }
}

// liczba tur z maksymalnym wynikiem
int licznikMaksimum = 0;

foreach (int wynik in zdobyteZloto)
{
    if (wynik == najwiecej)
    {
        licznikMaksimum++;
    }
}

// sumowanie
int pierwszaTuraBezZlota = -1;

for (int i = 0; i < zdobyteZloto.Length; i++)
{
    if (zdobyteZloto[i] == 0)
    {
        pierwszaTuraBezZlota = i + 1;
        break;
    }
}

// podsumowanie
Console.WriteLine("\nPodsumowanie:");
Console.WriteLine($"Suma: {laczneZloto}");
Console.WriteLine($"Minimum: {najmniej}");
Console.WriteLine($"Maksimum: {najwiecej}");
Console.WriteLine($"Pierwszy najlepszy wynik: tura {pierwszaNajlepszaTura}");
Console.WriteLine($"Liczba tur z maksimum: {licznikMaksimum}");

if (pierwszaTuraBezZlota == -1)
{
    Console.WriteLine("Brak tury bez złota.");
}
else
{
    Console.WriteLine($"Pierwsza tura bez złota: {pierwszaTuraBezZlota}");
}