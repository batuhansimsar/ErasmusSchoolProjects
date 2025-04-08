using MercenaryGuild;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        var guild = new Guild();

        // Create some mercenaries
        var mercenary1 = new Mercenary("Geralt", 10, 1000, 100, 20, 500);
        var mercenary2 = new Mercenary("Letho", 8, 800, 80, 15, 300);
        var mercenary3 = new Mercenary("Vesemir", 12, 1200, 120, 25, 600);

        // Create some monsters
        var monster1 = new Monster("Dragon", 200, 30);
        var monster2 = new Monster("Goblin", 50, 10);
        var monster3 = new Monster("Troll", 150, 25);

        // Create some quests
        var quest1 = new Quest("Dragon Hunt", "Hunt down the ancient dragon", "Mountain Peak", 
                             QuestDifficulty.VeryHard, monster1, 500, 1000);
        var quest2 = new Quest("Goblin Cleanup", "Clear the goblin infestation", "Forest", 
                             QuestDifficulty.Easy, monster2, 100, 200);
        var quest3 = new Quest("Troll Bridge", "Defeat the troll under the bridge", "River Valley", 
                             QuestDifficulty.Hard, monster3, 300, 600);

        // Add event handlers
        guild.OnMercenaryHired += (m) => 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Welcome to the guild, {m.Name}!");
            Console.ResetColor();
        };

        guild.OnQuestAdded += (q) => 
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"New quest available: {q.Name}");
            Console.ResetColor();
        };

        guild.OnQuestCompleting += (m, q) => 
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{m.Name} is preparing for quest: {q.Name}");
            Console.ResetColor();
        };

        guild.OnQuestCompleted += (m, q) => 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Quest report: {m.Name} completed {q.Name}");
            Console.ResetColor();
        };

        // Add mercenaries and quests to the guild
        guild.HireMercenary(mercenary1);
        guild.HireMercenary(mercenary2);
        guild.HireMercenary(mercenary3);

        guild.AddQuest(quest1);
        guild.AddQuest(quest2);
        guild.AddQuest(quest3);

        // Test quest completion
        guild.SendMercenaryOnQuest("Geralt", "Dragon Hunt");
        guild.SendMercenaryOnQuest("Letho", "Goblin Cleanup");
        guild.SendMercenaryOnQuest("Vesemir", "Troll Bridge");

        // Test search functionality
        Console.WriteLine("\nSearching for mercenaries:");
        var highLevelMercenaries = guild.FindMercenariesByLevelOrHealth(9, 90);
        foreach (var merc in highLevelMercenaries)
        {
            Console.WriteLine(merc);
        }

        Console.WriteLine("\nSearching for quests:");
        var hardQuests = guild.FindQuestsByLocationAndDifficulty("Mountain Peak", QuestDifficulty.VeryHard);
        foreach (var quest in hardQuests)
        {
            Console.WriteLine(quest);
        }
    }
}
