using System;

namespace AbstractFactoryPattern.Macintosh
{
    internal class MacCheckbox : ICheckbox
    {
        public void Draw() => Console.WriteLine("Macintosh checkbox has been drawn");
    }
}
