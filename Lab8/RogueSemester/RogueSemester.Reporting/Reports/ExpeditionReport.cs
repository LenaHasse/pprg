namespace RogueSemester.Reporting.Reports;

public static class ExpeditionReport
{
    public static string Create(Player player, int defeatedCount, string endReason)
    {
        string report =
            "=== RAPORT KOŃCOWY ===\n"+
            $"Bohater: {player.Name}\n"+
            $"Zdrowie: {player.Health}/{player.MaxHealth}\n"+
            $"Pokonani przeciwnicy: {defeatedCount}\n"+
            $"Zdobyte złoto: {player.Gold}\n"+
            $"Przedmioty:\n";
            
        if (player.Inventory.Items.Count == 0 &&
            player.Inventory.Weapons.Count == 0)
        {
            report += "- brak\n";
        }

        foreach (var weapon in player.Inventory.Weapons)
        {
            report += $"- {weapon.Name}\n";
        }

        foreach (var item in player.Inventory.Items)
        {
            report += $"- {item.Name}\n";
        }

        report += $"Powód zakończenia: {endReason}\n";
        return report;
    }

}