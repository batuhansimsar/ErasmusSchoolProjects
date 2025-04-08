namespace MercenaryGuild
{
    public class Guild
    {
        private List<Mercenary> mercenaries;
        private List<Quest> quests;

        // Delegates
        public delegate void MercenaryAction(Mercenary mercenary);
        public delegate void QuestAction(Quest quest);
        public delegate void QuestMercenaryAction(Mercenary mercenary, Quest quest);

        // Events
        public event MercenaryAction? OnMercenaryHired;
        public event QuestAction? OnQuestAdded;
        public event QuestMercenaryAction? OnQuestCompleting;
        public event QuestMercenaryAction? OnQuestCompleted;

        public Guild()
        {
            mercenaries = new List<Mercenary>();
            quests = new List<Quest>();
        }

        public void HireMercenary(Mercenary mercenary)
        {
            if (mercenaries.Any(m => m.Name == mercenary.Name))
            {
                throw new Exception($"Mercenary with name {mercenary.Name} already exists in the guild!");
            }

            mercenaries.Add(mercenary);
            OnMercenaryHired?.Invoke(mercenary);
        }

        public void AddQuest(Quest quest)
        {
            if (quests.Any(q => q.Name == quest.Name))
            {
                throw new Exception($"Quest with name {quest.Name} already exists in the guild!");
            }

            quests.Add(quest);
            OnQuestAdded?.Invoke(quest);
        }

        public void SendMercenaryOnQuest(string mercenaryName, string questName)
        {
            var mercenary = mercenaries.FirstOrDefault(m => m.Name == mercenaryName);
            var quest = quests.FirstOrDefault(q => q.Name == questName);

            if (mercenary == null)
                throw new Exception($"Mercenary {mercenaryName} not found!");
            if (quest == null)
                throw new Exception($"Quest {questName} not found!");

            OnQuestCompleting?.Invoke(mercenary, quest);

            // Simulate quest completion
            mercenary.CurrentHealth -= quest.Monster.Damage;
            if (mercenary.CurrentHealth > 0)
            {
                mercenary.ExperiencePoints += quest.ExperienceReward;
                mercenary.Gold += quest.GoldReward;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{mercenary.Name} successfully completed the quest {quest.Name}!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{mercenary.Name} failed the quest {quest.Name} and was defeated!");
            }
            Console.ResetColor();

            OnQuestCompleted?.Invoke(mercenary, quest);
        }

        public void PerformActionOnMercenaries(MercenaryAction action)
        {
            foreach (var mercenary in mercenaries)
            {
                action(mercenary);
            }
        }

        public void PerformActionOnQuests(QuestAction action)
        {
            foreach (var quest in quests)
            {
                action(quest);
            }
        }

        public Mercenary? FindMercenaryByName(string name)
        {
            return mercenaries.Find(m => m.Name == name);
        }

        public List<Mercenary> FindMercenariesByLevelOrHealth(int minLevel, int minHealth)
        {
            return mercenaries.FindAll(m => m.Level > minLevel || m.MaxHealth > minHealth);
        }

        public Quest? FindQuestByName(string name)
        {
            return quests.Find(q => q.Name == name);
        }

        public List<Quest> FindQuestsByLocationAndDifficulty(string location, QuestDifficulty difficulty)
        {
            return quests.FindAll(q => q.Location == location && q.Difficulty == difficulty);
        }
    }
}
