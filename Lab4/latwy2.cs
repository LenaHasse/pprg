Console.Write("Podaj liczbę dni wyprawy: ");
int dni_wyprawy=int.Parse(Console.ReadLine()!);
Console.WriteLine("Dni wyprawy: " + dni_wyprawy);
int zloto = 5;
int zlotoWDniu = 0;
int powyzej10 = 0;
for (int i = 1; i <= dni_wyprawy; i++)
{
    Console.Write($"Złoto w dniu {i}: ");
    zlotoWDniu = int.Parse(Console.ReadLine());
    zloto += zlotoWDniu;
    if (zlotoWDniu > 10)
    {
        powyzej10++;
    }
}

Console.WriteLine($"\nŁącznie znaleziono: {zloto} sztuk złota");
Console.WriteLine($"Dni z wynikiem powyżej 10 sztuk złota: {powyzej10}");