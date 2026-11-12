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

Console.Write("Ilość złota: ");
int zloto = int.Parse(Console.ReadLine()!);

Console.Write("Liczba członków drużyny: ");
int liczbaCzlonkow = int.Parse(Console.ReadLine()!);

Console.Write("Czy bohater ma mapę? (true/false): ");
bool maMape = bool.Parse(Console.ReadLine()!);


int zwykleObrazenia = sila + premiaBroni;
int obrazeniaAtakuSpecjalnego = (int)(zwykleObrazenia * mnoznik);

double procentHp = (double)hp / maxHp * 100;

int wolneMiejsca = maksMiejsca - zajeteMiejsca;
int zlotoDlaJednejOsoby = zloto / liczbaCzlonkow;
int zlotoWSkarbcu = zloto % liczbaCzlonkow;

bool zyje = hp > 0;
bool maPelneZdrowie = hp == maxHp;
bool wymagaLeczenia = hp < maxHp;
bool maMiejsceWPlecaku = wolneMiejsca > 0;
bool gotowaDoWyprawy = zyje && maMape && maMiejsceWPlecaku;

Console.WriteLine();
Console.WriteLine("+=======================================+");
Console.WriteLine("|             KARTA BOHATERA            |");
Console.WriteLine("+=======================================+");
Console.WriteLine($"| Bohater: {imie}\t{symbol}\t\t\t|");
Console.WriteLine("+---------------------------------------+");
Console.WriteLine($"| Zdrowie: {hp}/{maxHp} ({Math.Round(procentHp,2)}%)\t\t|");
Console.WriteLine($"| Siła: {sila}\t\t\t\t|");
Console.WriteLine($"| Premia broni: {premiaBroni}\t\t\t|");
Console.WriteLine($"| Zwykłe obrażenia: {zwykleObrazenia}\t\t\t|");
Console.WriteLine($"| Mnożnik ataku specjalnego: {mnoznik}\t|");
Console.WriteLine($"| Obrażenia ataku specjalnego: {obrazeniaAtakuSpecjalnego}\t|");
Console.WriteLine("+---------------------------------------+");
Console.WriteLine($"| Plecak: {zajeteMiejsca}/{maksMiejsca}\t\t\t\t|");
Console.WriteLine($"| Wolne miejsca: {wolneMiejsca}\t\t\t|");
Console.WriteLine($"| Złoto: {zloto}\t\t\t\t|");
Console.WriteLine($"| Liczba członków drużyny: {liczbaCzlonkow}\t\t|");
Console.WriteLine($"| Złoto dla jednej osoby: {zlotoDlaJednejOsoby}\t\t|");
Console.WriteLine($"| Złoto pozostające w skarbcu: {zlotoWSkarbcu}\t|");
Console.WriteLine("+---------------------------------------+");
Console.WriteLine($"| Ma mapę: {maMape}\t\t\t\t|");
Console.WriteLine($"| Żyje: {zyje}\t\t\t\t|");
Console.WriteLine($"| Ma pełne zdrowie: {maPelneZdrowie}\t\t|");
Console.WriteLine($"| Wymaga leczenia: {wymagaLeczenia}\t\t\t|");
Console.WriteLine($"| Ma miejsce w plecaku: {maMiejsceWPlecaku}\t\t|");
Console.WriteLine($"| Gotowa do wyprawy: {gotowaDoWyprawy}\t\t|");
Console.WriteLine("+=======================================+");