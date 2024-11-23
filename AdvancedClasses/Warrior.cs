namespace AdvancedClasses;
public class Warrior : Character
{
    public int Strength { get; private set; }

    public Warrior(string name, int level, int health, int strength) : base(name, level, health)
    {
        Attack = DefaultAttack;
        Strength = strength;
    }

    public override void DisplayStats()
    {
        Console.WriteLine($"Name: {Name}\nLevel: {Level}\nHealth: {Health}\nStrength: {Strength}");
    }

    private void DefaultAttack()
    {
        Console.WriteLine($"{Name} swings the sword!");
    }

    public void OnLevelUp()
    {
        Console.WriteLine($"Warrior {Name} has reached Level {Level}! Mana increased.");
    }

    public void OnHealthChanged(int newHealth)
    {
        if (newHealth < 20)
        {
            Console.WriteLine($"Warrior {Name}'s health is critically low!");
        }
    }
}
