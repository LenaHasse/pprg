//zad3

Console.Write("Podaj wiek: ");
int wiek = int.Parse(Console.ReadLine()!);

if (wiek < 0)
{
    Console.WriteLine("Niepoprawny wiek");
}
else if (wiek < 13)
{
    Console.WriteLine("dziecko");
}
else if (wiek >= 13 && wiek <= 17)
{
    Console.WriteLine("nastolatek");
}
else if (wiek >= 18 && wiek <= 64)
{
    Console.WriteLine("dorosły");
}
else
{
    Console.WriteLine("senior");
}

//zad4
Console.Write("Podaj punkty życia: ");
int hp=int.Parse(Console.ReadLine()!);

Console.Write("Czy bohater ma klucz? (true/false) ");
bool MaKlucz=bool.Parse(Console.ReadLine()!);

Console.Write("Czy bohater zna hasło? (true/false) ");
bool ZnaHaslo=bool.Parse(Console.ReadLine()!);

if (hp <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Bohater nie może wejść, ponieważ nie żyje");
}
else
{
    if (MaKlucz || ZnaHaslo)
    {
        Console.WriteLine("Bohater może wejść");
    }
    else
    {
        Console.WriteLine("Bohater nie może wejść, ponieważ nie ma sposobu na otwarcie drzwi");
    }
}