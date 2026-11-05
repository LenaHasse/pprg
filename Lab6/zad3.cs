int strength = 6;
int weaponDamage = 3;
int health = 0;
int maxHealth = 100;


int CalculateDamage(int strength, int weaponDamage)
{
    return strength + weaponDamage;
}

int Heal(int health, int amount, int maxHealth)
{
    health += amount;
    if (health > maxHealth)
    {
        health = maxHealth;
    }

    return health;
}

bool IsGameOver(int health)
{
    return health <= 0;
}


int damage = CalculateDamage(strength, weaponDamage);
health = Heal(health, 10, maxHealth);


if (IsGameOver(health))
{
    Console.WriteLine("Koniec.");
}

Console.WriteLine(damage);
Console.WriteLine(health);