namespace AdvancedClasses;
public class Warrior : Character
{
    public int Strength { get; private set; }

    public Warrior(string name, int level, int health, int strength) : base(name, level, health)
    {
        Strength = strength;
    }

    public override void DisplayStats()
    {
        Console.WriteLine($"Name: {Name}\nLevel: {Level}\nHealth: {Health}\nStrength: {Strength}");
    }

    public void PowerAttack()
    {
        Console.WriteLine("Performing strong attack");
    }
}
