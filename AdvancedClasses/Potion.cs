namespace AdvancedClasses;
public class Potion : IItem
{
    public string Name { get; private set; }
    public int HealingAmount { get; private set; }

    public Potion(string name, int healingAmount)
    {
        Name = name;
        HealingAmount = healingAmount;
    }

    public virtual string GetDescription() => $"Name: {Name}, HealingAmount: {HealingAmount}";

    public void Use()
    {
        Console.WriteLine("Drinking the potion and healing.");
    }
}
