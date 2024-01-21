namespace BuilderPattern2
{
    public interface ICarBuilderFluent
    {
        void Reset();
        Car.CarBuilderFluent SetEngine();
        Car.CarBuilderFluent SetSeats();
        Car.CarBuilderFluent SetTripComputer();
        Car.CarBuilderFluent SetGps();
        Car.CarBuilderFluent SetManual();
    }
}
