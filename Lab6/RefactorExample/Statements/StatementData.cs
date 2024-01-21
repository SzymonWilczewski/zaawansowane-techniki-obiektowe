using RefactorExample.Entities;
using System.Collections.Generic;

namespace RefactorExample.Statements
{
    internal class StatementData
    {
        public string Customer { get; }

        private List<EnrichedPerformance> performances;
        public IEnumerable<EnrichedPerformance> Performances => this.performances.AsReadOnly();

        public StatementData(string customer, List<EnrichedPerformance> performances)
        {
            this.Customer = customer;
            this.performances = performances;
        }

        public int TotalAmount()
        {
            var result = 0;

            performances.ForEach(x => result += x.Amount);

            return result;
        }

        public int TotalVolumeCredits()
        {
            var result = 0;

            performances.ForEach(x => result += x.VolumeCredits);

            return result;
        }
    }
}
