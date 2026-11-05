int CalculateDamage(int strength, int weaponDamage) => strength + weaponDamage;


int Heal(int health, int amount, int maxHealth)
{
    health += amount;
    if (health > maxHealth)
    {
        health = maxHealth;
    }

    return health;
}

bool IsGameOver(int health) => health <= 0;

string ReadCommand()
{
    while (true)
    {
        Console.WriteLine("1. Opcja pierwsza\n2.Opcja druga\n3.Opcja trzecia");
        Console.Write("Wybór: ");
        string? command = Console.ReadLine();
        if (command is "1" or "2" or "3")
        {
            return command;
        }
        else
        {
            Console.WriteLine("Podałeś złą liczbę");
            continue;
        }
    }
}
ReadCommand();
//Niezmieniam za dużo


void ShowMenu()
{
    ShowPanelTitle("Menu", ConsoleColor.DarkCyan);
    Console.WriteLine("\n1. Eksploracja\n2.Odpoczynek\n3.Walka");
}


List<string> inventory = new List<string> { "miecz", "mikstura", "łuk" };

List<string> longNames = inventory.FindAll(item => item.Length >= 5);
bool hasSword = inventory.Exists(item => item == "miecz");

foreach (string item in longNames)
{
    Console.WriteLine(item);
}

Console.WriteLine(hasSword);