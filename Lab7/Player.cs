public class Player
{
    public string Name { get; }
    public int Health { get; set; }
    public int MaxHealth { get; set; }
    public int Gold { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }


    public Player(string name, int maxHealth, int gold)
    {
        Name = name;
        MaxHealth = maxHealth;
        Health = maxHealth;
        Gold = gold;
        Level=1;
        Experience=0;
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

    public void GainExperience(int gainedExp)
    {
        Experience+=gainedExp;
        if (Experience>= 10)
        {
            while (Experience >=10)
            {
                Experience-=10;
                Level++;
                MaxHealth+=50;
                Health=MaxHealth;
            }
        }
    }
}
