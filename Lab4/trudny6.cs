//Pobieranie zmiennych
Console.Write("Imię bohatera: ");
string imie = Console.ReadLine()!;

const int maxHp = 100;
int ekslopracje = 0;

Console.Write("Aktualne zdrowie: ");
int hp;
while(!int.TryParse(Console.ReadLine(), out hp) || hp<1 || hp>100)
{
    Console.WriteLine("Podaj poprawną liczbę!");
}

const int maxZlotoNa_start = 50;
string powodZakonczenia = "";

Console.Write("Ilość złota (na start masz 50): ");
int zloto;
while(!int.TryParse(Console.ReadLine(), out zloto) || zloto < 0)
{
    Console.WriteLine("Podaj poprawną liczbę!");
}
zloto += maxZlotoNa_start;


Console.Write("Podaj liczbę misktur: ");
int mikstury;
while(!int.TryParse(Console.ReadLine(), out mikstury) || mikstury <0)
{
    Console.WriteLine("Podaj poprawną liczbę!");
}

bool graDziala = true;
//TURY
int tura = 1;
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("=== HELLO ADVENTURER ===");
Console.ResetColor();

Console.WriteLine($"Tura: {tura}");
Console.WriteLine($"Bohater: {imie}");
Console.WriteLine($"Zdrowie: {hp}/{maxHp} | Złoto: {zloto} | Mikstury: {mikstury}");
while (hp > 0&& graDziala)
{
    double procentHp = (double)hp / maxHp * 100;
    bool zyje = hp > 0;
    bool NiskiPoziomZdrowia = zyje && hp < 25;
    bool maPelneZdrowie = hp == maxHp;
    bool wymagaLeczenia = hp < maxHp;
    bool gotowyDoWalki = zyje && mikstury > 0;
    
    Console.WriteLine($"\nTura: {tura}");
    if (NiskiPoziomZdrowia)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Bohater jest ranny");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Bohater jest w dobrej formie");
        
    }
    Console.ResetColor();
    
    //kolor zdrowia
    ConsoleColor kolorZdrowia;
    if (procentHp > 50)
    {
        kolorZdrowia = ConsoleColor.Green;
    }
    else if (procentHp > 25)
    {
        kolorZdrowia = ConsoleColor.Yellow;
    }
    else
    {
        kolorZdrowia = ConsoleColor.Red;
    }
    
    Console.WriteLine("\n Wybierz akcję: \n 1 - Eksploruj loch \n 2 - Przygotuj miksturę \n 3 - Użyj miksturę \n 4 - Odpocznij \n 5 - Pokaż statystyki \n 6 - zakończ grę");
    int akcja;
    while (true)
    {
        Console.Write("Wybierz liczbę: ");

        if (int.TryParse(Console.ReadLine(), out akcja))
        {
            if (akcja >= 1 && akcja <= 6)
            {
                break;
            }
        }

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Nieprawidlowa akcja! Wybierz liczbę 1-6");
        Console.ResetColor();
    }

    switch (akcja)
    {
        case 1:
            Console.WriteLine("Eksploracja...");
            hp -= 8;
            zloto += 10;
            ekslopracje++;
            break;
        case 2:
            Console.WriteLine("Przygotowuje miskture...");
            mikstury += 1;
            break;
        case 3:
            if (mikstury > 0)
            {
                Console.WriteLine("Używa miksturę...");
                if (hp + 20 > maxHp)
                {
                    mikstury--;
                    hp = maxHp;
                }
                else
                {
                    hp += 20;
                    mikstury--;
                }
                
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Nie masz mikstur!");
                Console.ResetColor();
            }
            
            break;
        case 4:
            Console.WriteLine("Odpoczywa...");
            if (zloto >= 3)
            {
                if (hp + 5 > maxHp)
                {
                    hp = maxHp;
                }
                else
                {
                    hp += 5;
                }

                zloto -= 3;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Nie masz wystarczająco dużo złota do odpoczynku.");
                Console.ResetColor();
            }
            break;
        case 5:
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("+=======================================+");
            Console.WriteLine("|             KARTA BOHATERA            |");
            Console.WriteLine("+=======================================+");
            Console.ResetColor();

            Console.WriteLine($"| Bohater: {imie}\t\t|");
            Console.WriteLine($"| Ekslopracje: {ekslopracje}\t\t|");
            Console.WriteLine("+---------------------------------------+");
            Console.ForegroundColor = kolorZdrowia;
            Console.WriteLine($"| Zdrowie: {hp}/{maxHp} ({Math.Round(procentHp, 2)}%)\t\t\t|");
            Console.ResetColor();
            Console.WriteLine("+---------------------------------------+");

            Console.WriteLine($"| Misktury: {mikstury}\t\t\t\t|");
            Console.WriteLine($"| Złoto: {zloto}\t\t\t\t|");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("+---------------------------------------+");
            Console.WriteLine($"| Żyje: {zyje}\t\t\t\t|");
            Console.WriteLine($"| Ma pełne zdrowie: {maPelneZdrowie}\t\t|");
            Console.WriteLine($"| Wymaga leczenia: {wymagaLeczenia}\t\t\t|");
            Console.WriteLine($"| Gotowy do walki {gotowyDoWalki}\t\t\t|");
            Console.WriteLine("+=======================================+");
            Console.ResetColor();
            continue;
        case 6:
            graDziala = false;
            powodZakonczenia = "Zakończone przez gracza";
            Console.WriteLine("Zakończyłeś grę");
            Console.WriteLine("=== KONIEC GRY ===");
            Console.WriteLine($"Bohater: {imie}");
            Console.WriteLine($"Tury: {tura}");
            Console.WriteLine($"Zdrowie: {hp}/{maxHp}");
            Console.WriteLine($"Złoto: {zloto}");
            Console.WriteLine($"Mikstury: {mikstury}");
            Console.WriteLine($"Powód zakończenia: {powodZakonczenia}");
            hp = 0;
            break;
        default:
            Console.WriteLine("Nieznana akcja");
            break;
    }
    if (graDziala)
    {
        tura++;
    }
}
if (hp <= 0)
{
    powodZakonczenia = "Bohater stracił wszystkie punkty życia.";
}

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n=== KONIEC GRY ===");
Console.ResetColor();

Console.WriteLine($"Bohater: {imie}");
Console.WriteLine($"Rozegrane tury: {tura}");
Console.WriteLine($"Eksploracje: {ekslopracje}");
Console.WriteLine($"Zdrowie: {hp}/{maxHp}");
Console.WriteLine($"Złoto: {zloto}");
Console.WriteLine($"Mikstury: {mikstury}");
Console.WriteLine($"Powód zakończenia: {powodZakonczenia}");