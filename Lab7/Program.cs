Player player = new Player("Maciuś", 100, 25);
//Player player1 = new Player("Jacuś", 110, 35);
//Player player2 = new Player("Szymuś", 120, 45);

Enemy goblin = new Enemy("Goblin", 30, 8, "Melee",0.1,10);
Enemy nietoperz = new Enemy("Nietoperz",20,5,"Air",0.5,5);
Enemy ork = new Enemy("Ork",30,5,"Melee",0.6,11);
Enemy troll= new Enemy("Troll",60,9,"Melee",0.5,10);
Enemy smok=new Enemy("Smok",100,16,"Fire",0.05,100);

Item malaMikstura = new Item("Mała mikstura", 20, 3);
Item duzaMikstura = new Item("Duża mikstura", 50, 1);

player.AddItem(malaMikstura);
player.AddItem(duzaMikstura);

List<Enemy> enemies = new List<Enemy>
{
    goblin,
    nietoperz,
    ork,
    troll,
    smok
};

// foreach (Enemy enemy in enemies)
// {
//     Console.WriteLine($"{enemy.Name}: {enemy.Health} HP");
// }


// Console.WriteLine($"{player.Name} spotyka {goblin.Name}.");

// goblin.TakeDamage(12);
// Console.WriteLine($"{goblin.Name} ma {goblin.Health} HP.");

// if (goblin.IsAlive())
// {
//     player.TakeDamage(goblin.Damage);
//     Console.WriteLine($"{player.Name} ma {player.Health} HP.");
// }
// else
// {
//     Console.WriteLine("Przeciwnik został pokonany.");
// }


//zad3
//scenariusz Szymuś i nietoperz
// Console.WriteLine("Walka Szymusia i nietoperza");
// while (player2.IsAlive() && nietoperz.IsAlive())
// {
//     Console.WriteLine("Szymuś atakuje");
//     nietoperz.TakeDamage(12);
//     Console.WriteLine($"Nietoperz ma {nietoperz.Health} hp");
//         if (ork.IsAlive())
//     {
//         Console.WriteLine("Nietoperz atakuje");
//         player2.TakeDamage(10);
//         Console.WriteLine($"Szymus ma {player2.Health} hp");
//     }
// }

// if (player2.IsAlive())
// {
//     Console.WriteLine($"{player2.Name} wygrał!");
// }
// else
// {
//     Console.WriteLine($"{nietoperz.Name} wygrał!\n");
// }

// //scenariusz Jacuś i ork
// Console.WriteLine("Walka Jacusia i orka");
// while (player1.IsAlive() && ork.IsAlive())
// {
//     Console.WriteLine("Jacuś atakuje");
//     ork.TakeDamage(12);
//     Console.WriteLine($"Ork ma {ork.Health} hp");

//     if (ork.IsAlive())
//     {
//         Console.WriteLine("Ork atakuje");
//         player1.TakeDamage(10);
//         Console.WriteLine($"Jacuś ma {player1.Health} hp");
//     }
// }

// if (player1.IsAlive())
// {
//     Console.WriteLine($"{player1.Name} wygrał!");
// }
// else
// {
//     Console.WriteLine($"{ork.Name} wygrał!");
// }

// TuraWalki(wyborPrzeciwnika());

ShowEnemiesStatus();
//PĘTLA GRY
bool gameRunning=true;
while (gameRunning && player.IsAlive() && DefeatedEnemies()<enemies.Count)
{
    gameRunning=Menu();
}
if (!player.IsAlive())
{
    Console.WriteLine("Gracz został pokonany");
}
else if (DefeatedEnemies()==enemies.Count)
{
    Console.WriteLine("Zwycięstwo! Pokonano wszystkich przeciwników");
}
ShowSummary();
//==========================================================================
//metody
int DefeatedEnemies()
    {
        List<Enemy> niezywiEnemies=new List<Enemy>();
        foreach (Enemy enemy in enemies)
        {
            if (!enemy.IsAlive())
            niezywiEnemies.Add(enemy);
        }
        return niezywiEnemies.Count;
    }

void ShowEnemiesStatus()
{
    int ileNiezywych=0;
    int sumaHp=0;
    List<Enemy> zywiEnemy=new List<Enemy>();
    Console.WriteLine("\n=====ŻYWI PRZECIWNICY=====");
    foreach (Enemy enemy in enemies)
    {
        if ( enemy.IsAlive())
        {
            zywiEnemy.Add(enemy);
            sumaHp+=enemy.Health;
            Console.Write("- ");
            Console.WriteLine(enemy.Name);
        }
        else
        {
            ileNiezywych++;
        }
        
    }
    Console.WriteLine("==========================");

    Enemy maxHp = zywiEnemy[0];

    foreach (Enemy enemy in zywiEnemy)
    {
        if (enemy.Health > maxHp.Health)
        {
            maxHp = enemy;
        }
    }

    Console.WriteLine($"\n{maxHp.Name} ma najwięcej HP: {maxHp.Health}");
    Console.WriteLine($"Nieżywych jest {ileNiezywych}");
    
}

