Console.Write("Podaj imię ");
string imie=Console.ReadLine()!;
char symbol = '&';
int poziom = 10;
int zloto = 65;
double waga = 7.5;
bool mapa = false;
int exp = 10;
int trening = 1;


Console.WriteLine("+========EKWIPUNEK======+");
Console.WriteLine("+-----------------------+");
Console.WriteLine($"| Bohater: {imie}\t|");
Console.WriteLine($"| Symbol: {symbol}\t\t|");
Console.WriteLine($"| Poziom: {poziom}\t\t|");
Console.WriteLine($"| Doświadczenie: {exp}\t|");
Console.WriteLine($"| Złoto: {zloto}\t\t|");
Console.WriteLine($"| Nr treningu: {trening}\t|");
Console.WriteLine($"| Waga: {waga} kg\t\t|");
Console.WriteLine($"| Mapa: {mapa}\t\t|");
Console.WriteLine("+=======================+");

Console.WriteLine();
symbol='%';
mapa=true;
exp += 25;
exp *= 2;
zloto -= 8;
zloto += 15;
trening++;



Console.WriteLine("+========EKWIPUNEK======+");
Console.WriteLine("+-----------------------+");
Console.WriteLine($"| Bohater: {imie}\t|");
Console.WriteLine($"| Symbol: {symbol}\t\t|");
Console.WriteLine($"| Poziom: {poziom}\t\t|");
Console.WriteLine($"| Doświadczenie: {exp}\t|");
Console.WriteLine($"| Złoto: {zloto}\t\t|");
Console.WriteLine($"| Nr treningu: {trening}\t|");
Console.WriteLine($"| Waga: {waga} kg\t\t|");
Console.WriteLine($"| Mapa: {mapa}\t\t|");
Console.WriteLine("+=======================+");