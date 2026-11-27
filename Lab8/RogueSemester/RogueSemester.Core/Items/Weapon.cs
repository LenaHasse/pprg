namespace RogueSemester.Core.Items;

public class Weapon
{
    public string Name { get; }
    public int Price { get; }
    public int Damage { get; }

    public Weapon(string name, int price, int damage)
    {
        Name = name;
        Price = price;
        Damage = damage;
    }
}