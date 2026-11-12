int zdrowieBohatera = 60;
int zdrowiePrzeciwnika = 45;
int liczbaMikstur = 2;
int numerTury = 1;

int akcja = 0;
bool uciekl = false;

while (zdrowieBohatera > 0 && zdrowiePrzeciwnika > 0)
{
    Console.WriteLine($"\nTura {numerTury}");
    Console.WriteLine($"Punkty życia:");
    Console.WriteLine($"Bohatera: {zdrowieBohatera}");
    Console.WriteLine($"Przeciwnika: {zdrowiePrzeciwnika}");
    Console.WriteLine($"Mikstury: {liczbaMikstur}");

    Console.WriteLine("\nWybierz akcję:");
    Console.WriteLine("1 - Atak");
    Console.WriteLine("2 - Mikstura");
    Console.WriteLine("3 - Ucieczka");

    if (!int.TryParse(Console.ReadLine(), out akcja))
    {
        Console.WriteLine("Wpisz poprawną liczbę!");
        continue;
    }

    if (akcja < 1 || akcja > 3)
    {
        Console.WriteLine("Wybierz akcję od 1 do 3.");
        continue;
    }

    numerTury++;

    switch (akcja)
    {
        case 1:
            Console.WriteLine("Bohater atakuje przeciwnika.");
            zdrowiePrzeciwnika -= 8;

            if (zdrowiePrzeciwnika > 0)
            {
                Console.WriteLine("Przeciwnik atakuje bohatera.");
                zdrowieBohatera -= 12;
            }
            break;

        case 2:
            if (liczbaMikstur > 0)
            {
                Console.WriteLine("Bohater pije miksturę.");
                zdrowieBohatera += 15;
                liczbaMikstur--;

                Console.WriteLine("Przeciwnik atakuje bohatera.");
                zdrowieBohatera -= 7;
            }
            else
            {
                Console.WriteLine("Brak mikstur!");
                Console.WriteLine("Przeciwnik atakuje bohatera.");
                zdrowieBohatera -= 7;
            }
            break;

        case 3:
            Console.WriteLine("Bohater ucieka. Koniec gry.");
            uciekl = true;
            zdrowieBohatera = 0;
            break;
    }
}

Console.WriteLine("\n=== KONIEC GRY ===");

if (uciekl)
{
    Console.WriteLine("Bohater uciekł z walki.");
}
else if (zdrowiePrzeciwnika <= 0)
{
    Console.WriteLine("Bohater wygrał!");
}
else
{
    Console.WriteLine("Przeciwnik wygrał!");
}