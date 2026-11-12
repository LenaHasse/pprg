Console.Write("Podaj wysokosc choinki (2-10): ");
int wysokosc_choinki= int.Parse(Console.ReadLine()!);
int ilosc_spacji = 0;
int ilosc_gwiazd = 0;

for (int i = 1; i <= wysokosc_choinki; i++)
{
    if (i != 1)
    {
        ilosc_spacji=wysokosc_choinki-i;
        ilosc_gwiazd = 2 * i -1;
        Console.Write("\n");
        Console.Write(new string(' ', ilosc_spacji));
        Console.Write(new string('*', ilosc_gwiazd));
    }
    else
    {
        ilosc_spacji=wysokosc_choinki-i;
        Console.Write(new string(' ', ilosc_spacji));
        Console.Write("*");
    }
}

ilosc_spacji = wysokosc_choinki - 1;
Console.Write("\n");
Console.Write(new string(' ', ilosc_spacji));
Console.Write("*");

