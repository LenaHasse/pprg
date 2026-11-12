Console.Write("Podaj liczbę punktów życia: ");
int hp= int.Parse(Console.ReadLine()!);

Console.Write("Podaj liczbę mikstur: ");
int mikstury= int.Parse(Console.ReadLine()!);

Console.Write("Ma klucz? (true/false): ");
bool klucz= bool.Parse(Console.ReadLine()!);

Console.Write("Ma mapę? (true/false): ");
bool mapa= bool.Parse(Console.ReadLine()!);
Console.WriteLine();

Console.WriteLine($"Żyje: {hp>0}");
Console.WriteLine($"Ma pełne zdrowie: {hp==100}");
Console.WriteLine($"Ma zaopatrzenie {mikstury>=1}");
Console.WriteLine($"Ma przedmiot nawigacyjny {klucz||mapa}");
Console.WriteLine($"Gotowy do wyprawy {klucz||mapa&hp>0}");