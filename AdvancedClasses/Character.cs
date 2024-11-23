namespace AdvancedClasses;
public abstract class Character
{
    private int _health;
    private int _level;
    public string Name { get; private set; }
    public int Level
    {
        get { return _level; }
        protected set
        {
            _level = value;
            LevelChanged?.Invoke();
        }
    }
    public int Health
    {
        get { return _health; }
        protected set
        {
            _health = value;
            HealthChanged?.Invoke(value);
        }
    }
    public delegate void AttackDelegate();
    public AttackDelegate Attack { get; set; }
    public event Action<int> HealthChanged;
    public event Action LevelChanged;

    protected Character(string name, int level, int health)
    {
        Name = name;
        Level = level;
        Health = health;
    }

    public void ChangeAttack(AttackDelegate newAttack)
    {
        Attack = newAttack;
    }

    public void PerformAttack()
    {
        Attack?.Invoke();
    }

    public void TakeDamage(int amount)
    {
        Health -= amount;
        if (Health < 0) Health = 0;
    }

    public void LevelUp()
    {
        Level++;
    }

    public abstract void DisplayStats();
}
