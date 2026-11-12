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
//PLECAK
List<string> plecak = new List<string>
{
    "Miecz",
    "Mikstura"
};

//ZNALEZISKA
string[] znaleziska =
{
    "Mikstura",
    "Klucz",
    "Pochodnia",
    "Zwój"
};

//HISTORIA
List<string> historia = new List<string>();

bool graDziala = true;
//TURY
int tura = 1;
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("=== HELLO ADVENTURER ===");
Console.ResetColor();

Console.WriteLine($"Tura: {tura}");
Console.WriteLine($"Bohater: {imie}");
Console.WriteLine($"Zdrowie: {hp}/{maxHp} | Złoto: {zloto} |");
bool zuzytoTure = false;

int[] zlotoZdobyteWTurach = new int[20];

while (hp > 0&& graDziala)
{
    double procentHp = (double)hp / maxHp * 100;
    bool zyje = hp > 0;
    bool NiskiPoziomZdrowia = zyje && hp < 25;
    bool maPelneZdrowie = hp == maxHp;
    bool wymagaLeczenia = hp < maxHp;
    
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
    
    Console.WriteLine("\n Wybierz akcję: \n 1 - Eksploruj loch \n 2 - Pokaż plecak \n 3 - Użyj przedmiotu \n 4 - Dodaj znalezisko \n 5 - Wyrzuć przedmiot \n 6 - Pokaż historię \n 7 - Pokaż statystyki \n 8 - Zakończ grę");
    int akcja;
    while (true)
    {
        Console.Write("Wybierz liczbę: ");

        if (int.TryParse(Console.ReadLine(), out akcja))
        {
            if (akcja >= 1 && akcja <= 8)
            {
                break;
            }
        }

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Nieprawidlowa akcja! Wybierz liczbę 1-8");
        Console.ResetColor();
    }
    zuzytoTure = false;

    switch (akcja)
    {
        case 1:
            Console.WriteLine("Eksploracja...");
            if (tura-1 < zlotoZdobyteWTurach.Length)
            {
                zlotoZdobyteWTurach[tura-1] = 10;
            }
            
            hp -= 8;
            zloto += 10;
            ekslopracje++;
            zuzytoTure = true;
            if (hp < 0)
            {
                hp = 0;
            }

            historia.Add($"Eksploracja w {tura} turze");
            break;
        case 2:
            Console.WriteLine("Pokazywanie plecaka...");
            if (plecak.Count >= 1)
            {
                for (int i=0; i<plecak.Count; i++)
                {
                    Console.WriteLine($"{i+1}- {plecak[i]}");
                }
            }
            else
            {
                Console.WriteLine("Plecak jest pusty");
            }
            break;
        case 3:
            if (plecak.Count == 0)
            {
                Console.WriteLine("Plecak jest pusty");
                break;
            }
            Console.WriteLine("Używa przedmiotu...");
            Console.WriteLine("Wybierz nr przedmiotu który chcesz użyć \n");
            for (int i = 0; i < plecak.Count; i++)
            {
                Console.WriteLine($"{i + 1}- {plecak[i]}");
            }

            int wybor3;
            while (!int.TryParse(Console.ReadLine(), out wybor3) || wybor3 < 1 || wybor3 > plecak.Count)
            {
                Console.WriteLine("Podaj poprawną liczbę!");
            }

            string wybranyPrzedmiot = plecak[wybor3 - 1];
            if (wybranyPrzedmiot == "Mikstura")
            {
                if (hp + 20 > maxHp)
                {
                    hp = maxHp;
                }
                else
                {
                    hp += 20;
                }
                plecak.RemoveAt(wybor3-1);
                historia.Add("Użyto mikstury");
            }

            if (wybranyPrzedmiot == "Pochodnia")
            {
                Console.WriteLine("Użyto pochodni");
                historia.Add("Użyto pochodni");
                plecak.RemoveAt(wybor3 - 1);
            }

            if (wybranyPrzedmiot == "Zwój")
            {
                zloto += 15;
                plecak.RemoveAt(wybor3 - 1);
                historia.Add("Użyto zwoju");
            }
            if (wybranyPrzedmiot=="Miecz" || wybranyPrzedmiot=="Klucz")
            {
                Console.WriteLine($"Użyto {wybranyPrzedmiot}");
            }

            zuzytoTure = true;
            
            break;
        case 4:
            Console.WriteLine("Dodawanie znaleziska...");
            Console.WriteLine("Dostępne znaleziska wybierz nr który chcesz dodać: ");
            for (int i=0; i<znaleziska.Length; i++)
            {
                Console.WriteLine($"{i+1}- {znaleziska[i]}");
            }
            int wybor4;
            while(!int.TryParse(Console.ReadLine(), out wybor4) || wybor4<1 || wybor4>znaleziska.Length)
            {
                Console.WriteLine("Podaj poprawną liczbę!");
            }

            if (plecak.Count >= 6)
            {
                Console.WriteLine("Plecak jest pełny!");
                break;
            }
            else
            {
                Console.WriteLine("Dodano znalezisko");
                plecak.Add(znaleziska[wybor4 - 1]);
                historia.Add($"Dodano {znaleziska[wybor4 - 1]}");
            }

            zuzytoTure = true;
            break;
        
        case 5:
            Console.WriteLine("Wyrzucanie przedmiotu...");
            if (plecak.Count == 0)
            {
                Console.WriteLine("Plecak jest pusty");
            }
            else
            {
                for (int i=0; i<plecak.Count; i++)
                {
                    Console.WriteLine($"{i+1}- {plecak[i]}");
                }

                int wybor5;
                while (!int.TryParse(Console.ReadLine(), out wybor5) || wybor5 < 1 || wybor5 > plecak.Count)
                {
                    Console.WriteLine("Podaj poprawną liczbę!");
                }

                string usuwanyPrzedmiot = plecak[wybor5 - 1];
                plecak.RemoveAt(wybor5 - 1);
                historia.Add($"Wyrzucono {usuwanyPrzedmiot}");
                zuzytoTure = true;
            }
            break;
        case 6:
            Console.WriteLine("Historia");
            if (historia.Count == 0)
            {
                Console.WriteLine("Brak historii");
            }
            else
            {
                Console.WriteLine("Historia:");
                for (int i=0;i<historia.Count;i++)
                {
                    Console.WriteLine($"{i+1}- {historia[i]}");
                }
                Console.WriteLine();
            }
            break;
        case 7:
            Console.ResetColor();
            int sumaZlota = 0;
            int maxZdobyteZloto = 0;
            int turyBezZlota = 0;

            for (int i = 0; i < tura - 1 && i < zlotoZdobyteWTurach.Length; i++)
            {
                sumaZlota += zlotoZdobyteWTurach[i];

                if (zlotoZdobyteWTurach[i] > maxZdobyteZloto)
                {
                    maxZdobyteZloto = zlotoZdobyteWTurach[i];
                }

                if (zlotoZdobyteWTurach[i] == 0)
                {
                    turyBezZlota++;
                }
            }

            Console.WriteLine("=== STATYSTYKI ===");
            Console.WriteLine($"Eksploracje: {ekslopracje}");
            Console.WriteLine($"Zdobyte złoto z eksploracji: {sumaZlota}");
            Console.WriteLine($"Największe zdobyte złoto w turze: {maxZdobyteZloto}");
            Console.WriteLine($"Tury bez zdobytego złota: {turyBezZlota}");
            Console.WriteLine($"Przedmioty w plecaku: {plecak.Count}");
            Console.WriteLine($"Wpisy w historii: {historia.Count}");
            continue;
        case 8:
            graDziala = false;
            powodZakonczenia = "Zakończone przez gracza";
            Console.WriteLine("Zakończyłeś grę");
            break;
        default:
            Console.WriteLine("Nieznana akcja");
            break;
    }
    if (graDziala && zuzytoTure)
    {
        tura++;
        if (tura > 20)
        {
            powodZakonczenia = "Osiągnięto limit 20 tur";
            graDziala = false;
        }
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
Console.WriteLine($"Rozegrane tury: {tura-1}");
Console.WriteLine($"Eksploracje: {ekslopracje}");
Console.WriteLine($"Zdrowie: {hp}/{maxHp}");
Console.WriteLine($"Złoto: {zloto}");
Console.WriteLine($"Przedmioty w plecaku: {plecak.Count}");
Console.WriteLine($"Wpisy w historii: {historia.Count}");
Console.WriteLine($"Powód zakończenia: {powodZakonczenia}");
Console.WriteLine("\nOstatnie wpisy historii:");

if (historia.Count == 0)
{
    Console.WriteLine("Brak historii.");
}
else
{
    for (int i = Math.Max(0, historia.Count - 3); i < historia.Count; i++)
    {
        Console.WriteLine(historia[i]);
    }
}