

Console.Write("Podaj imię ");
string imie=Console.ReadLine()!;
int hp = 100;
int stregnth = 10;
int zloto = 70;
int exp=(hp+stregnth)%3+10;
int moc = hp + stregnth;

Console.WriteLine("+===============================+");
Console.WriteLine("|\tHELLO ADVENTUER\t\t|");
Console.WriteLine("+-------------------------------+");
Console.WriteLine($"| Bohater: {imie}\t\t|");
Console.WriteLine($"| HP: {hp}\t\t\t|");
Console.WriteLine($"| Siła: {stregnth}\t\t\t|");
Console.WriteLine($"| Złoto: {zloto}\t\t\t|");
Console.WriteLine($"| Doświadczenie: {exp}\t\t|");
Console.WriteLine("+-------------------------------+");
Console.WriteLine($"|Łączna moc: {moc}\t\t|");
Console.WriteLine("+===============================+");

Console.WriteLine("\n\n\n");

Console.Write("Podaj obrazenia ");
int pk_obrazenia = int.Parse(Console.ReadLine()!);
int IleZadano = pk_obrazenia - moc / 2;

hp -= IleZadano;
moc = (hp + stregnth)/2;

Console.WriteLine(" * * * * * * * UPDATE * * * * * * ");
Console.WriteLine("+===============================+");
Console.WriteLine("|\tKARTA POSTACI\t\t|");
Console.WriteLine("+-------------------------------+");
Console.WriteLine($"| Bohater: {imie}\t\t|");
Console.WriteLine($"| HP: {hp}\t\t\t|");
Console.WriteLine($"| Siła: {stregnth}\t\t\t|");
Console.WriteLine($"| Złoto: {zloto}\t\t\t|");
Console.WriteLine($"| Doświadczenie: {exp}\t\t|");
Console.WriteLine("+-------------------------------+");
Console.WriteLine($"|Łączna moc: {moc}\t\t\t|");
Console.WriteLine("+===============================+");