using System.Runtime.ExceptionServices;

Player player = new Player();

Console.WriteLine("Welcome to The Game.");

while (player.Name.Length < 1)
{
    Console.WriteLine("What is your name random guy?");
    player.Name = Console.ReadLine();
}

Console.WriteLine($"{player.Name}...");

Monster hans = new Monster();
Monster.MakeAMonster(hans, "Hans", 2, 1, 1);
Console.WriteLine($"A monster appears. His name is {hans.Name}");
Monster.MonsterInterraction(hans, player);


Console.WriteLine(hans.CurrentMood);
Console.WriteLine(hans.Hp);
Console.WriteLine(player.Hp);

Console.ReadLine();