namespace AdvancedClasses;
public abstract class Character
{
    public string Name { get; private set; }
    public int Level { get; protected set; }
    public int Health { get; protected set; }

    protected Character(string name, int level, int health)
    {
        Name = name;
        Level = level;
        Health = health;
    }

    public void TakeDamage(int amount)
    {
        Health -= amount;
        if (Health < 0) Health = 0;
    }

    public abstract void DisplayStats();
}
