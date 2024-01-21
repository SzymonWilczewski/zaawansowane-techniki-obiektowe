using System;

namespace RefactorExample.Calculators
{
    internal class ComedyCalculator : IPerformanceCalculator
    {
        public int AmountFor(int audience)
        {
            int result = 30000;
            if (audience > 20)
            {
                result += 10000 + 500 * (audience - 20);
            }
            result += 300 * audience;

            return result;
        }

        public int VolumeCreditsFor(int audience)
        {
            var volumeCredits = Math.Max(audience - 30, 0);
            volumeCredits += (int)Math.Floor((decimal)audience / 5);

            return volumeCredits;
        }
    }
}
