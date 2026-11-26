using DungeonOrganizer.Characters;

using DungeonOrganizer.UI;

Player player = new Player("Ada", 100);
Enemy enemy = new Enemy("Goblin", 30);
DungeonOrganizer.Items.Item item = new DungeonOrganizer.Items.Item("Mikstura", 15);

GamePrinter.ShowHeader("Dungeon Organizer");
GamePrinter.ShowCharacter(player.Name, player.Health);
GamePrinter.ShowCharacter(enemy.Name, enemy.Health);
GamePrinter.ShowItem(item.Name, item.Price);

DungeonOrganizer.Items.Weapon bron = new DungeonOrganizer.Items.Weapon("Miecz", 8);
Console.WriteLine($"\n{bron.Name} zadaje {bron.Damage} obrażeń");