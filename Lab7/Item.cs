public class Item
{
    public string Name { get; }
    public int HealAmount { get; set; }
    public int Quantity { get; set; }


    public Item(string name, int healAmount, int quantity)
    {
        Name=name;
        HealAmount=healAmount;
        Quantity=quantity;
    }

    public void UseOne(Player player)
    {
        if (Quantity<=0)
        {
            Console.WriteLine("Brak przedmiotów");
            return;
        }
        player.Heal(HealAmount);
        Quantity--;
    }


}

