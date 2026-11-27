namespace RogueSemester.Core.Characters;

public class Enemy
{
    public string Name { get; }
    public int Health { get; private set; }
    public int MaxHealth { get; set;}
    public int Damage {get; set; }
    public int Reward {get; set;}

    public Enemy(string name, int health, int damage)
    {
        Name = name;
        MaxHealth=health;
        Health = health;
        Damage=damage;
        Reward=health*damage/10;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;

        if (Health < 0)
        {
            Health = 0;
        }
    }
}
