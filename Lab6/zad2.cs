bool isRunning=true;
string heroName="Koziolek matolek";
int health=45;
int maxHealth=100;
int gold=23;
while (isRunning)
{
    ShowStatus(heroName,health,maxHealth,gold);
    ShowMenu();
    break;
}

void ShowPanelTitle(string title, ConsoleColor backgroundColor)
{
    Console.BackgroundColor=backgroundColor;
    Console.ForegroundColor=ConsoleColor.White;
    Console.Write($"    {title.ToUpper()}   ");
    Console.BackgroundColor = ConsoleColor.Black; 
    Console.ResetColor();
    Console.WriteLine();
}


void ShowStatus(string name, int health, int maxHealth, int gold)
{
    ShowPanelTitle("Status bohatera",ConsoleColor.DarkBlue);
    Console.ForegroundColor=ConsoleColor.Cyan;
    Console.Write("Bohater: ");
    Console.ResetColor();
    Console.WriteLine(name);

    Console.ForegroundColor=ConsoleColor.Green;
    Console.Write("Zdrowie: ");
    Console.ResetColor();
    Console.WriteLine($"{health}/{maxHealth}");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Złoto: ");
    Console.ResetColor();
    Console.WriteLine(gold);

}

void ShowMenu()
{
    ShowPanelTitle("Menu", ConsoleColor.DarkCyan);
    Console.WriteLine("\n1. Eksploracja\n2.Odpoczynek\n3.Walka");
}
