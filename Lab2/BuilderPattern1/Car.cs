using System.Collections.Generic;

namespace BuilderPattern1
{
    public class Car
    {
        public string Engine { get; init; }
        public string Seats { get; init; }
        public string TripComputer { get; init; }
        public string Gps { get; init; }
        public string Manual { get; init; }

        private Car() { }

        public override string ToString()
        {
            var parts = new List<string>();

            if (Engine != null) parts.Add($"Engine: {Engine}");
            if (Seats != null) parts.Add($"Seats: {Seats}");
            if (TripComputer != null) parts.Add($"TripComputer: {TripComputer}");
            if (Gps != null) parts.Add($"GPS: {Gps}");
            if (Manual != null) parts.Add($"Manual: {Manual}");

            return string.Join(", ", parts);
        }

        public class CarBuilder : ICarBuilder
        {
            private string engine;
            private string seats;
            private string tripComputer;
            private string gps;
            private string manual;

            public CarBuilder()
            {
                this.Reset();
            }

            public void Reset()
            {
                this.engine = null;
                this.seats = null;
                this.tripComputer = null;
                this.gps = null;
                this.manual = null;
            }

            public void SetEngine() => this.engine = "Powerful Engine";
            public void SetSeats() => this.seats = "Comfortable Seats";
            public void SetTripComputer() => this.tripComputer = "Advanced Trip Computer";
            public void SetGps() => this.gps = "High-precision GPS";
            public void SetManual() => this.manual = "Responsive Manual Gearbox";

            public Car Build()
            {
                var car = new Car()
                {
                    Engine = this.engine,
                    Seats = this.seats,
                    TripComputer = this.tripComputer,
                    Gps = this.gps,
                    Manual = this.manual
                };
                this.Reset();
                return car;
            }
        }
    }
}
