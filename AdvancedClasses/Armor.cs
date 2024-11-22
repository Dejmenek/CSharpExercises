namespace AdvancedClasses;
public class Armor : IItem
{
    public string Name { get; private set; }
    public int Defense { get; private set; }

    public Armor(string name, int defense)
    {
        Name = name;
        Defense = defense;
    }

    public string GetDescription() => $"Name {Name}, Defense {Defense}";

    public void Use()
    {
        Console.WriteLine("Equipping the armor.");
    }
}