Enemy wyborPrzeciwnika()
{   List<Enemy> zywiEnemy=new List<Enemy>();
    foreach (Enemy enemy in enemies)
    {
        if ( enemy.IsAlive())
        {
            zywiEnemy.Add(enemy);
        }
    }

    int wybor;
    do
    {
        Console.WriteLine("Wybierz nr:");
        for (int i=0;i<zywiEnemy.Count;i++)
        {
            Console.WriteLine($"{i+1}. {zywiEnemy[i].Name}");
        }

    } while (
        !int.TryParse(Console.ReadLine(),out wybor)
        || wybor <1
        ||wybor>zywiEnemy.Count
    );
    return zywiEnemy[wybor-1];
}

bool Menu()
{
    Console.WriteLine("========MENU========");
    Console.WriteLine("1.Walcz z przeciwnikiem \n2. Pokaż status\n3.Pokaż ekwipunek\n4.Użyj przedmiotu\n5.Zakończ");
    if (!int.TryParse(Console.ReadLine(), out int wybor))
    {
        Console.WriteLine("Błąd: wpisz odpowiednią liczbę");
        return true;
    }

    switch (wybor)
    {
        
        case 1:
            TuraWalki(wyborPrzeciwnika());
            break;

        case 2:
            ShowStatusPlayer(player);
            break;

        case 3:
            player.ShowInventory();
            break;

        case 4:
            player.ShowInventory();
            Console.Write("Podaj numer przedmiotu: ");

            if (int.TryParse(Console.ReadLine(), out int numer))
                {
                    player.UseItem(numer - 1);
                }
                else
                {
                    Console.WriteLine("Błąd: wpisz numer przedmiotu.");
                }
                break;

        case 5:
            Console.WriteLine("Koniec gry");
            return false;

        default:
            Console.WriteLine("Nieprawidłowa opcja");
            break;
    }
    return true;
}

void ShowSummary()
{
    Console.WriteLine("=====PODSUMOWANIE======");
    Console.WriteLine($"Imię: {player.Name}");
    Console.WriteLine($"HP: {player.Health}/{player.MaxHealth}");
    Console.WriteLine($"Złoto: {player.Gold}");
    Console.WriteLine($"Poziom: {player.Level}");
    Console.WriteLine($"Punkty doświadczenia: {player.Experience}/100");
    Console.WriteLine($"Pokonani przeciwnicy {DefeatedEnemies()}");
    Console.WriteLine("\n=====EKWIPUNEK=====");
    player.ShowInventory();
    Console.WriteLine("===================");

}
void ShowStatusPlayer(Player player)
{
    Console.WriteLine($"==== STATUS {player.Name} ====");
    Console.WriteLine($"HP: {player.Health}/{player.MaxHealth}");
}

void ShowStatusEnemy(Enemy enemy)
{
    Console.WriteLine($"==== STATUS {enemy.Name} ====");
    Console.WriteLine($"HP: {enemy.Health}/{enemy.MaxHealth}");
}
void TuraWalki(Enemy enemy)
{
    Random random = new Random();

    while (player.IsAlive() && enemy.IsAlive())
    {
        Console.WriteLine();
        ShowStatusPlayer(player);
        Console.WriteLine();
        ShowStatusEnemy(enemy);

        Console.WriteLine($"{player.Name} atakuje!");

        if (enemy.IsProtected)
        {
            Console.WriteLine($"{enemy.Name} broni się!");
            enemy.TakeDamage(5);
            enemy.IsProtected = false;
        }
        else
        {
            enemy.TakeDamage(10);
        }

        if (!enemy.IsAlive())
        {
            Console.WriteLine($"{enemy.Name} został pokonany!");
            player.Gold += enemy.Reward;
            player.GainExperience(5);
            Console.WriteLine($"Otrzymano {enemy.Reward} złota.");
            break;
        }

        double los = random.NextDouble();

        if (los < enemy.Luck)
        {
            if (enemy.SpecialAction == "Defense")
            {
                enemy.IsProtected = true;
                Console.WriteLine($"{enemy.Name} przechodzi do obrony!");
            }
            else if (enemy.SpecialAction == "Escape")
            {
                Console.WriteLine($"{enemy.Name} uciekł z walki!");
                break;
            }
        }
        else
        {
            Console.WriteLine($"{enemy.Name} atakuje!");
            player.TakeDamage(enemy.Damage);
        }
    }

    if (!player.IsAlive())
    {
        Console.WriteLine($"{player.Name} został pokonany!");
    }
}