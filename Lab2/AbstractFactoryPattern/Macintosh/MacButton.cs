using System;

namespace AbstractFactoryPattern.Macintosh
{
    internal class MacButton : IButton
    {
        public void Draw() => Console.WriteLine("Macintosh button has been drawn");
    }
}
