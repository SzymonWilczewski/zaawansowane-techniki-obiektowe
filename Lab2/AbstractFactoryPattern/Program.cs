using AbstractFactoryPattern.Macintosh;
using AbstractFactoryPattern.Windows;

namespace AbstractFactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var factoryA = new MacFactory();
            var factoryB = new WinFactory();

            var uiA = new UserInterface(factoryA);
            uiA.DrawWindow();

            var uiB = new UserInterface(factoryB);
            uiB.DrawWindow();
        }
    }
}
