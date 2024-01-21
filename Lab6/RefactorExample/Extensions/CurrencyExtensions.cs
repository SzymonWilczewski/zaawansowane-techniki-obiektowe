using System.Globalization;

namespace RefactorExample.Extensions
{
    internal static class CurrencyExtensions
    {
        internal static string ToPolishZloty(this int value) => (value / 100).ToString("c", new CultureInfo("pl-PL"));
    }
}
