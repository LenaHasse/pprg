namespace RogueSemester.Core.Items;

public class Inventory
{
    public List<Item> Items { get; } = new List<Item>();
    public List<Weapon> Weapons { get;} = new();

    public void Add(Item item) => Items.Add(item);

    public void Add(Weapon weapon) => Weapons.Add(weapon);

    public int CalculateValue()
    {
        int total = 0;

        foreach (Item item in Items)
        {
            total += item.Price;
        }
        foreach (Weapon weapon in Weapons)
        {
            total += weapon.Price;
        }

        return total;
    }
}
