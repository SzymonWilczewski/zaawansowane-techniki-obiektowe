namespace AbstractFactoryPattern
{
    public class UserInterface
    {
        private readonly IGuiFactory _factory;

        public UserInterface(IGuiFactory factory)
        {
            _factory = factory;
        }

        public void DrawWindow()
        {
            var button = _factory.CreateButton();
            var checkbox = _factory.CreateCheckBox();

            button.Draw();
            checkbox.Draw();
        }
    }
}
