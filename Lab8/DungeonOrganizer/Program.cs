using DungeonOrganizer.Characters;
using InventoryItem=DungeonOrganizer.Items.Item;
using MapItem=DungeonOrganizer.World.Item;
using DungeonOrganizer.UI;

Player player = new Player("Ada", 100);
Enemy enemy = new Enemy("Goblin", 30);
InventoryItem item = new InventoryItem("Mikstura", 15);
MapItem mapSymbol = new MapItem("!");

GamePrinter.ShowHeader("Dungeon Organizer");
GamePrinter.ShowCharacter(player.Name, player.Health);
GamePrinter.ShowCharacter(enemy.Name, enemy.Health);
GamePrinter.ShowItem(item.Name, item.Price);

Console.WriteLine($"Przedmiot: {item.Name}, cena: {item.Price}");
Console.WriteLine($"Symbol na mapie {mapSymbol.Symbol}");

