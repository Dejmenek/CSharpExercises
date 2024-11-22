namespace AdvancedClasses;
public class Weapon : IItem
{
    public string Name { get; private set; }
    public int Damage { get; private set; }

    public Weapon(string name, int damage)
    {
        Name = name;
        Damage = damage;
    }

    public string GetDescription() => $"Name: {Name}, Damage: {Damage}";

    public void Use() => Console.WriteLine("Swinging the sword!");
}
