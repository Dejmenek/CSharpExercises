namespace AdvancedClasses;
public class Mage : Character
{
    public int Mana { get; private set; }

    public Mage(string name, int level, int health, int mana) : base(name, level, health)
    {
        Mana = mana;
    }

    public override void DisplayStats()
    {
        Console.WriteLine($"Name: {Name}\nLevel: {Level}\nHealth: {Health}\nMana: {Mana}");
    }

    public void CastSpell(string spellName)
    {
        Console.WriteLine($"Casting {spellName}");
    }
}
