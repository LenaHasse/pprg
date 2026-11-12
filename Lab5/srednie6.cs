Dictionary<string, int> stanyMagazynowe = new Dictionary<string, int>
{
    { "Mikstura", 3 },
    { "Pochodnia", 2 },
    { "Klucz", 1 }
};

bool programDziala = true;

while (programDziala)
{
    Console.WriteLine();
    Console.WriteLine("=== MENU ===");
    Console.WriteLine("1 - Pokaż magazyn");
    Console.WriteLine("2 - Przyjmij dostawę");
    Console.WriteLine("3 - Wydaj przedmiot");
    Console.WriteLine("4 - Usuń pustą pozycję");
    Console.WriteLine("5 - Zakończ");
    Console.Write("Wybierz opcję: ");

    string opcja = Console.ReadLine()!;

    switch (opcja)
    {
        case "1":

            Console.WriteLine("Aktualny stan magazynu:");

            if (stanyMagazynowe.Count == 0)
            {
                Console.WriteLine("Magazyn jest pusty.");
            }
            else
            {
                foreach (var element in stanyMagazynowe)
                {
                    Console.WriteLine($"{element.Key}: {element.Value} sztuk");
                }
            }

            break;

        case "2":

            Console.WriteLine("Przyjęcie dostawy");

            Console.Write("Nazwa przedmiotu: ");
            string nazwaPrzedmiotu = Console.ReadLine()!;

            Console.Write("Ilość: ");
            int liczbaSztuk = int.Parse(Console.ReadLine()!);

            if (liczbaSztuk <= 0)
            {
                Console.WriteLine("Ilość musi być dodatnia.");
            }
            else if (stanyMagazynowe.ContainsKey(nazwaPrzedmiotu))
            {
                stanyMagazynowe[nazwaPrzedmiotu] += liczbaSztuk;
                Console.WriteLine("Zaktualizowano stan przedmiotu.");
            }
            else
            {
                stanyMagazynowe.Add(nazwaPrzedmiotu, liczbaSztuk);
                Console.WriteLine("Dodano nowy przedmiot.");
            }

            break;

        case "3":

            Console.WriteLine("Wydawanie przedmiotu");

            Console.Write("Podaj nazwę: ");
            string nazwaDoWydania = Console.ReadLine()!;

            Console.Write("Podaj ilość: ");
            int liczbaDoWydania = int.Parse(Console.ReadLine()!);

            if (liczbaDoWydania <= 0)
            {
                Console.WriteLine("Ilość musi być dodatnia.");
            }
            else if (!stanyMagazynowe.ContainsKey(nazwaDoWydania))
            {
                Console.WriteLine("Taki przedmiot nie istnieje.");
            }
            else if (stanyMagazynowe[nazwaDoWydania] < liczbaDoWydania)
            {
                Console.WriteLine($"Za mało sztuk przedmiotu {nazwaDoWydania}.");
            }
            else
            {
                stanyMagazynowe[nazwaDoWydania] -= liczbaDoWydania;
                Console.WriteLine("Przedmiot został wydany.");
            }

            break;

        case "4":

            Console.WriteLine("Usuwanie pustej pozycji");

            Console.Write("Nazwa przedmiotu: ");
            string nazwaDoUsuniecia = Console.ReadLine()!;

            if (!stanyMagazynowe.ContainsKey(nazwaDoUsuniecia))
            {
                Console.WriteLine("Brak takiego przedmiotu.");
            }
            else if (stanyMagazynowe[nazwaDoUsuniecia] != 0)
            {
                Console.WriteLine("Nie można usunąć pozycji o stanie większym od 0.");
            }
            else
            {
                stanyMagazynowe.Remove(nazwaDoUsuniecia);
                Console.WriteLine("Pozycja została usunięta.");
            }

            break;

        case "5":

            Console.WriteLine("Zamykanie programu...");
            programDziala = false;

            break;

        default:

            Console.WriteLine("Nieprawidłowa opcja.");

            break;
    }
}