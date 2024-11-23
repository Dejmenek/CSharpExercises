using AdvancedClasses;

internal class Program
{
    private static void Main(string[] args)
    {
        var warrior = new Warrior("Guts", 10, 100, 120);
        var mage = new Mage("Gandalf", 10, 100, 100);
        warrior.HealthChanged += warrior.OnHealthChanged;
        warrior.LevelChanged += warrior.OnLevelUp;
        mage.HealthChanged += mage.OnHealthChanged;
        mage.LevelChanged += mage.OnLevelUp;

        warrior.ChangeAttack(() => Console.WriteLine($"{warrior.Name} attacks defensively!"));

        warrior.PerformAttack();
        mage.TakeDamage(10);
        mage.PerformAttack();
        warrior.TakeDamage(90);
        mage.ChangeAttack(() => Console.WriteLine($"{mage.Name} casts Fireball!"));
        mage.PerformAttack();
        warrior.TakeDamage(5);
        //mage.LevelUp();
        mage.DisplayStats();
        //Console.WriteLine();
        warrior.DisplayStats();



        warrior.HealthChanged -= warrior.OnHealthChanged;
        mage.HealthChanged -= mage.OnHealthChanged;
        mage.LevelChanged -= mage.OnLevelUp;
        warrior.LevelChanged -= warrior.OnLevelUp;

        //var inventory = new Inventory();
        //inventory.Add(new Weapon("Sword of Destiny", 50));
        //inventory.Add(new Armor("Dragon Scale Armor", 30));
        //inventory.Add(new Potion("Healing potion", 50));
        //inventory.DisplayItems();
        //Console.WriteLine("\nUsing items in inventory:");
        //inventory.UseItems();
    }
}