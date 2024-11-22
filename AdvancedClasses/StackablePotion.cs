namespace AdvancedClasses;
public class StackablePotion : Potion, IStackable
{
    public int StackSize { get; set; }
    public StackablePotion(string name, int healingAmount, int stackSize) : base(name, healingAmount)
    {
        StackSize = stackSize;
    }


    public void Stack(int amount)
    {
        StackSize += amount;
    }

    public override string GetDescription() => $"{base.GetDescription()}, Stack Size: {StackSize}";
}
