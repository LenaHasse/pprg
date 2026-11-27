namespace RogueSemester.Core.Characters;
using RogueSemester.Core.Items;
public class Player
{
    public string Name { get; }
    public int Strength {get; set;}
    public int Health { get; private set; }
    public int MaxHealth {get; set;}
    public int Gold {get; set;}
    public Inventory Inventory {get; } = new();
    public Weapon? EquippedWeapon {get; private set;}
    public int DefeatedCount {get; set;}

    public Player(string name, int health)
    {
        Strength=2;
        Gold=20;
        Name = name;
        MaxHealth=health;
        Health = health;
        DefeatedCount=0;
    }

    public void TakeDamage(int damage)
    {
        
        if (damage >0)
        {
            Health -= damage;
        }

        if (Health < 0)
        {
            Health = 0;
        }
    }

    public void WonBattle(int gold)
    {
        Gold+=gold;
        DefeatedCount++;
    }

    public void EquipWeapon(Weapon weapon)
    {
        EquippedWeapon = weapon;
    }
}
