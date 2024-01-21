using System;

namespace DependencyInjectionContainersLib.DataProvider
{
    public class DataProvider : IDataProvider
    {
        public void GetData() => Console.WriteLine("Data downloading...");
        public void SetData() => Console.WriteLine("Data saving...");
    }
}
