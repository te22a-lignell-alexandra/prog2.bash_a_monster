Player player = new Player();

Console.WriteLine("Welcome to The Game.");

while (player.Name.Length < 1)
{
    Console.WriteLine("What is your name warrior?");
    player.Name = Console.ReadLine();
}

Console.WriteLine($"{player.Name}...");

Monster hans = new Monster() {
    Name = "Hans" ,
    Hp = 3 ,
    Strength = 1
};

hans.i = 1;
hans.CurrentMood = hans.Mood[hans.i];

while (true)
{
    Console.WriteLine("choose");
    string choice = Console.ReadLine();
    while (choice != "pet" && choice != "hit" && choice != "leave")
    {
        Console.WriteLine("You must choose.");
        choice = Console.ReadLine();
    }

    if (choice == "pet")
    {
        hans.CurrentMood = hans.Mood[hans.i + 1];

        if (hans.CurrentMood == hans.Mood[4])
        {
            Console.WriteLine("Best friends");
            player.Hp += 2;
        }
    }
    else if (choice == "hit")
    {
        hans.CurrentMood = hans.Mood[hans.i - 1];
        hans.Hp -= player.Strength;

        if (hans.CurrentMood == hans.Mood[0])
        {
            player.Hp -= hans.Strength;
        }
        if (hans.Hp == 0)
        {
            Console.WriteLine("Dead");
            Console.ReadLine();
            break;
        }
    }
    else if (choice == "leave")
    {
        break;
    }
}

Console.WriteLine(hans.CurrentMood);
Console.WriteLine(hans.Hp);
Console.WriteLine(player.Hp);

Console.ReadLine();