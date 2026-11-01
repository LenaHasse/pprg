Console.Write("Podaj punkty życia: ");
int hp = int.Parse(Console.ReadLine()!);

Console.Write("Podaj podstawowe obrażenia broni: ");
int podstawoweObrazeniaBroni = int.Parse(Console.ReadLine()!);

Console.Write("Czy bohater ma miksturę? ");
bool CzyMaMiksture = bool.Parse(Console.ReadLine()!);

Console.Write("Wybierz akcje (1 - atak, 2 - leczenie, 3 - ucieczka) ");
int akcja = int.Parse(Console.ReadLine()!);

if (hp <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Przegrana");
}
else if (hp < 20)
{
    Console.WriteLine("Ostrzeżenie, bohater ma mało punktów życia");
}
else
{
    switch (akcja)
    {
        case 1:
            Console.WriteLine(podstawoweObrazeniaBroni);
            break;
        case 2:
            if (CzyMaMiksture)
            {
                Console.WriteLine("Leczenie");
            }
            break;
        case 3:
            Console.WriteLine("Ucieczka");
            break;
        default:
            Console.WriteLine("Nieznana akcja");
            break;
    }
}

