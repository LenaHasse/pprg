Console.Write("Imię bohatera: ");
string imie = Console.ReadLine()!;

Console.Write("Symbol bohatera: ");
char symbol = Console.ReadKey().KeyChar;
Console.WriteLine();

Console.Write("Maksymalne zdrowie: ");
int maxHp = int.Parse(Console.ReadLine()!);

Console.Write("Aktualne zdrowie: ");
int hp = int.Parse(Console.ReadLine()!);

Console.Write("Siła: ");
int sila = int.Parse(Console.ReadLine()!);

Console.Write("Premia broni: ");
int premiaBroni = int.Parse(Console.ReadLine()!);

Console.Write("Mnożnik ataku specjalnego: ");
double mnoznik = double.Parse(Console.ReadLine()!);

Console.Write("Liczba przedmiotów w plecaku: ");
int zajeteMiejsca = int.Parse(Console.ReadLine()!);

Console.Write("Maksymalna liczba miejsc w plecaku: ");
int maksMiejsca = int.Parse(Console.ReadLine()!);

const int maxZlotoNa_start = 50;

Console.Write("Ilość złota: ");
int zloto = int.Parse(Console.ReadLine()!);
zloto += maxZlotoNa_start;

Console.Write("Liczba członków drużyny: ");
int liczbaCzlonkow = int.Parse(Console.ReadLine()!);

Console.Write("Czy bohater ma mapę? (true/false): ");
bool maMape = bool.Parse(Console.ReadLine()!);

Console.Write("Podaj liczbę misktur: ");
int mikstury = int.Parse(Console.ReadLine()!);


int zwykleObrazenia = sila + premiaBroni;
int obrazeniaAtakuSpecjalnego = (int)(zwykleObrazenia * mnoznik);

double procentHp = (double)hp / maxHp * 100;

int wolneMiejsca = maksMiejsca - zajeteMiejsca;
int zlotoDlaJednejOsoby = zloto / liczbaCzlonkow;
int zlotoWSkarbcu = zloto % liczbaCzlonkow;

bool zyje = hp > 0;
bool NiskiPoziomZdrowia = zyje && hp < 25;
bool mozeRuszac = zyje && maMape;
bool maPelneZdrowie = hp == maxHp;
bool wymagaLeczenia = hp < maxHp;
bool maMiejsceWPlecaku = wolneMiejsca > 0;
bool jestBogaty = zloto >= 100;
bool gotowyDoWalki = zyje && mikstury > 0;
bool gotowaDoWyprawy = zyje && maMape && maMiejsceWPlecaku;

if (!zyje)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Bohater nie zyje");
}
else if (NiskiPoziomZdrowia)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Bohater jest ranny");
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Bohater jest w dobrej formie");
}
string statusBogactwa=jestBogaty ? "bogaty" : "przecietny podroznik";
Console.WriteLine(statusBogactwa);
Console.WriteLine("\n Wybierz akcję: \n 1 - rozpocznij wyprawe \n 2 - Przygotuj miskture \n 3 - odpocznij");
Console.Write("Wybierz liczbę: ");
int akcja= int.Parse(Console.ReadLine()!);

switch (akcja)
{
    case 1:
        Console.WriteLine(mozeRuszac ? "Bohater wyrusza w drogę!" : "BOhater nie może wyruszyć");
        break;
    case 2:
        Console.WriteLine("Przygotowuje miskture...");
        mikstury += 1;
        break;
    case 3:
        Console.WriteLine("Odpoczywa...");
        break;
    default:
        Console.WriteLine("Nieznana akcja");
        break;
}

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
Console.ResetColor();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("+=======================================+");
Console.WriteLine("|             KARTA BOHATERA            |");
Console.WriteLine("+=======================================+");
Console.ResetColor();

Console.WriteLine($"| Bohater: {imie}\t{symbol}\t\t\t|");
Console.WriteLine("+---------------------------------------+");
Console.ForegroundColor = kolorZdrowia;
Console.WriteLine($"| Zdrowie: {hp}/{maxHp} ({Math.Round(procentHp,2)}%)\t\t|");
Console.ResetColor();
Console.WriteLine($"| Siła: {sila}\t\t\t\t|");
Console.WriteLine($"| Premia broni: {premiaBroni}\t\t\t|");
Console.WriteLine($"| Zwykłe obrażenia: {zwykleObrazenia}\t\t\t|");
Console.WriteLine($"| Mnożnik ataku specjalnego: {mnoznik}\t|");
Console.WriteLine($"| Obrażenia ataku specjalnego: {obrazeniaAtakuSpecjalnego}\t|");
Console.WriteLine("+---------------------------------------+");

Console.WriteLine($"| Plecak: {zajeteMiejsca}/{maksMiejsca}\t\t\t\t|");
Console.WriteLine($"| Misktury: {mikstury}\t\t\t\t|");
Console.WriteLine($"| Wolne miejsca: {wolneMiejsca}\t\t\t|");
Console.WriteLine($"| Złoto: {zloto}\t\t\t\t|");
Console.WriteLine($"| Liczba członków drużyny: {liczbaCzlonkow}\t\t|");
Console.WriteLine($"| Złoto dla jednej osoby: {zlotoDlaJednejOsoby}\t\t|");
Console.WriteLine($"| Złoto pozostające w skarbcu: {zlotoWSkarbcu}\t|");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("+---------------------------------------+");
Console.WriteLine($"| Ma mapę: {maMape}\t\t\t\t|");
Console.WriteLine($"| Żyje: {zyje}\t\t\t\t|");
Console.WriteLine($"| Ma pełne zdrowie: {maPelneZdrowie}\t\t|");
Console.WriteLine($"| Wymaga leczenia: {wymagaLeczenia}\t\t\t|");
Console.WriteLine($"| Gotowy do walki {gotowyDoWalki}\t\t\t|");
Console.WriteLine($"| Ma miejsce w plecaku: {maMiejsceWPlecaku}\t\t|");
Console.WriteLine($"| Gotowa do wyprawy: {gotowaDoWyprawy}\t\t|");
Console.WriteLine("+=======================================+");