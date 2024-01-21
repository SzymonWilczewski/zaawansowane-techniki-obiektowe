using System;

namespace AbstractFactoryPattern.Windows
{
    internal class WinCheckbox : ICheckbox
    {
        public void Draw() => Console.WriteLine("Windows checkbox has been drawn");
    }
}
