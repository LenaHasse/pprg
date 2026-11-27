using GameWeapon = RogueSemester.Core.Items.Weapon;
using RogueSemester.Reporting.Reports;
using RogueSemester.Core.Combat;

namespace RogueSemester.App.UI;

public static class GameController
{
    public static void Run()
    {
        //PLAYER 
        string? name;

        do
        {
            Console.Write("Podaj imię bohatera: ");
            name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Imię nie może być puste.");
            }
        }
        while (string.IsNullOrWhiteSpace(name));

        Player player = new Player(name.Trim(), 100);
        var sword = new GameWeapon("Miecz", 15, 5);
        player.Inventory.Add(sword);
        player.EquipWeapon(sword);
        // Pełna nazwa wskazuje, że to przedmiot modelu Core.
        player.Inventory.Add(new RogueSemester.Core.Items.Item("Mikstura", 5));

        //ENEMIES
        List<Enemy> enemies = new List<Enemy>
        {
            new Enemy("Ork",30,5),
            new Enemy("Zombie",15,3),
            new Enemy("Smok",50,10)
        };

        Console.WriteLine(PlayerReport.Create(player));
        Console.WriteLine();
        //MENU
        bool playing=true;
        string endReason="";

        while (playing && player.Health > 0 && enemies.Count >0)
        {
            switch (ShowMenu())
            {
                case 1:
                    Enemy enemy = ChooseEnemy(enemies);
                    Console.WriteLine();
                    Fight(player, enemy);

                    if (enemy.Health==0)
                    {
                        enemies.Remove(enemy);
                    }
                    break;
                
                case 2:
                    Console.WriteLine(PlayerReport.Create(player));
                    break;

                case 3:
                    endReason="gracz zakończył wyprawę";
                    playing= false;
                    break;
                
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
        if (player.Health==0)
        {
            endReason="bohater zginął";
        }
        else if (enemies.Count==0)
        {
            endReason="Pokonano wszystkich przeciwników";
        }
        Console.WriteLine(ExpeditionReport.Create(player, player.DefeatedCount,endReason));
    }

    public static void Fight(Player player, Enemy enemy)
    {
        int weaponDamage=0;
        if (player.EquippedWeapon !=null)
        {
            weaponDamage = player.EquippedWeapon.Damage;
        }
        int playerDamage=CombatRules.CalculateDamage(player.Strength, weaponDamage);

        int enemyDamage = CombatRules.CalculateDamage(enemy.Damage, 0);

        Console.WriteLine($"Walka z {enemy.Name} za {enemy.Reward}");
        
        do
        {
            enemy.TakeDamage(playerDamage);
            Console.WriteLine($">>  [{player.Name}] -- ({playerDamage} dmg) --> [{enemy.Name}] (hp: {enemy.Health}/{enemy.MaxHealth})");
            if (enemy.Health > 0)
            {
                player.TakeDamage(enemyDamage);
                Console.WriteLine($"<<  [{enemy.Name}] -- ({enemyDamage} dmg) --> [{player.Name}] (hp: {player.Health}/{player.MaxHealth})");
            }
        

        }
        while (enemy.Health >0 && player.Health >0);
        if (enemy.Health == 0)
        {
            player.WonBattle(enemy.Reward);
            Console.WriteLine($"{player.Name} wygrał!");
        }
        else
        {
            Console.WriteLine($"{enemy.Name} wygrał!");
        }
    }

    public static Enemy ChooseEnemy(List<Enemy> enemies)
    {
        while (true)
        {
            for (int i=0; i < enemies.Count; i++)
            {
                Console.WriteLine($"{i+1}. {enemies[i].Name}");
            }

            Console.Write("Wybierz nr przeciwnika: ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int choice) && choice >=1 && choice <= enemies.Count)
            {
                return enemies[choice-1];
            }
            Console.WriteLine("Nieprawidłowy wybór");
        }
    }

    public static int ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("=== MENU ===");
            Console.WriteLine("1. Ropocznij walkę");
            Console.WriteLine("2. Pokaż raport bohatera");
            Console.WriteLine("3. Zakończ wyprawę");

            Console.Write("Wybór: ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int choice) && choice >=1 && choice <= 3)
            {
                return choice;
            }
            Console.WriteLine("Nieprawidłowy wybór");
        }
    }
}