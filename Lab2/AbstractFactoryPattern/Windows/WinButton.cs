using System;

namespace AbstractFactoryPattern.Windows
{
    internal class WinButton : IButton
    {
        public void Draw() => Console.WriteLine("Windows button has been drawn");
    }
}
