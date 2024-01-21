using System;

namespace LiskovSubstitutionPrinciple1
{
    public class Weight
    {
        public double Value { get; init; }

        public Weight(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Weight can not be negative");
            }

            this.Value = value;
        }
    }
}
