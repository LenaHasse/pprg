Console.Write("Imię: ");
string imie=Console.ReadLine()!;

Console.Write("Maksymalne punkty życia: ");
int max_hp=int.Parse(Console.ReadLine()!);

Console.Write("Aktualne punkty życia: ");
int hp=int.Parse(Console.ReadLine()!);

Console.Write("Podstawowe obrażenia broni: ");
int obrazenia_broni=int.Parse(Console.ReadLine()!);

Console.Write("Premia do siły: ");
int premia_sila=int.Parse(Console.ReadLine()!);

Console.Write("Mnożnik ataku specjalnego: ");
double mnoznik=double.Parse(Console.ReadLine()!);

Console.Write("Liczba wykonanych zwyklych atakow: ");
int liczba_atakow=int.Parse(Console.ReadLine()!);

int obrazenia_ataku=obrazenia_broni+premia_sila;
int ObrazeniaAtakuSpecjalnego=obrazenia_ataku*(int)mnoznik;
int laczne_obrazenia=liczba_atakow*obrazenia_ataku+ObrazeniaAtakuSpecjalnego;
double procent_hp=(double)hp/max_hp*100;
bool zyje=hp>0;
bool maPelneZdrowie=procent_hp==100;


Console.WriteLine("========== RAPORT Z WALKI ==========");
Console.WriteLine($"Bohater: {imie}");
Console.WriteLine($"Zdrowie: {hp}/{max_hp} ({procent_hp}%)");
Console.WriteLine($"Zwykły atak: {obrazenia_ataku}");
Console.WriteLine($"Atak specjalny: {ObrazeniaAtakuSpecjalnego}");
Console.WriteLine($"Łączne zadane obrażenia: {laczne_obrazenia}");
Console.WriteLine($"Żyje: {zyje}");
Console.WriteLine($"Ma pełne zdrowie: {maPelneZdrowie}");