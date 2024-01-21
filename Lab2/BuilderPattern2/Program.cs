using System;

namespace BuilderPattern2
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

            // Builder with a fluent interface
            var builderFluent = new Car.CarBuilderFluent();
            var carFluent = builderFluent.SetEngine()
                .SetGps()
                .SetSeats()
                .SetTripComputer()
                .Build();
            Console.WriteLine(carFluent.ToString());
        }
    }
}
