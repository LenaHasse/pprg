namespace RogueSemester.Reporting.Reports;

public static class PlayerReport
{
    public static string Create(Player player)
    {
        string report =
            "=== RAPORT BOHATERA ===\n" +
            $"Bohater: {player.Name}\n" +
            $"Zdrowie: {player.Health}/{player.MaxHealth}\n" +
            $"Złoto: {player.Gold}\n\n" +
            "Przedmioty:\n";
        
        if (player.Inventory.Items.Count == 0)
        {
            report += "- brak przedmiotów\n";
        }

        else
        {
            foreach (var item in player.Inventory.Items)
            {
                report+=$" - {item.Name}\n";
            }
        }

        if (player.Inventory.Weapons.Count==0)
        {
            report+=" - brak broni\n";
        }
        else
        {
            foreach (var weapon in player.Inventory.Weapons)
            {
                report+=$" - {weapon.Name}\n";
            }
        }
        return report;
    }
}
