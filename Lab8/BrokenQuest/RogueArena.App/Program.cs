using RogueArena.Core.Characters;
using RogueArena.Core.Rewards;
using RogueArena.Reporting;

Hero hero = new Hero("Ada", 100);
Companion companion = new Companion("Borys");
Monster monster = new Monster("Ork",50);

int reward = RewardCalculator.Calculate(45);

Console.WriteLine($"Bohater: {hero.Name}");
Console.WriteLine($"Towarzysz: {companion.Name}");
Console.WriteLine($"Nagroda: {reward} szt. złota");
Console.WriteLine();
Console.WriteLine(BattleReport.Create(hero,monster,reward));
Console.WriteLine(PartyReport.Create(hero,companion));