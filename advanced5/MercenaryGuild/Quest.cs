namespace MercenaryGuild
{
    public class Quest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public QuestDifficulty Difficulty { get; set; }
        public Monster Monster { get; set; }
        public int ExperienceReward { get; set; }
        public int GoldReward { get; set; }

        public Quest(string name, string description, string location, QuestDifficulty difficulty, 
                    Monster monster, int experienceReward, int goldReward)
        {
            Name = name;
            Description = description;
            Location = location;
            Difficulty = difficulty;
            Monster = monster;
            ExperienceReward = experienceReward;
            GoldReward = goldReward;
        }

        public override string ToString()
        {
            return $"Quest: {Name} ({Difficulty}) - {Description}\nLocation: {Location}\nRewards: {ExperienceReward} XP, {GoldReward} Gold";
        }
    }
}
