
//zad1
Console.Write("Podaj liczbę: ");
int liczba= int.Parse(Console.ReadLine()!);

if (liczba % 2 == 0)
{
    Console.ForegroundColor=ConsoleColor.Green;
    Console.WriteLine("Liczba jest parzysta");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Liczba jest nieparzysta");
}

//zad2

Console.ResetColor();

Console.Write("Podaj kierunek: ");
string kierunek=Console.ReadLine()!;

switch (kierunek)
{
    case "północ":
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Wyruszasz w stronę gór.");
        break;
    case "południe":
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Wyruszasz w stronę pustyni.");
        break;
    case "wschód":
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Wyruszasz w stronę lasu.");
        break;
    case "zachód":
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Wyruszasz w stronę morza.");
        break;
    default:
        Console.WriteLine("Nieznany kierunek.");
		break;
}