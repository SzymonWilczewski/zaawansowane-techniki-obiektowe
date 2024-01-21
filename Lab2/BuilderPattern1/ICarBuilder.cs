namespace BuilderPattern1
{
    public interface ICarBuilder
    {
        void Reset();
        void SetEngine();
        void SetSeats();
        void SetTripComputer();
        void SetGps();
        void SetManual();
    }
}
