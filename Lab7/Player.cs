public class Player
{
    public string Name { get; }
    public int Health { get; set; }
    public int MaxHealth { get; set; }
    public int Gold { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }
    public List<Item> Inventory {get; set; }


    public Player(string name, int maxHealth, int gold)
    {
        Name = name;
        MaxHealth = maxHealth;
        Health = maxHealth;
        Gold = gold;
        Level=1;
        Experience=0;
        Inventory = new List<Item>();
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
        Health = Math.Max(0, Health - damage);

        if (Health == 0)
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

    public void AddItem(Item item)
    {
        Inventory.Add(item);
    }

    public void ShowInventory()
    {
        for (int i=0; i<Inventory.Count; i++)
        {
            Console.WriteLine($"{i+1}. {Inventory[i].Name} x{Inventory[i].Quantity}");
        }
    }

    public void UseItem(int index)
    {
        if (index<0 || index>=Inventory.Count)
        {
            Console.WriteLine("Nie ma  takiego przedmiotu");
            return;
        }

        Inventory[index].UseOne(this);
    }

}
