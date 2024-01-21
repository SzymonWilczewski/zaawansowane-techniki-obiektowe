using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using RefactorExample.Calculators;
using RefactorExample.DTOs;
using RefactorExample.Entities;
using RefactorExample.Render;
using RefactorExample.Statements;

[assembly: InternalsVisibleTo("RefactorExample.Tests")]

namespace RefactorExample
{
    internal class Statement
    {
        private readonly Invoice invoice;
        private readonly Dictionary<string, Play> plays;

        public Statement(Invoice invoice, Dictionary<string, Play> plays)
        {
            this.invoice = invoice;
            this.plays = plays;
        }

        private EnrichedPerformance EnrichPerformance(Performance performance)
        {
            IPerformanceCalculator calculator = FactoryCalculator.Create(GetPlay(performance));

            return new EnrichedPerformance(
                performance.PlayID,
                performance.Audience,
                calculator.AmountFor(performance.Audience),
                GetPlay(performance),
                calculator.VolumeCreditsFor(performance.Audience));
        }

        public string CreateStatement()
        {
            StatementData statementData = new StatementData(invoice.Customer,
                invoice.Performances.Select(x => EnrichPerformance(x)).ToList());

            return new PlainTextRenderer().Render(statementData);
        }

        private Play GetPlay(Performance performance) => plays[performance.PlayID];
    }
}
