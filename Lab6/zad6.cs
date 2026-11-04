string heroName = "Koziołek matołek";
int health = 56;
int maxHealth=100;
int gold =15;
int strength=12;
int weaponDamage=10;
bool isRunning=true;

while (isRunning)
{
    ShowStatus(heroName, health, maxHealth, gold);
    ShowMenu();
    string command = ReadCommand();

    if (command == "1")
    {
        int damage = CalculateDamage(strength, weaponDamage);
        Console.WriteLine($"Zadajesz {damage} obrażeń manekinowi.");
    }
    else if (command == "2")
    {
        health = Heal(health, 10, maxHealth);
        Console.WriteLine($"Odpoczywasz. Masz teraz {health} HP.");
    }
    else
    {
        isRunning = false;
    }
}

//metody

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
    Console.WriteLine("\n1. Walka\n2.Odpoczynek\n3.Koniec gry");
}

int CalculateDamage(int strength,int weaponDamage)
{
    return (int)(0.5 *strength +weaponDamage);
}

int Heal(int health, int addedHP, int maxHealth)
{
    if (health+addedHP>maxHealth)
    {
        return maxHealth;
    }
    else
    {
        return health+addedHP;
    }
}
string ReadCommand()
{
    while (true)
    {
        string? command = Console.ReadLine();
        if (command is "1" or "2")
        {
            return command;
        }
        else
        {
            return "3";
        }
    }
}