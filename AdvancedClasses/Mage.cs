namespace AdvancedClasses;
public class Mage : Character
{
    public int Mana { get; private set; }

    public Mage(string name, int level, int health, int mana) : base(name, level, health)
    {
        Attack = DefaultAttack;
        Mana = mana;
    }

    private void DefaultAttack()
    {
        Console.WriteLine($"{Name} casts Arcane Missile!");
    }

    public override void DisplayStats()
    {
        Console.WriteLine($"Name: {Name}\nLevel: {Level}\nHealth: {Health}\nMana: {Mana}");
    }

    public void OnLevelUp()
    {
        Console.WriteLine($"Mage {Name} has reached Level {Level}! Mana increased.");
    }

    public void OnHealthChanged(int newHealth)
    {
        if (newHealth < 20)
        {
            Console.WriteLine($"Mage {Name}'s health is critically low!");
        }
    }
}
