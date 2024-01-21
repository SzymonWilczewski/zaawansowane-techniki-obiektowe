using RefactorExample.Extensions;
using RefactorExample.Statements;
using System;

namespace RefactorExample.Render
{
    internal class PlainTextRenderer : IRenderer
    {
        public string Render(StatementData data)
        {
            var results = $"Rachunek dla {data.Customer}";

            foreach (var performance in data.Performances)
            {
                // Create statement row
                results += $"{performance.Play.Name}: {performance.Amount.ToPolishZloty()} (liczba miejsc: {performance.Audience}" + Environment.NewLine;
            }

            results += $"Naleznosc: {data.TotalAmount().ToPolishZloty()}" + Environment.NewLine;
            results += $"Punkty promocyjne: {data.TotalVolumeCredits()}";

            return results;
        }
    }
}
