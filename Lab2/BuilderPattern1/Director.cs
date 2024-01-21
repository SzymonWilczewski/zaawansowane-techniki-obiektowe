namespace BuilderPattern1
{
    internal class Director
    {
        private ICarBuilder _builder;
        public ICarBuilder Builder { set { _builder = value; } }

        public void BuildMinimalViableProduct()
        {
            _builder.Reset();
            _builder.SetEngine();
            _builder.SetSeats();
        }

        public void BuildFullFeaturedProduct()
        {
            _builder.Reset();
            _builder.SetEngine();
            _builder.SetSeats();
            _builder.SetTripComputer();
            _builder.SetGps();
            _builder.SetManual();
        }
    }
}
