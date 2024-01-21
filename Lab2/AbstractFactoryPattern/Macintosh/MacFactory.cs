namespace AbstractFactoryPattern.Macintosh
{
    public class MacFactory : IGuiFactory
    {
        public IButton CreateButton() => new MacButton();
        public ICheckbox CreateCheckBox() => new MacCheckbox();
    }
}
