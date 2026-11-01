int[] zlotoWTurach = { 5, 12, 0, 8, 15 };
int suma = 0;
int turaMin10 = 0;
for (int i=1; i<zlotoWTurach.Length; i++)
{
    if (zlotoWTurach[i] >= 10)
    {
        turaMin10++;
    }
    suma += zlotoWTurach[i];
    Console.WriteLine($"Tura {i}: {zlotoWTurach[i]} sztuk złota");
}

double srednia = (double)suma / zlotoWTurach.Length;
Console.WriteLine($"\nŁącznie {suma}");
Console.WriteLine($"Średnia: {srednia}");
Console.WriteLine($"Tury z wynikiem co najmniej 10: {turaMin10}");
Console.Write("Od końca: ");
for (int i = zlotoWTurach.Length-1; i >= 1; i--)
{
    Console.Write(zlotoWTurach[i]+" ");
}
