using System;

namespace BuilderPattern1
{
    public class Program
    {
        static void Main()
        {
            var carBuilder = new Car.CarBuilder();
            var director = new Director
            {
                Builder = carBuilder
            };

            director.BuildMinimalViableProduct();
            var minimalCar = carBuilder.Build();
            Console.WriteLine(minimalCar.ToString());

            director.BuildFullFeaturedProduct();
            var fullFeaturedCar = carBuilder.Build();
            Console.WriteLine(fullFeaturedCar.ToString());
        }
    }
}
