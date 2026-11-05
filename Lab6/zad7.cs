int Heal(int health, int amount) => health + amount;

Heal(health, 10);

int noweZDrowie = Heal(30, 10);


if (health < 20)
{
    string warning = "Mało zdrowia!";
}

Console.WriteLine(warning);


string warning = "";

if (health < 20)
{
    warning = "Mało zdrowia!";
}

Console.WriteLine(warning);



if (health < 20)
{
    string warning = "Mało zdrowia!";
    Console.WriteLine(warning);
}

int CalculateDamage(int strength, int weaponDamage)
{
    Console.Write("Czy chcesz zaatakować? ");
    string? answer = Console.ReadLine();
    Console.WriteLine("Rozpoczynam animację ataku...");
    return strength + weaponDamage;
}


int CalculateDamage(int strength, int weaponDamage)
{

    return strength + weaponDamage;
}

bool CanHeal(int health, int maxHealth, int potions) =>
    health < maxHealth && potions > 0 && health > 0;

bool CanHeal(int health, int maxHealth, int potions)
{
    return health < maxHealth && potions > 0 && health > 0;
}