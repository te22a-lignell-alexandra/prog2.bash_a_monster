public class Monster
{
    public string Name;
    public int Hp;
    public int Strength;
    public string[] Mood = ["angry", "sad", "okay", "happy", "very happy"];
    public string CurrentMood;
    public int i;

    public static Monster MakeAMonster(Monster monster, string name, int hp, int strength, int mood)
    {
        monster.Name = name;
        monster.Hp = hp;
        monster.Strength = strength;
        monster.i = mood;
        monster.CurrentMood = monster.Mood[monster.i];

        return monster;
    }
    
    public static void MonsterInterraction(Monster monster, Player player)
    {
        while (true)
        {
            Console.WriteLine("choose leave, hit or feed");
            string choice = Console.ReadLine();
            while (choice != "feed" && choice != "hit" && choice != "leave")
            {
                Console.WriteLine("You must choose.");
                choice = Console.ReadLine();
            }

            if (choice == "feed")
            {
                monster.i ++;
                monster.CurrentMood = monster.Mood[monster.i];

                if (monster.CurrentMood == monster.Mood[4])
                {
                    Console.WriteLine($"{player.Name} and {monster.Name} are friends");
                    player.Hp += 2;
                    Console.ReadLine();
                    break; 
                }
            }
            else if (choice == "hit")
            {
                if (monster.i > 0)
                {
                monster.i --;
                monster.CurrentMood = monster.Mood[monster.i];
                monster.Hp -= player.Strength;
                }
                if (monster.i == 0)
                {
                    player.Hp -= monster.Strength;
                }

                if (monster.Hp == 0)
                {
                    Console.WriteLine($"{monster.Name} dead");
                    Console.ReadLine();
                    break;
                }
                if (player.Hp == 0)
                {
                    Console.WriteLine($"{player.Name} dead");
                    Console.ReadLine();
                    break;
                }
            }
            else
            {
               break;
            }
        }
    }

    // public Monster()
    // {
    //     CurrentMood = Mood[Random.Shared.Next(Mood.Length)];
    // }
}