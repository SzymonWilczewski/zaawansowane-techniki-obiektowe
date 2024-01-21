namespace AbstractFactoryPattern.Windows
{
    public class WinFactory : IGuiFactory
    {
        public IButton CreateButton() => new WinButton();
        public ICheckbox CreateCheckBox() => new WinCheckbox();
    }
}
