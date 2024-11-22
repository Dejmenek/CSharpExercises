namespace AdvancedClasses;
public interface IStackable
{
    int StackSize { get; set; }
    void Stack(int amount);
}
