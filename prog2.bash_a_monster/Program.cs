using System.Runtime.ExceptionServices;

Player player = new Player();

Console.WriteLine("Welcome to The Game.");

while (player.Name.Length < 1)
{
    Console.WriteLine("What is your name random guy?");
    player.Name = Console.ReadLine();
}

Console.WriteLine($"{player.Name}...");

Monster monster = new Monster();
Monster.MakeAMonster(monster, "Hans", 2, 1, 1);
Console.WriteLine($"A monster appears. His name is {monster.Name}");
Monster.MonsterInterraction(monster, player);


Console.WriteLine($"{monster.Name} mood is {monster.CurrentMood}");
Console.WriteLine($"{monster.Name} hp: {monster.Hp}");
Console.WriteLine($"{player.Name} hp: {player.Hp}");

Console.ReadLine();