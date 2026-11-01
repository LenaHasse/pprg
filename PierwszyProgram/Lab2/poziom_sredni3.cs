Console.Write("Podaj liczbę racji żywnościowych: ");
int racje_zyw=int.Parse(Console.ReadLine()!);

Console.Write("Podaj liczbę członków drużyny: ");
int liczba_druzyna=int.Parse(Console.ReadLine()!);

Console.Write("Podaj liczbę dni wyprawy: ");
int dni_wyprawy=int.Parse(Console.ReadLine()!);

Console.WriteLine($"Każda osoba otrzyma {racje_zyw/liczba_druzyna} racji żywnościowych");
Console.WriteLine($"Zostanie {racje_zyw%liczba_druzyna} racji bez przydziału");
Console.WriteLine($"Dziennie na drużynę przypada {Math.Round(1.0 * racje_zyw / dni_wyprawy,2)} racji żywnościowych");
Console.WriteLine($"A dziennie na osobę przypada {Math.Round(1.0*racje_zyw/liczba_druzyna/dni_wyprawy,2)} racji");