namespace MercenaryGuild
{
    public class Mercenary
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int ExperiencePoints { get; set; }
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public int Damage { get; set; }
        public int Gold { get; set; }

        public Mercenary(string name, int level, int experiencePoints, int maxHealth, int damage, int gold)
        {
            Name = name;
            Level = level;
            ExperiencePoints = experiencePoints;
            MaxHealth = maxHealth;
            CurrentHealth = maxHealth;
            Damage = damage;
            Gold = gold;
        }

        public override string ToString()
        {
            return $"Mercenary: {Name} (Level {Level}, HP: {CurrentHealth}/{MaxHealth}, Damage: {Damage}, Gold: {Gold})";
        }
    }
}
