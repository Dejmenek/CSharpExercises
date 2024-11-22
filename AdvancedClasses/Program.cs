using AdvancedClasses;

internal class Program
{
    private static void Main(string[] args)
    {
        //var warrior = new Warrior("Guts", 10, 100, 120);
        //var mage = new Mage("Gandalf", 10, 100, 100);

        //warrior.PowerAttack();
        //mage.TakeDamage(10);
        //mage.CastSpell("Fireball");
        //warrior.TakeDamage(20);
        //mage.DisplayStats();
        //warrior.DisplayStats();

        var inventory = new Inventory();
        inventory.Add(new Weapon("Sword of Destiny", 50));
        inventory.Add(new Armor("Dragon Scale Armor", 30));
        inventory.Add(new Potion("Healing potion", 50));
        inventory.DisplayItems();
        Console.WriteLine("\nUsing items in inventory:");
        inventory.UseItems();
    }
}