namespace MercenaryGuild
{
    public class Monster
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }

        public Monster(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public override string ToString()
        {
            return $"Monster: {Name} (HP: {Health}, Damage: {Damage})";
        }
    }
}
