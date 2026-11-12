bool graDziala = true;
List<string> historia = new List<string>(); //Eksploracja, Odpoczynek, Znaleziono przedmiot
Dictionary<string,int> wystapienia= new Dictionary<string, int>
{
    {"Eksploracja", 0},
    {"Odpoczynek", 0},
    {"Znaleziono przedmiot", 0},
    {"Pokaż całą historię",0},
    {"Pokaż ostatnie trzy wpisy",0},
    {"Policz wybraną akcję",0},
    {"Wyczyść historię",0},
    
};

do
{
    Console.WriteLine("1 - Eksploruj\n2 - Odpocznij\n3 - Znajdź przedmiot\n4 - Pokaż całą historię\n5 - Pokaż ostatnie trzy wpisy\n6 - Policz wybraną akcję\n7 - Wyczyść historię\n8 - Zakończ\n");
    int wybor;
    if (!int.TryParse(Console.ReadLine(), out wybor))
    {
        Console.WriteLine("To musi być liczba całkowita");
        continue;
    }

    switch (wybor)
    {
        case 1:
            historia.Add("Eksploracja");
            wystapienia["Eksploracja"]++;
            //eksploracja
            break;
        case 2:
            historia.Add("Odpoczynek");
            wystapienia["Odpoczynek"]++;
            //odpoczynek
            break;
        case 3:
            historia.Add("Znaleziono przedmiot");
            wystapienia["Znaleziono przedmiot"]++;
            //znalezienie przedmiotu
            break;
        case 4:
            //pokazanie całej historii
            wystapienia["Pokaż całą historię"]++;
            if (historia.Count == 0)
            {
                Console.WriteLine("Nie ma żadnego zapisu w historii");
            }
            else
            {
                foreach (string wpis in historia)
                {
                    Console.Write(wpis+"\t");
                }
                Console.WriteLine();
            }
            break;
        case 5:
            //pokazanie ostatnich trzech wpisów
            wystapienia["Pokaż ostatnie trzy wpisy"]++;
            if (historia.Count == 0)
            {
                Console.WriteLine("Nie ma żadnego zapisu w historii");
            }
            else
            {
                for (int i = Math.Max(0, historia.Count - 3); i < historia.Count; i++)
                {
                    Console.Write(historia[i] + "\t");
                }
                Console.WriteLine();
            }
            break;
        case 6:
            //policzenie wybranej akcji
            wystapienia["Policz wybraną akcję"]++;
            int wyborWystapienia;
            bool koniecLiczenia = false;
            do
            {
                Console.WriteLine("1 - Eksploruj\n2 - Odpocznij\n3 - Znajdź przedmiot\n4 - Pokaż całą historię\n5 - Pokaż ostatnie trzy wpisy\n6 - Policz wybraną akcję\n7 - Wyczyść historię\n");
                if (!int.TryParse(Console.ReadLine(), out wyborWystapienia))
                {
                    Console.WriteLine("To musi być liczba całkowita");
                    continue;
                }
                else
                {
                    switch (wyborWystapienia)
                    {
                        case 1:
                            Console.WriteLine("Eksploruj: " + wystapienia["Eksploracja"]);
                            koniecLiczenia = true;
                            break;
                        case 2:
                            Console.WriteLine("Odpoczynek: " + wystapienia["Odpoczynek"]);
                            koniecLiczenia = true;
                            break;
                        case 3:
                            Console.WriteLine("Znaleziono przedmiot: " + wystapienia["Znaleziono przedmiot"]);
                            koniecLiczenia = true;
                            break;
                        case 4:
                            Console.WriteLine("Pokaż całą historię: " + wystapienia["Pokaż całą historię"]);
                            koniecLiczenia = true;
                            break;
                        case 5:
                            Console.WriteLine("Pokaż ostatnie trzy wpisy: " + wystapienia["Pokaż ostatnie trzy wpisy"]);
                            koniecLiczenia = true;
                            break;
                        case 6:
                            Console.WriteLine("Policz wybraną akcję: " + wystapienia["Policz wybraną akcję"]);
                            koniecLiczenia = true;
                            break;
                        case 7:
                            Console.WriteLine("Wyczyść historię: "+wystapienia["Wyczyść historię"]);
                            koniecLiczenia = true;
                            break;
                        default:
                            Console.WriteLine("Wybierz liczbę od 1 do 7");
                            continue;
                    }
                }
            } while (!koniecLiczenia);
            break;
        case 7:
            //wyczyszczenie historii
            do
            {
                Console.WriteLine("Czy na pewno chcesz wyczyścić historię? (t/n)");
                string odpowiedzWyczyszczenieHistorii = Console.ReadLine()!;
                if (odpowiedzWyczyszczenieHistorii == "t")
                {
                    wystapienia["Wyczyść historię"]++;
                    historia.Clear();
                    Console.WriteLine("Wyczyszczono historię");
                    break;
                }
                else if (odpowiedzWyczyszczenieHistorii == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wpisz 't' dla tak lub 'n' dla nie");
                    continue;
                }

            } while (true);
            break;
        case 8:
            //zakończenie gry
            graDziala = false;
            break;
    }
}
while (graDziala);