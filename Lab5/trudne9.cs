Dictionary<string, int> punktyZycia = new Dictionary<string, int>();
Dictionary<string, int> liczbaPokonanych = new Dictionary<string, int>();

bool programDziala = true;

while (programDziala)
{
    Console.WriteLine();
    Console.WriteLine("=== BESTIARIUSZ ===");
    Console.WriteLine("1 - Dodaj gatunek");
    Console.WriteLine("2 - Pokaż bestiariusz");
    Console.WriteLine("3 - Zarejestruj zwycięstwo");
    Console.WriteLine("4 - Zmień punkty życia");
    Console.WriteLine("5 - Usuń gatunek");
    Console.WriteLine("6 - Wyszukaj gatunek");
    Console.WriteLine("7 - Raport");
    Console.WriteLine("8 - Zakończ");

    int wybor;

    while (!int.TryParse(Console.ReadLine(), out wybor) || wybor < 1 || wybor > 8)
    {
        Console.WriteLine("Podaj liczbę od 1 do 8.");
    }

    switch (wybor)
    {
        case 1:
            Console.Write("Podaj nazwę gatunku: ");
            string nowyGatunek = Console.ReadLine()!;

            if (punktyZycia.ContainsKey(nowyGatunek))
            {
                Console.WriteLine("Taki gatunek już istnieje.");
                break;
            }

            Console.Write("Podaj punkty życia: ");
            int hp;

            while (!int.TryParse(Console.ReadLine(), out hp) || hp <= 0)
            {
                Console.WriteLine("Podaj poprawną liczbę.");
            }

            punktyZycia.Add(nowyGatunek, hp);
            liczbaPokonanych.Add(nowyGatunek, 0);

            Console.WriteLine("Dodano gatunek.");
            break;

        case 2:

            if (punktyZycia.Count == 0)
            {
                Console.WriteLine("Bestiariusz jest pusty.");
            }
            else
            {
                foreach (var gatunek in punktyZycia)
                {
                    Console.WriteLine(
                        $"{gatunek.Key} | HP: {gatunek.Value} | Pokonano: {liczbaPokonanych[gatunek.Key]}"
                    );
                }
            }

            break;

        case 3:

            Console.Write("Podaj nazwę gatunku: ");
            string pokonany = Console.ReadLine()!;

            if (liczbaPokonanych.ContainsKey(pokonany))
            {
                liczbaPokonanych[pokonany]++;
                Console.WriteLine("Zarejestrowano zwycięstwo.");
            }
            else
            {
                Console.WriteLine("Nie znaleziono gatunku.");
            }

            break;

        case 4:

            Console.Write("Podaj nazwę gatunku: ");
            string doZmiany = Console.ReadLine()!;

            if (punktyZycia.ContainsKey(doZmiany))
            {
                Console.Write("Nowe punkty życia: ");

                int noweHp;

                while (!int.TryParse(Console.ReadLine(), out noweHp) || noweHp <= 0)
                {
                    Console.WriteLine("Podaj poprawną liczbę.");
                }

                punktyZycia[doZmiany] = noweHp;

                Console.WriteLine("Zmieniono punkty życia.");
            }
            else
            {
                Console.WriteLine("Nie znaleziono gatunku.");
            }

            break;

        case 5:

            Console.Write("Podaj nazwę gatunku: ");
            string doUsuniecia = Console.ReadLine()!;

            if (punktyZycia.ContainsKey(doUsuniecia))
            {
                punktyZycia.Remove(doUsuniecia);
                liczbaPokonanych.Remove(doUsuniecia);

                Console.WriteLine("Usunięto gatunek.");
            }
            else
            {
                Console.WriteLine("Nie znaleziono gatunku.");
            }

            break;

        case 6:

            Console.Write("Podaj nazwę gatunku: ");
            string szukany = Console.ReadLine()!;

            if (punktyZycia.ContainsKey(szukany))
            {
                Console.WriteLine($"Gatunek: {szukany}");
                Console.WriteLine($"HP: {punktyZycia[szukany]}");
                Console.WriteLine($"Pokonano: {liczbaPokonanych[szukany]}");
            }
            else
            {
                Console.WriteLine("Nie znaleziono gatunku.");
            }

            break;

        case 7:

            int sumaPokonanych = 0;
            string najczesciejPokonywany = "";
            int maxPokonan = -1;

            int sumaHp = 0;

            foreach (var gatunek in liczbaPokonanych)
            {
                sumaPokonanych += gatunek.Value;

                if (gatunek.Value > maxPokonan)
                {
                    maxPokonan = gatunek.Value;
                    najczesciejPokonywany = gatunek.Key;
                }
            }

            foreach (var gatunek in punktyZycia)
            {
                sumaHp += gatunek.Value;
            }

            double srednieHp = 0;

            if (punktyZycia.Count > 0)
            {
                srednieHp = (double)sumaHp / punktyZycia.Count;
            }

            Console.WriteLine("=== RAPORT ===");
            Console.WriteLine($"Liczba gatunków: {punktyZycia.Count}");
            Console.WriteLine($"Łącznie pokonano: {sumaPokonanych}");

            if (punktyZycia.Count > 0)
            {
                Console.WriteLine($"Najczęściej pokonywany: {najczesciejPokonywany} ({maxPokonan})");
            }

            Console.WriteLine($"Średnie HP: {srednieHp:F2}");

            Console.WriteLine("Niepokonane gatunki:");

            bool znaleziono = false;

            foreach (var gatunek in liczbaPokonanych)
            {
                if (gatunek.Value == 0)
                {
                    Console.WriteLine(gatunek.Key);
                    znaleziono = true;
                }
            }

            if (!znaleziono)
            {
                Console.WriteLine("Brak.");
            }

            break;

        case 8:

            programDziala = false;
            Console.WriteLine("Koniec programu.");

            break;
    }
}