namespace AbstractFactoryPattern
{
    public interface IGuiFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckBox();
    }
}
