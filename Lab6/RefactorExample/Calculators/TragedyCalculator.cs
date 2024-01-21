using System;

namespace RefactorExample.Calculators
{
    internal class TragedyCalculator : IPerformanceCalculator
    {
        public int AmountFor(int audience)
        {
            int result = 40000;
            if (audience > 30)
            {
                result += 1000 * (audience - 30);
            }

            return result;
        }

        public int VolumeCreditsFor(int audience)
        {
            return Math.Max(audience - 30, 0);
        }
    }
}
