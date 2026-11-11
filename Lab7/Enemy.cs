public class Enemy
{
    public string Name { get; }
    public int Health { get; set; }

    public int MaxHealth {get; }
    public int Damage { get; }

    public Enemy(string name, int health, int damage)
    {
        MaxHealth=health;
        Name = name;
        Health = health;
        Damage = damage;
    }


    public void TakeDamage(int damage)
    {
        if (!IsAlive())
        {
            Console.WriteLine("Pokonany");
            return;
        }
        if (damage <=0)
        {
            Console.WriteLine("error nieprawidłowa wartość obrażeń");
            return;
        }
        Health -= damage;

        if (Health==0)
        {
            Console.WriteLine("Pokonany");
        }
    }

        public void Heal(int amount)
    {   
        if (amount>0)
        {
            Health += amount;

            if (Health > MaxHealth)
            {
                Health = MaxHealth;
            }
        }
        else if (amount<=0)
        {
            Console.WriteLine("Heal error");
        }
    }

    public bool IsAlive()
    {
        return Health > 0;
    }
}
